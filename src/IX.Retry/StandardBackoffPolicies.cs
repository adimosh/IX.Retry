using System;
using System.Diagnostics;

namespace IX.Retry
{
    public static class StandardBackoffPolicies
    {
        public static TimeSpan Exponential(int retryCount, TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff)
        {
            BackoffPoliciesContractsRequires(retryCount, minBackoff, maxBackoff, deltaBackoff);

            double increment = (Math.Pow(2, retryCount) - 1) * deltaBackoff.TotalMilliseconds;
            var timeToSleepMsec = (int)Math.Min(minBackoff.TotalMilliseconds + increment, maxBackoff.TotalMilliseconds);

            TimeSpan retryInterval = TimeSpan.FromMilliseconds(timeToSleepMsec);
            return retryInterval;
        }

        public static TimeSpan RandomExponential(int retryCount, TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff)
        {
            BackoffPoliciesContractsRequires(retryCount, minBackoff, maxBackoff, deltaBackoff);

            var r = new Random(Guid.NewGuid().GetHashCode());

            double increment = (Math.Pow(2, retryCount) - 1) * r.Next(
                (int)(deltaBackoff.TotalMilliseconds * 0.8),
                (int)(deltaBackoff.TotalMilliseconds * 1.2));
            var timeToSleepMsec = (int)Math.Min(minBackoff.TotalMilliseconds + increment, maxBackoff.TotalMilliseconds);

            TimeSpan retryInterval = TimeSpan.FromMilliseconds(timeToSleepMsec);
            return retryInterval;
        }

        public static TimeSpan Linear(int retryCount, TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff)
        {
            BackoffPoliciesContractsRequires(retryCount, minBackoff, maxBackoff, deltaBackoff);

            double increment = retryCount * deltaBackoff.TotalMilliseconds;
            var timeToSleepMsec = (int)Math.Min(minBackoff.TotalMilliseconds + increment, maxBackoff.TotalMilliseconds);

            TimeSpan retryInterval = TimeSpan.FromMilliseconds(timeToSleepMsec);
            return retryInterval;
        }

        [Conditional("DEBUG")]
        private static void BackoffPoliciesContractsRequires(int retryCount, TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff)
        {
            if (retryCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(retryCount));
            }
            if (minBackoff < TimeSpan.Zero || minBackoff > TimeSpan.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(minBackoff));
            }
            if (maxBackoff < TimeSpan.Zero || maxBackoff > TimeSpan.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(maxBackoff));
            }
            if (deltaBackoff < TimeSpan.Zero || deltaBackoff > TimeSpan.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(deltaBackoff));
            }
        }
    }
}