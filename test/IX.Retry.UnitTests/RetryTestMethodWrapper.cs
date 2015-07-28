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
                Exception ex = Activator.CreateInstance(exceptions.Skip(r.Next()).First()) as Exception;
                throw ex;
            }
            else if (hasRetriedCorrectly)
            {
                Assert.Fail("Another retry should not be performed should the method execute successfully!");
            }

            hasRetriedCorrectly = true;
        }

        internal Delegate GetProperTestActionDelegate(IEnumerable<Type> exceptions, IEnumerable<Type> parameters)
        {

            Tuple<MethodInfo, Type> mi;
            if (delegateInformation.TryGetValue(new Tuple<int, int>(exceptions.Count(), parameters.Count()), out mi))
            {
                return mi.Item1.MakeGenericMethod(exceptions.ToArray()).CreateDelegate(mi.Item2, this);
            }
            else throw new InvalidOperationException("Test method delegate not found.");
        }

        private static Dictionary<Tuple<int, int>, Tuple<MethodInfo, Type>> delegateInformation = new Dictionary<Tuple<int, int>, Tuple<MethodInfo, Type>>();
    }
}
