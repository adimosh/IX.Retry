using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IX.Retry.UnitTests
{
    internal partial class RetryTestMethodWrapper
    {
        internal RetryTestMethodWrapper(int maxRetries)
        {
            this.maxRetries = maxRetries;
            currentRetry = 0;
            hasRetriedCorrectly = false;
            r = new Random();
        }

        private int maxRetries;
        private int currentRetry;
        private bool hasRetriedCorrectly;
        Random r;

        private void RetryTestMethod(IEnumerable<Type> exceptions)
        {
            if (maxRetries > currentRetry)
            {
                currentRetry++;
                Exception ex = Activator.CreateInstance(exceptions.Skip(r.Next(exceptions.Count())).First()) as Exception;
                throw ex;
            }
            else if (hasRetriedCorrectly)
            {
                Assert.Fail("Another retry should not be performed should the method execute successfully!");
            }

            hasRetriedCorrectly = true;
        }

        private Task RetryTestAsyncMethod(IEnumerable<Type> exceptions)
        {
            if (maxRetries > currentRetry)
            {
                currentRetry++;
                Exception ex = Activator.CreateInstance(exceptions.Skip(r.Next(exceptions.Count())).First()) as Exception;
                throw ex;
            }
            else if (hasRetriedCorrectly)
            {
                Assert.Fail("Another retry should not be performed should the method execute successfully!");
            }

            hasRetriedCorrectly = true;

            return Task.FromResult(0);
        }

        internal Delegate GetProperTestActionDelegate(string testKey, IEnumerable<Type> exceptions, IEnumerable<Type> parameters)
        {
            Tuple<MethodInfo, Type> mi;
            if (delegateInformation.TryGetValue(new Tuple<string, int, int>(testKey, exceptions.Count(), parameters.Count()), out mi))
            {
                return mi.Item1.MakeGenericMethod(exceptions.ToArray()).CreateDelegate(mi.Item2, this);
            }
            else throw new InvalidOperationException("Test method delegate not found.");
        }

        private static Dictionary<Tuple<string, int, int>, Tuple<MethodInfo, Type>> delegateInformation = new Dictionary<Tuple<string, int, int>, Tuple<MethodInfo, Type>>();

        static RetryTestMethodWrapper()
        {
            RetryTestActionMethodMethodGenerator();
            RetryTestFuncWithTaskMethodGenerator();
        }
    }
}