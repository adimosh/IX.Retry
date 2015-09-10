using IX.Retry.StandardPolicies;
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(maximumRetries);
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException16">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        [Obsolete("Use CountBased instead of this, as these methods will be removed in version 1.0.0")]
        public static IRetryPolicy CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
            where TException16 : Exception
        {
            return new CountBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific exception.
        /// </summary>
        /// <typeparam name="TException">The exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException>(int maximumRetries)
            where TException : Exception
        {
            return new CountBasedRetryPolicy<TException>(maximumRetries);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific exception and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException">The exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException));
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2));
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3));
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
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4));
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
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5));
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
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6));
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
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7));
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
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
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
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13), typeof(TException14));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13), typeof(TException14), typeof(TException15));
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
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException16">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(int maximumRetries)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
            where TException16 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16);
        }

        /// <summary>
        /// A count-based, non-linear retry policy that retries on a specific set of exceptions and has a specific back-off policy.
        /// </summary>
        /// <typeparam name="TException1">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException2">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException3">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException4">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException5">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException6">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException7">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException8">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
        /// <typeparam name="TException16">An exception type to capture and retry on.</typeparam>
        /// <param name="maximumRetries">The maximum retry count for this count-based policy.</param>
        /// <param name="backOffPolicy">A back-off policy to apply between attempts. This policy is always time-based.</param>
        /// <returns>A time-based retry policy instance.</returns>
        public static IRetryPolicy CountBased<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(int maximumRetries, BackOffPolicy backOffPolicy)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
            where TException16 : Exception
        {
            return new CountBasedRetryPolicy(maximumRetries, backOffPolicy, typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13), typeof(TException14), typeof(TException15), typeof(TException16));
        }
    }
}