using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using IX.Retry;
using Xunit;

public class RetryTests
{
    [Theory]
    [MemberData("FailureTestData")]
    public void Failure(RetryOptions options, List<Exception> exceptions, Func<ReadOnlyCollection<Exception>, bool> exceptionEvaluator)
    {
        // Arrange
        int times = 0;
        Action act = () => TestableMethodContainer.AlwaysFails(exceptions, ref times);
        
        options.ThrowException();
        
        ReadOnlyCollection<Exception> exes = null;
        
        // Act
        try
        {
            Retry.Now(act, options);
        }
        catch (AggregateException ex)
        {
            exes = ex.InnerExceptions;
        }
        
        if (exes == null)
            exes = new ReadOnlyCollection<Exception>(new Exception[0]);

        // Assert
        Assert.True(exceptionEvaluator(exes));
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
                },
                new Func<ReadOnlyCollection<Exception>, bool>(
                    (ReadOnlyCollection<Exception> exes) =>
                        exes.Count == 1 && exes[0].GetType() == typeof(InvalidOperationException)
                    )
            },
            new object[]{
                Retry.Twice(),
                new List<Exception>
                {
                    new InvalidOperationException(),
                    new FormatException()
                },
                new Func<ReadOnlyCollection<Exception>, bool>(
                    (ReadOnlyCollection<Exception> exes) =>
                        exes.Count == 2 && exes[0].GetType() == typeof(InvalidOperationException)
                        && exes[1].GetType() == typeof(FormatException)
                    )
            },
            new object[]{
                Retry.ThreeTimes(),
                new List<Exception>
                {
                    new InvalidOperationException(),
                    new FormatException()
                },
                new Func<ReadOnlyCollection<Exception>, bool>(
                    (ReadOnlyCollection<Exception> exes) =>
                        exes.Count == 3 && exes[0].GetType() == typeof(InvalidOperationException)
                        && exes[1].GetType() == typeof(FormatException)
                        && exes[2].GetType() == typeof(InvalidOperationException)
                    )
            }

        };
    }
}