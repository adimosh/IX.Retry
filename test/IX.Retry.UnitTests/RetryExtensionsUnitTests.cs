using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IX.Retry.UnitTests
{
    [TestClass]
    public class RetryExtensionsUnitTests
    {
        int maxRetries;
        int currentRetry;
        bool hasRetriedCorrectly;

        void RetryTestMethod<TException>() where TException : Exception, new()
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

        [TestInitialize]
        public void TestInitialize()
        {
            hasRetriedCorrectly = false;
        }

        [TestMethod]
        public void RetryExtensions_DoRetryAsync_SimpleAction_OneRetry()
        {
            maxRetries = 1;
            currentRetry = 0;

            Action x = RetryTestMethod<InvalidOperationException>;
            x.WithRetry(Policy.TimeBasedRetryPolicy(TimeSpan.FromSeconds(1), new[] { typeof(InvalidOperationException) }));
        }

        [TestMethod]
        public void RetryExtensions_DoRetryAsync_SimpleAction_TwoRetries()
        {
            maxRetries = 2;
            currentRetry = 0;

            Action x = RetryTestMethod<InvalidOperationException>;
            x.WithRetry(Policy.TimeBasedRetryPolicy(TimeSpan.FromSeconds(1), new[] { typeof(InvalidOperationException) }));
        }

        [TestMethod]
        public void RetryExtensions_DoRetryAsync_SimpleAction_ThreeRetries()
        {
            maxRetries = 3;
            currentRetry = 0;

            Action x = RetryTestMethod<InvalidOperationException>;
            x.WithRetry(Policy.TimeBasedRetryPolicy(TimeSpan.FromSeconds(1), new[] { typeof(InvalidOperationException) }));
        }
    }
}
