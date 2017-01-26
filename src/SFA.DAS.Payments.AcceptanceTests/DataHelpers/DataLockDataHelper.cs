﻿using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ProviderPayments.TestStack.Core;
using SFA.DAS.Payments.AcceptanceTests.Entities;

namespace SFA.DAS.Payments.AcceptanceTests.DataHelpers
{
    internal static class DataLockDataHelper
    {
        internal static DataLockMatch[] GetDataLockMatchesForUkprn(long ukprn, EnvironmentVariables environmentVariables)
        {
            using (var connection = new SqlConnection(environmentVariables.DedsDatabaseConnectionString))
            {
                var query = "SELECT DISTINCT " +
                                "pem.CommitmentId, " +
                                "pem.PriceEpisodeIdentifier AS PriceEpisodeId, " +
                                "c.AgreedCost AS Price " +
                            "FROM DataLock.PriceEpisodeMatch pem " +
                                "JOIN DataLock.PriceEpisodePeriodMatch pepm ON pem.Ukprn = pepm.Ukprn " +
                                    "AND pem.PriceEpisodeIdentifier = pepm.PriceEpisodeIdentifier " +
                                    "AND pem.LearnRefNumber = pepm.LearnRefNumber " +
                                    "AND pem.AimSeqNumber = pepm.AimSeqNumber " +
                                "JOIN dbo.DasCommitments c ON pepm.CommitmentId = c.CommitmentId " +
                                    "AND pepm.VersionId = c.VersionId " +
                            "WHERE pem.Ukprn = @ukprn";
                return connection.Query<DataLockMatch>(query, new { ukprn }).ToArray();
            }
        }
    }
}