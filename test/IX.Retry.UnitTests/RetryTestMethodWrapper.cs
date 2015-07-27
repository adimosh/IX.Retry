using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IX.Retry.UnitTests
{
    internal class RetryTestMethodWrapper
    {
        internal RetryTestMethodWrapper(int maxRetries)
        {
            this.maxRetries = maxRetries;
            currentRetry = 0;
            hasRetriedCorrectly = false;
        }

        private int maxRetries;
        private int currentRetry;
        private bool hasRetriedCorrectly;

        public void RetryTestMethod<TException>() where TException : Exception, new()
        {
            if (maxRetries > currentRetry)
            {
                currentRetry++;
                throw new TException();
            }
            else if (hasRetriedCorrectly)
            {
                Assert.Fail("Another retry should not be performed should the method execute successfully!");
            }

            hasRetriedCorrectly = true;
        }
    }
}
