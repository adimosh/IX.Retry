using IX.Retry.BackoffPolicies;
using System;
using System.Threading.Tasks;

namespace IX.Retry
{
    public interface IRetrySessionContainer
    {
        IRetrySessionContainer WithRetryPolicy(RetryPolicy retryPolicy);

        IRetrySessionContainer WithBackoffPolicy(BackOffPolicy backoffPolicy);
    }
}