
using System;
using System.Collections.Generic;
using System.Linq;

namespace IX.Retry.StandardPolicies
{
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13), typeof(TException14) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13), typeof(TException14), typeof(TException15) })
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
    /// <typeparam name="TException9">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException10">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException11">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException12">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException13">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException14">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException15">An exception type to capture and retry on.</typeparam>
    /// <typeparam name="TException16">An exception type to capture and retry on.</typeparam>
    public class TimeBasedRetryPolicy<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16> : TimeBasedRetryPolicy
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
        /// <summary>
        /// Instantiates a new instance of the <see cref="TimeBasedRetryPolicy"/> class.
        /// </summary>
        /// <param name="retryDuration">The retry duration for this time-based policy.</param>
        public TimeBasedRetryPolicy(TimeSpan retryDuration)
            : base(retryDuration, new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8), typeof(TException9), typeof(TException10), typeof(TException11), typeof(TException12), typeof(TException13), typeof(TException14), typeof(TException15), typeof(TException16) })
        { }
    }
}
