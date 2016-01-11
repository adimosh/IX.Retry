using System;

namespace IX.Retry.RetryPolicies
{
    /// <summary>
    /// A delegate invoked into retry cycles to determine whether there should be a retry, and how to retry.
    /// </summary>
    /// <param name="retryCount">The maximum number of retries.</param>
    /// <param name="exception">The exception for which a retry is asked for.</param>
    /// <param name="delay">The delay, if time-based.</param>
    /// <returns><c>true</c> if there should be a retry, <c>false</c> otherwise.</returns>
    public delegate bool ShouldRetry(int retryCount, Exception exception, out TimeSpan delay);

    /// <summary>
    /// A delegate returning a <see cref="ShouldRetry"/> delegate, used for creating retry methods.
    /// </summary>
    /// <returns>A <see cref="ShouldRetry"/> delegate.</returns>
    public delegate ShouldRetry RetryPolicy();
}
