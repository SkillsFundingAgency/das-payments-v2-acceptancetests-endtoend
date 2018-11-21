﻿using System;
using System.Collections.Generic;
using System.Linq;
using SFA.DAS.Payments.Core;

namespace SFA.DAS.Payments.AcceptanceTests.EndToEnd.EventMatchers
{
    public abstract class BaseMatcher<T>
    {
        protected abstract IList<T> GetActualEvents();

        protected abstract IList<T> GetExpectedEvents();

        protected abstract bool Match(T expected, T actual);

        public Tuple<bool, string> MatchPayments()
        {
            var actualPayments = GetActualEvents();

            var expectedPayments = GetExpectedEvents();

            var matchedPayments = expectedPayments
                .Where(expected => actualPayments.Any(actual => Match(expected, actual)))
                .ToList();

            var errors = new List<string>();

            if (matchedPayments.Count < expectedPayments.Count)
                errors.Add($"{expectedPayments.Count - matchedPayments.Count} out of {expectedPayments.Count} events were not found");

            if (matchedPayments.Count > expectedPayments.Count)
                errors.Add($"found {matchedPayments.Count - expectedPayments.Count} unexpected events");

            return new Tuple<bool, string>(errors.Count == 0, string.Join(", ", errors));
        }

        public Tuple<bool, string> MatchNoPayments()
        {
            var payments = GetActualEvents();
            return !payments.Any()
                ? new Tuple<bool, string>(true, string.Empty)
                : new Tuple<bool, string>(false, $"Found Unexpected Payments: {payments.Aggregate(string.Empty,(currText,payment)=> $"{currText}, {payment.ToJson()}")}");
        }
    }
}
