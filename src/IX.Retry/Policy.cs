using System;
using System.Collections.Generic;
using System.Linq;

namespace IX.Retry
{
    /// <summary>
    /// Various retry policies for use with IX.Retry.
    /// </summary>
    public static class Policy
    {
        /// <summary>
        /// The minimal back-off time between time-based retries.
        /// </summary>
        public static readonly TimeSpan MinBackoff = TimeSpan.FromSeconds(0.5);

        /// <summary>
        /// The maximal back-off time between time-based retries.
        /// </summary>
        public static readonly TimeSpan MaxBackoff = TimeSpan.FromSeconds(15);

        /// <summary>
        /// The increment used to jump between time-based retries.
        /// </summary>
        public static readonly TimeSpan BackoffIncrement = TimeSpan.FromSeconds(1);

        /// <summary>
        /// A time-based, non-linear retry policy.
        /// </summary>
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <param name="retryForExceptionTypes">Retry for certain exception types.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy(TimeSpan retryFor, IEnumerable<Type> retryForExceptionTypes)
        {
            return new TimeBasedRetryPolicy(retryFor, retryForExceptionTypes);
        }
    }
}