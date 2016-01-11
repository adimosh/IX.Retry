using IX.Retry.BackoffPolicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IX.Retry
{
    internal class RetrySessionContainer : IRetrySessionContainer
    {
        private BackOffPolicy backOffPolicy;

        private RetryPolicy retryPolicy;

        public IRetrySessionContainer WithBackoffPolicy(BackOffPolicy backoffPolicy)
        {
            backOffPolicy = backoffPolicy;
            return this;
        }

        public IRetrySessionContainer WithRetryPolicy(RetryPolicy retryPolicy)
        {
            this.retryPolicy = retryPolicy;
            return this;
        }
    }
}
