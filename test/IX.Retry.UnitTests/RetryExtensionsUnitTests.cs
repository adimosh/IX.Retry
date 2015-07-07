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

        void RetryTestMethod()
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {
            hasRetriedCorrectly = false;
        }

        [TestMethod]
        public void RetryExtensions_DoRetryAsync_SimpleAction_OneRetry()
        {
        }
    }
}
