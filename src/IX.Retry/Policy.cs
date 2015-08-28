using System;

namespace IX.Retry
{
    /// <summary>
    /// Various retry policies for use with IX.Retry.
    /// </summary>
    public static partial class Policy
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
    }
}