using System;

namespace IX.Retry
{
    /// <summary>
    /// Extension methods for the options for the retrying process data object.
    /// </summary>
    public static class RetryOptionsExtensions
    {
        /// <summary>
        /// Retry for a number of times.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <param name="times">The number of times to retry. Has to be greater than 0.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Times(this RetryOptions options, int times)
        {
            if (times <= 0)
            {
                throw new ArgumentException(nameof(times));
            }
            
            options.Type |= RetryType.Times;
            options.RetryTimes = times;

            return options;
        }
        
        /// <summary>
        /// Retry once.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Once(this RetryOptions options)
        {
            options.Type |= RetryType.Times;
            options.RetryTimes = 1;

            return options;
        }
        
        /// <summary>
        /// Retry twice.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Twice(this RetryOptions options)
        {
            options.Type |= RetryType.Times;
            options.RetryTimes = 2;

            return options;
        }
        
        /// <summary>
        /// Retry three times.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions ThreeTimes(this RetryOptions options)
        {
            options.Type |= RetryType.Times;
            options.RetryTimes = 3;

            return options;
        }
        
        /// <summary>
        /// Retry five times.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions FiveTimes(this RetryOptions options)
        {
            options.Type |= RetryType.Times;
            options.RetryTimes = 5;

            return options;
        }
        
        /// <summary>
        /// Retries for a specific time span.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <param name="timeSpan">How long to retry, as a time span.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions For(this RetryOptions options, TimeSpan timeSpan)
        {
            options.Type |= RetryType.For;
            options.RetryFor = timeSpan;

            return options;
        }
        
        /// <summary>
        /// Retries for a specific number of milliseconds.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <param name="milliseconds">How long to retry, in milliseconds.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions For(this RetryOptions options, int milliseconds)
        {
            options.Type |= RetryType.For;
            options.RetryFor = TimeSpan.FromMilliseconds(milliseconds);

            return options;
        }
    }
}