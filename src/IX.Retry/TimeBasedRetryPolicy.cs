using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        /// <param name="retryForExceptionTypes">A collection of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
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

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific exception.
    /// </summary>
    /// <typeparam name="TException">The exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException> : TimeBasedRetryPolicy
        where TException : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException) })
        { }
    }

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2) })
        { }
    }

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3) })
        { }
    }
}