using System;
using System.Collections.Generic;

namespace IX.Retry
{
    public static partial class Policy
    {
        /// <summary>
        /// A count-based, non-linear retry policy.
        /// </summary>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="retryForExceptionTypes">Retry for certain exception types.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy(int maximumRetries, IEnumerable<Type> retryForExceptionTypes)
        {
            return new CountBasedRetryPolicy(maximumRetries, retryForExceptionTypes);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific exception.
        /// </summary>
        /// <typeparam name="TException">The exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException>(int maximumRetries)
            where TException : Exception
        {
            return new CountBasedRetryPolicy<TException>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(maximumRetries);
        }
    }
}
