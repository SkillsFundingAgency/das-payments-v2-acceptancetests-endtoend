﻿using System.Linq;
using System.Threading.Tasks;
using Autofac;
using SFA.DAS.Payments.AcceptanceTests.Core.Data;
using SFA.DAS.Payments.AcceptanceTests.EndToEnd.Extensions;
using SFA.DAS.Payments.AcceptanceTests.EndToEnd.Helpers;
using SFA.DAS.Payments.Model.Core;
using SFA.DAS.Payments.Tests.Core;
using SFA.DAS.Payments.Tests.Core.Builders;
using TechTalk.SpecFlow;

namespace SFA.DAS.Payments.AcceptanceTests.EndToEnd.Steps
{
    [Binding]
    // ReSharper disable once InconsistentNaming
    public class PV2_1826_Steps : EndToEndStepsBase
    {
        private readonly FeatureContext featureContext;
        protected TestPaymentsDataContext testDataContext;

        [BeforeStep()]
        public void InitialiseNewTestDataContext()
        {
            testDataContext = Scope.Resolve<TestPaymentsDataContext>();
        }

        [AfterStep()]
        public void DeScopeTestDataContext()
        {
            testDataContext = null;
        }

        public PV2_1826_Steps(FeatureContext context) : base(context)
        {
            featureContext = context;
        }

        [Given(@"there are 2 price episodes in the ILR submitted for (.*), PE-1 and PE-2")]
        public void GivenAreTwoPriceEpisodesInTheILR(string collectionPeriodText)
        {
            TestSession.CollectionPeriod = new CollectionPeriodBuilder().WithSpecDate(collectionPeriodText).Build();
            TestSession.FM36Global = FM36GlobalDeserialiser.DeserialiseByFeatureForPeriod(featureContext.FeatureInfo.Title, TestSession.CollectionPeriod.Period.ToPeriodText());
        }

        [Given("(.*) in the ILR matches to both Commitments (.*) and (.*), on ULN and UKPRN")]
        public async Task GivenPriceEpisodeInIlrMatchesCommitments(string priceEpisodeIdentifier,
            string commitmentIdentifier1, string commitmentIdentifier2)
        {
            var learner = TestSession.FM36Global.Learners.Single();
            learner.ULN = TestSession.Learner.Uln;
            learner.LearnRefNumber = TestSession.Learner.LearnRefNumber;

            var priceEpisode = learner.PriceEpisodes.Single(y => y.PriceEpisodeIdentifier == priceEpisodeIdentifier);
            var learningDelivery = learner.LearningDeliveries.Single(x => x.AimSeqNumber == priceEpisode.PriceEpisodeValues.PriceEpisodeAimSeqNumber);

            var commitment1 = new ApprenticeshipBuilder().BuildSimpleApprenticeship(TestSession, learningDelivery.LearningDeliveryValues, ids.Min()).WithALevyPayingEmployer().WithApprenticeshipPriceEpisode(priceEpisode.PriceEpisodeValues).ToApprenticeshipModel();
            var commitment2 = new ApprenticeshipBuilder().BuildSimpleApprenticeship(TestSession, learningDelivery.LearningDeliveryValues, ids.Max()).WithALevyPayingEmployer().WithApprenticeshipPriceEpisode(priceEpisode.PriceEpisodeValues).ToApprenticeshipModel();

            TestSession.Apprenticeships.Add(commitmentIdentifier1, commitment1);
            testDataContext.Apprenticeship.Add(commitment1);
            testDataContext.ApprenticeshipPriceEpisode.AddRange(commitment1.ApprenticeshipPriceEpisodes);

            TestSession.Apprenticeships.Add(commitmentIdentifier2, commitment2);
            testDataContext.Apprenticeship.Add(commitment2);
            testDataContext.ApprenticeshipPriceEpisode.AddRange(commitment2.ApprenticeshipPriceEpisodes);

            var levyModel = TestSession.Employer.ToModel();
            levyModel.Balance = 1000000000;
            testDataContext.LevyAccount.Add(levyModel);
            await testDataContext.SaveChangesAsync();

            TestSession.FM36Global.UKPRN = TestSession.Provider.Ukprn;
        }

        public bool HasDLock9ErrorForPriceEpisode(string priceEpisodeIdentifier, short academicYear)
        {
            return EarningEventsHelper
                .GetOnProgrammeDataLockErrorsForLearnerAndPriceEpisode(priceEpisodeIdentifier, academicYear,
                    TestSession).Any(x => x == DataLockErrorCode.DLOCK_09);
        }

        public bool HasNoEarningEventMatch(string priceEpisodeIdentifier)
        {
            return !EarningEventsHelper.PayableEarningsReceivedForLearner(TestSession).Any(x => x.PriceEpisodes.Any(y => y.Identifier == priceEpisodeIdentifier));
        }

        [Then("there is a DLOCK-09 triggered for (.*) and no match in DAS")]
        public async Task ThenThereIsNoMatchForPriceEpisodeInDas(string priceEpisodeIdentifier)
        {
            await WaitForIt(() =>
                    HasDLock9ErrorForPriceEpisode(priceEpisodeIdentifier, short.Parse(TestSession.FM36Global.Year))
                    && HasNoEarningEventMatch(priceEpisodeIdentifier),
                "Failed to find a matching DLOCK-09 event and no earning events."
            );
        }
    }
}