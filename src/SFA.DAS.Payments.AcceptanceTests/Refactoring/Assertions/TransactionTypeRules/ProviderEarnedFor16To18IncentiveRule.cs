﻿using System.Collections.Generic;
using System.Linq;
using SFA.DAS.Payments.AcceptanceTests.Refactoring.ReferenceDataModels;
using SFA.DAS.Payments.AcceptanceTests.Refactoring.ResultsDataModels;

namespace SFA.DAS.Payments.AcceptanceTests.Refactoring.Assertions.TransactionTypeRules
{
    public class ProviderEarnedFor16To18IncentiveRule : ProviderTransationTypeRuleBase
    {
        protected override IEnumerable<PaymentResult> FilterPeriodPayments(IEnumerable<PaymentResult> periodPayments)
        {
            return periodPayments.Where(p => p.TransactionType == TransactionType.First16To18ProviderIncentive 
                                          || p.TransactionType == TransactionType.Second16To18ProviderIncentive);
        }

        protected override string FormatAssertionFailureMessage(PeriodValue period, decimal actualPaymentInPeriod)
        {
            var providerPeriod = (ProviderEarnedPeriodValue)period;
            var specPeriod = providerPeriod.PeriodName.ToPeriodDateTime().AddMonths(-1).ToPeriodName();
            return $"Expected provider {providerPeriod.ProviderId} to be paid {period.Value} in {specPeriod} for 16-18 incentive but was actually paid {actualPaymentInPeriod}";
        }
    }
}