using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IX.Retry.UnitTests
{
    public partial class RetryTheories
    {
        [Theory]
        [MemberData(nameof(RetryTheoryDataGenerator))]
        public void ActionRetryTheory(int maxRetries, int[] parameters, Type[] exceptionTypes)
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
                p.Name == nameof(With.Retry) &&
                (
                    (parameterTypes.Length == 0 && !p.ContainsGenericParameters) ||
                    (p.IsGenericMethodDefinition &&
                    p.ContainsGenericParameters &&
                    p.GetGenericArguments().Length == parameterTypes.Length &&
                    p.GetParameters()[0].MultiVerify(
                        q => q.Name == "action",
                        q => q.ParameterType.GetGenericTypeDefinition().GetGenericArguments().Length == parameterTypes.Length))
                ));

            mi = mig.IsGenericMethodDefinition ? mig.MakeGenericMethod(parameterTypes) : mig;

            // Get test method
            Delegate testMethodDelegate = wrapper.GetProperTestActionDelegate("action", exceptionTypes, parameterTypes);

            // Create method parameters
            IRetryPolicy retryPolicy = Policy.TimeBasedRetryPolicy(TimeSpan.FromSeconds(maxRetries), exceptionTypes);
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

        [Theory]
        [MemberData(nameof(RetryTheoryDataGenerator))]
        public void FuncTaskRetryTheory(int maxRetries, int[] parameters, Type[] exceptionTypes)
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
                p.Name == nameof(With.Retry) &&
                (
                    (parameterTypes.Length == 0 && !p.ContainsGenericParameters && typeof(Task) == p.ReturnType) ||
                    (p.IsGenericMethodDefinition &&
                    p.ContainsGenericParameters &&
                    p.GetGenericArguments().Length == parameterTypes.Length &&
                    p.GetParameters()[0].MultiVerify(
                        q => q.Name == "func",
                        q => q.ParameterType.GetGenericTypeDefinition().GetGenericArguments().Length == parameterTypes.Length) &&
                    typeof(Task) == p.ReturnType)
                ));

            mi = mig.IsGenericMethodDefinition ? mig.MakeGenericMethod(parameterTypes) : mig;

            // Get test method
            Delegate testMethodDelegate = wrapper.GetProperTestActionDelegate("functask", exceptionTypes, parameterTypes);

            // Create method parameters
            IRetryPolicy retryPolicy = Policy.TimeBasedRetryPolicy(TimeSpan.FromSeconds(maxRetries), exceptionTypes);
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
            Random r = new Random();
            List<Type> exceptionTypes = new List<Type>
            {
                typeof(NotImplementedException),
                typeof(OutOfMemoryException),
                typeof(ArgumentException),
                typeof(ArgumentNullException),
                typeof(ArgumentOutOfRangeException),
                typeof(ArithmeticException),
                typeof(DivideByZeroException),
                typeof(ArrayTypeMismatchException)
            };

            List<object[]> ret = new List<object[]>();

            GenerateTestData(ret, r, exceptionTypes);

            return ret;
        }

        static partial void GenerateTestData(List<object[]> objects, Random r, List<Type> exceptionTypes);
    }
}