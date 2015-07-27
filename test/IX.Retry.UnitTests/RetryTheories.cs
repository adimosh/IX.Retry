using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IX.Retry.UnitTests
{
    public class RetryTheories
    {
        [Theory]
        [MemberData(nameof(RetryTheoryDataGenerator))]
        public void SimpleRetryTheory(int maxRetries, object[] parameters, Type[] exceptionTypes)
        {
            RetryTestMethodWrapper wrapper = new RetryTestMethodWrapper(maxRetries);

            MethodInfo mi;

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

            mi.Invoke(null, )
            Action x = RetryTestMethod<InvalidOperationException>;
            x.WithRetry(Policy.TimeBasedRetryPolicy<InvalidOperationException>(TimeSpan.FromSeconds(1)));
        }

        public static IEnumerable<object[]> RetryTheoryDataGenerator()
        {
            List<object[]> ret = new List<object[]>();



            return ret;
        }
    }
}
