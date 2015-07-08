using System;

namespace IX.Retry
{
    public delegate bool ShouldRetry(int retryCount, Exception exception, out TimeSpan delay);

    public delegate ShouldRetry RetryPolicy();

    public delegate TimeSpan BackOffPolicy(int retryCount, TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff);
}