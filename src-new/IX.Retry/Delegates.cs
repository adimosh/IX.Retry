using System;
using System.Collections.Generic;

namespace IX.Retry
{
    public delegate bool RetryConditionDelegate(int retriedTimes, DateTime retryingSince, IEnumerable<Exception> exceptions, RetryOptions options);
    
    public delegate TimeSpan RetryWaitDelegate(int retriedTimes, DateTime retryingSince, RetryOptions options);
}