using System;
using System.Collections.Generic;
using IX.Retry;
using Xunit;

public class RetryTests
{
    [Theory]
    [MemberData("FailureTestData")]
    public void Failure(RetryOptions options, List<Exception> exceptions)
    {
        int times = 0;
        Action act = () => TestableMethodContainer.AlwaysFails(exceptions, ref times);
        
        options.ThrowException();
        
        try
        {
            Retry.Now(act, options);
        }
        catch (AggregateException ex)
        {
        }
    }
    
    public static IEnumerable<object[]> FailureTestData()
    {
        return new object[][]
        {
            new object[]{
                Retry.Once(),
                new List<Exception>
                {
                    new InvalidOperationException()
                }
            }
        };
    }
}