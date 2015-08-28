using System;
using System.Linq;
using Xunit;

namespace IX.Retry.UnitTests
{
    public class RetryFacts_Miscellaneous_MultipleExceptions
    {
        int retries;
        int maxRetries = 10;

        private Random r = new Random();
        private Exception[] exc = new Exception[]
        {
            new InvalidOperationException(),
            new InvalidCastException(),
            new ArgumentNullException(),
            new ArgumentException(),
            new ArithmeticException(),
            new ArgumentOutOfRangeException(),
            new FormatException(),
            new IndexOutOfRangeException(),
            new InvalidTimeZoneException()
        };

        [Fact]
        public void Test()
        {
            With.Retry(DelegateMethod_Action_MultiException, Policy.CountBasedRetryPolicy(maxRetries, exc.Select(p => p.GetType())));
        }

        private void DelegateMethod_Action_MultiException()
        {
            if (retries < maxRetries)
            {
                retries++;
                throw exc[r.Next(0, 9)];
            }
        }

    }
}