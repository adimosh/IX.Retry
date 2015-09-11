using System;
using System.Collections.Generic;
using System.Linq;

namespace IX.Retry.StandardPolicies
{
    /// <summary>
    /// A time-based, non-linear retry policy.
    /// </summary>
    public class CountBasedRetryPolicy : IRetryPolicy
    {
        private readonly int maximumRetries;
        private readonly IEnumerable<Type> retryForExceptionTypes;
        private readonly BackOffPolicy backOffPolicy;

        /// <summary>
        /// Instantiates a new instance of the <see cref="CountBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="retryForExceptionTypes">A collection of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public CountBasedRetryPolicy(int maximumRetries, IEnumerable<Type> retryForExceptionTypes)
            : this(maximumRetries, StandardBackoffPolicies.RandomExponential, retryForExceptionTypes)
        {
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="CountBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="retryForExceptionTypes">An array of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public CountBasedRetryPolicy(int maximumRetries, params Type[] retryForExceptionTypes)
            : this(maximumRetries, StandardBackoffPolicies.RandomExponential, retryForExceptionTypes)
        {
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="CountBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">The back-off policy to use.</param>
        /// <param name="retryForExceptionTypes">A collection of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public CountBasedRetryPolicy(int maximumRetries, BackOffPolicy backOffPolicy, IEnumerable<Type> retryForExceptionTypes)
        {
            this.maximumRetries = maximumRetries;
            this.retryForExceptionTypes = retryForExceptionTypes;
            this.backOffPolicy = backOffPolicy;
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="CountBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">The back-off policy to use.</param>
        /// <param name="retryForExceptionTypes">An array of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public CountBasedRetryPolicy(int maximumRetries, BackOffPolicy backOffPolicy, params Type[] retryForExceptionTypes)
            : this(maximumRetries, backOffPolicy, retryForExceptionTypes as IEnumerable<Type>)
        {
        }

        /// <summary>
        /// The retry policy to be executed.
        /// </summary>
        public RetryPolicy ExecuteRetryPolicy
        {
            get
            {
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
            if (retryCount >= maximumRetries)
            {
                return DontRetry(out retryInterval);
            }

            bool found = retryForExceptionTypes.Any(type => exception.GetType() == type);

            if (!found)
            {
                return DontRetry(out retryInterval);
            }

            retryInterval = backOffPolicy(retryCount, Policy.MinBackoff, Policy.MaxBackoff, Policy.BackoffIncrement);
            return true;
        }
    }
}