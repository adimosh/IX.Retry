﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IX.Retry
{
    public static class Policy
    {
        public static readonly TimeSpan MinBackoff = TimeSpan.FromSeconds(0.5);
        public static readonly TimeSpan MaxBackoff = TimeSpan.FromSeconds(15);
        public static readonly TimeSpan BackoffIncrement = TimeSpan.FromSeconds(1);

        public static RetryPolicy TimeBasedRetryPolicy(TimeSpan retryFor, IEnumerable<Type> retryForExceptionTypes)
        {
            TimeBasedRetry retry = new TimeBasedRetry(retryFor, retryForExceptionTypes);

            return retry.RetryPolicy();
        }

        private class TimeBasedRetry
        {
            private readonly TimeSpan retryDuration;
            private readonly IEnumerable<Type> retryForExceptionTypes;
            private DateTime start;

            public TimeBasedRetry(TimeSpan retryDuration, IEnumerable<Type> retryForExceptionTypes)
            {
                this.retryDuration = retryDuration;
                this.retryForExceptionTypes = retryForExceptionTypes;
            }

            public RetryPolicy RetryPolicy()
            {
                start = DateTime.UtcNow;
                return () => Retry;
            }

            private bool DontRetry(out TimeSpan retryInterval)
            {
                retryInterval = TimeSpan.Zero;
                return false;
            }

            private bool Retry(int retryCount, Exception exception, out TimeSpan retryInterval)
            {
                // we will try as long as we haven't been retrying too long
                if (retryDuration < DateTime.UtcNow.Subtract(start))
                {
                    return DontRetry(out retryInterval);
                }

                // was the failure caused by a retryable exception ?
                bool found = retryForExceptionTypes.Any(type => exception.GetType() == type);

                // no need to retry if the failure was caused by another type of exception
                if (!found)
                {
                    return DontRetry(out retryInterval);
                }

                retryInterval = StandardBackoffPolicies.RandomExponential(retryCount, MinBackoff, MaxBackoff, BackoffIncrement);
                return true; // retry
            }

        }
    }
}