using System;
using System.Collections.Generic;
using System.Linq;

namespace IX.Retry.StandardPolicies
{
    /// <summary>
    /// A time-based, non-linear retry policy.
    /// </summary>
    public class TimeBasedRetryPolicy : IRetryPolicy
    {
        private readonly TimeSpan retryDuration;
        private readonly IEnumerable<Type> retryForExceptionTypes;
        private DateTime start;
        private readonly BackOffPolicy backOffPolicy;

        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        /// <param name="retryForExceptionTypes">A collection of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public TimeBasedRetryPolicy(TimeSpan retryDuration, IEnumerable<Type> retryForExceptionTypes)
            : this(retryDuration, StandardBackoffPolicies.RandomExponential, retryForExceptionTypes)
        {
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        /// <param name="retryForExceptionTypes">An array of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public TimeBasedRetryPolicy(TimeSpan retryDuration, params Type[] retryForExceptionTypes)
            : this(retryDuration, StandardBackoffPolicies.RandomExponential, retryForExceptionTypes)
        {
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        /// <param name="backOffPolicy">The back-off policy to use.</param>
        /// <param name="retryForExceptionTypes">A collection of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public TimeBasedRetryPolicy(TimeSpan retryDuration, BackOffPolicy backOffPolicy, IEnumerable<Type> retryForExceptionTypes)
        {
            this.retryDuration = retryDuration;
            this.retryForExceptionTypes = retryForExceptionTypes;
            this.backOffPolicy = backOffPolicy;
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        /// <param name="backOffPolicy">The back-off policy to use.</param>
        /// <param name="retryForExceptionTypes">An array of exception types for which to retry.</param>
        /// <remarks>
        /// <para>The exception types are not checked, meaning that if a collection of types that are not exceptions is given as parameter, then the retry mechanism will do nothing.</para>
        /// </remarks>
        public TimeBasedRetryPolicy(TimeSpan retryDuration, BackOffPolicy backOffPolicy, params Type[] retryForExceptionTypes)
            : this(retryDuration, backOffPolicy, retryForExceptionTypes as IEnumerable<Type>)
        {
        }

        /// <summary>
        /// The retry policy to be executed.
        /// </summary>
        public RetryPolicy ExecuteRetryPolicy
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

            retryInterval = backOffPolicy(retryCount, Policy.MinBackoff, Policy.MaxBackoff, Policy.BackoffIncrement);
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

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        where TException4 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) })
        { }
    }

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        where TException4 : Exception
        where TException5 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) })
        { }
    }

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        where TException4 : Exception
        where TException5 : Exception
        where TException6 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) })
        { }
    }

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        where TException4 : Exception
        where TException5 : Exception
        where TException6 : Exception
        where TException7 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) })
        { }
    }

    /// <summary>
    /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
    /// </summary>
    /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8> : TimeBasedRetryPolicy
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        where TException4 : Exception
        where TException5 : Exception
        where TException6 : Exception
        where TException7 : Exception
        where TException8 : Exception
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) })
        { }
    }
}