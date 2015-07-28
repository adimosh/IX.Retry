using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IX.Retry.UnitTests
{
    public class RetryTheories
    {
        [Theory]
        [MemberData(nameof(RetryTheoryDataGenerator))]
        public void SimpleRetryTheory(int maxRetries, int[] parameters, Type[] exceptionTypes)
        {
            // ARRANGE
            // =======
            
            // Initialize wrapper
            RetryTestMethodWrapper wrapper = new RetryTestMethodWrapper(maxRetries);

            MethodInfo mi;

            // Get proper "With.Retry" method
            MethodInfo[] mis = typeof(With).GetMethods(BindingFlags.Static | BindingFlags.Public);

            Type[] parameterTypes = parameters.Aggregate(new List<Type>(), (list, current) => { list.Add(current.GetType()); return list; }).ToArray();

            MethodInfo mig = mis.Single(p =>
                p.IsGenericMethodDefinition &&
                p.ContainsGenericParameters &&
                p.Name == nameof(With.Retry) &&
                p.GetGenericArguments().Length == parameterTypes.Length &&
                p.GetParameters()[0].MultiVerify(
                    q => q.Name == "action",
                    q => q.ParameterType.GetGenericTypeDefinition().GetGenericArguments().Length == parameterTypes.Length));

            mi = mig.MakeGenericMethod(parameterTypes);

            // Get test method
            Delegate testMethodDelegate = wrapper.GetProperTestActionDelegate(exceptionTypes, parameterTypes);

            // Create method parameters
            IRetryPolicy retryPolicy = Policy.TimeBasedRetryPolicy(TimeSpan.FromSeconds(1), exceptionTypes);
            CancellationToken cancellationToken = default(CancellationToken);

            List<object> invokeParameters = new List<object>();
            invokeParameters.Add(testMethodDelegate);
            invokeParameters.Add(retryPolicy);
            invokeParameters.AddRange(parameters.Cast<object>());
            invokeParameters.Add(cancellationToken);

            // ACT
            // ===

            var result = mi.Invoke(null, invokeParameters.ToArray());

            // ASSERT
            // ======

            Assert.Null(result);
        }

        public static IEnumerable<object[]> RetryTheoryDataGenerator()
        {
            List<object[]> ret = new List<object[]>();
            Random r = new Random();

            ret.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { typeof(NotImplementedException) }
                });
            ret.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { typeof(NotImplementedException) }
                });
            ret.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { typeof(NotImplementedException) }
                });
            ret.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { typeof(NotImplementedException) }
                });

            return ret;
        }
    }
}