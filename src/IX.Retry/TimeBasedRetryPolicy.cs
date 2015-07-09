using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IX.Retry
{
    /// <summary>
    /// A time-based, non-linear retry policy.
    /// </summary>
    public class TimeBasedRetryPolicy : IRetryPolicy
    {
        private readonly TimeSpan retryDuration;
        private readonly IEnumerable<Type> retryForExceptionTypes;
        private DateTime start;

        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration"></param>
        /// <param name="retryForExceptionTypes"></param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration, IEnumerable<Type> retryForExceptionTypes)
        {
            this.retryDuration = retryDuration;
            this.retryForExceptionTypes = retryForExceptionTypes;
        }

        /// <summary>
        /// The retry policy to be executed.
        /// </summary>
        public RetryPolicy ExecutePolicy
        {
            get
            {
                start = DateTime.UtcNow;
                return () => Retry;
            }
        }

        private bool DontRetry(out TimeSpan retryInterval)
        {
            retryInterval = TimeSpan.Zero;
            return false;
        }

        private bool Retry(int retryCount, Exception exception, out TimeSpan retryInterval)
        {
            if (retryDuration < DateTime.UtcNow.Subtract(start))
            {
                return DontRetry(out retryInterval);
            }

            bool found = retryForExceptionTypes.Any(type => exception.GetType() == type);

            if (!found)
            {
                return DontRetry(out retryInterval);
            }

            retryInterval = StandardBackoffPolicies.RandomExponential(retryCount, Policy.MinBackoff, Policy.MaxBackoff, Policy.BackoffIncrement);
            return true;
        }
    }
}
