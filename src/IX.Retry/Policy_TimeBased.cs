using System;
using System.Collections.Generic;

namespace IX.Retry
{
    public static partial class Policy
    {
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

        /// <summary>
        /// A time-based, non-linear retry policy that retries on a specific exception.
        /// </summary>
        /// <typeparam name="TException">The exception type to capture and retry on.</typeparam>
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException>(TimeSpan retryFor)
            where TException : Exception
        {
            return new TimeBasedRetryPolicy<TException>(retryFor);
        }

        /// <summary>
        /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2>(retryFor);
        }

        /// <summary>
        /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2, TException3>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2, TException3>(retryFor);
        }

        /// <summary>
        /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2, TException3, TException4>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2, TException3, TException4>(retryFor);
        }

        /// <summary>
        /// A time-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5>(retryFor);
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
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6>(retryFor);
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
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(retryFor);
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
        /// <param name="retryFor">The time span to continue retrying for.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(TimeSpan retryFor)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
        {
            return new TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(retryFor);
        }
    }
}
