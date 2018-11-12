﻿using Autofac;
using SFA.DAS.Payments.AcceptanceTests.Core;
using SFA.DAS.Payments.AcceptanceTests.EndToEnd.Data;
using SFA.DAS.Payments.Application.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using SFA.DAS.Payments.AcceptanceTests.EndToEnd.EventMatchers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SFA.DAS.Payments.AcceptanceTests.EndToEnd.Steps
{
    [Binding]
    public class RefundsSteps : EndToEndStepsBase
    {
        public RefundsSteps(FeatureContext context) : base(context)
        {
        }

        [Given(@"the provider previously submitted the following learner details")]
        public void GivenTheProviderPreviouslySubmittedTheFollowingLearnerDetails(Table table)
        {
            var ilr = table.CreateSet<Training>().ToList();
            PreviousIlr = ilr;
        }

        [Given(@"the following earnings had been generated for the learner")]
        public void GivenTheFollowingEarningsHadBeenGeneratedForTheLearner(Table table)
        {
            var earnings = table.CreateSet<OnProgrammeEarning>().ToList();
            PreviousEarnings = earnings;
        }

        [Given(@"the following provider payments had been generated")]
        public void GivenTheFollowingProviderPaymentsHadBeenGenerated(Table table)
        {
            var previousJobId = TestSession.GenerateId();
            var previousSubmissionTime = DateTime.UtcNow.AddHours(-1);
            Console.WriteLine($"Previous job id: {previousJobId}");
            var payments = table.CreateSet<ProviderPayment>().ToList();
            var previousPayments = payments.SelectMany(p => CreatePayments(p, PreviousIlr.First(), previousJobId, previousSubmissionTime));

            var dataContext = Container.Resolve<IPaymentsDataContext>();
            dataContext.Payment.AddRange(previousPayments);
            dataContext.SaveChanges();
        }

        [Given(@"the Provider now changes the Learner details as follows")]
        public void GivenTheProviderNowChangesTheLearnerDetailsAsFollows(Table table)
        {
            var ilr = table.CreateSet<Training>().Select(t =>
            {
                if ((byte) t.ContractType == 0)
                    t.ContractType = PreviousIlr.Last().ContractType;
                if (string.IsNullOrEmpty(t.FundingLineType))
                    t.FundingLineType = PreviousIlr.Last().FundingLineType;
                return t;
            }).ToList();

            CurrentIlr = ilr;
        }

        [Given(@"price details as follows")]
        public void GivenPriceDetailsAsFollows(Table table)
        {
            CurrentPriceEpisodes = table.CreateSet<Price>().ToList();
        }

        [When(@"the amended ILR file is re-submitted for the learners in collection period (.*)")]
        [When(@"the ILR file is submitted for the learners for collection period (.*)")]
        public void WhenTheAmendedILRFileIsRe_SubmittedForTheLearnersInCollectionPeriodRCurrentAcademicYear(string collectionPeriod)
        {
            SetCollectionPeriod(collectionPeriod);
        }

        [Then(@"the following provider payments will be recorded")]
        public async Task ThenTheFollowingProviderPaymentsWillBeRecorded(Table table)
        {
            var expectedPayments = table.CreateSet<ProviderPayment>()
                .Where(p => p.CollectionPeriod.ToDate().ToCalendarPeriod().Name == CurrentCollectionPeriod.Name)
                .ToList();

            var dataContext = Container.Resolve<IPaymentsDataContext>();
            await WaitForIt(() => ProviderPaymentEventMatcher.MatchRecordedPayments(dataContext, expectedPayments, TestSession, CurrentIlr, CurrentCollectionPeriod), "Payment history check failure");
        }

    }
}