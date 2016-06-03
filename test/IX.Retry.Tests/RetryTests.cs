using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using IX.Retry;
using Xunit;
using Xunit.Abstractions;

public class RetryTests
{
    private readonly ITestOutputHelper output;
    
    public RetryTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    [Theory]
    [MemberData("FailureTestData")]
    public void Failure(RetryOptions options, List<Exception> exceptions, Func<ReadOnlyCollection<Exception>, bool> exceptionEvaluator)
    {
        output.WriteLine("Beginning test run...");
        
        // Arrange
        int times = 0;
        Action act = () => TestableMethodContainer.AlwaysFails(exceptions, ref times);
        
        options.ThrowException();
        
        ReadOnlyCollection<Exception> exes = null;
        
        bool hasThrown = true;
        
        // Act
        try
        {
            Retry.Now(act, options);

            output.WriteLine("Retrying has completed successfully, even though an exception was expected.");
            
            hasThrown = false;
        }
        catch (AggregateException ex)
        {
            output.WriteLine("AggregateException has been caught.");
            
            if (ex.InnerExceptions != null && ex.InnerExceptions.Count == 1)
            {
                Exception exe = ex.InnerExceptions[0];
                if (exe is AggregateException)
                    ex = exe as AggregateException;
            }
            
            output.WriteLine("Inner exceptions: {0}.", ex.InnerExceptions.Count);
            output.WriteLine(string.Join(", ", ex.InnerExceptions.Select(p => p.GetType().Name)));
            exes = ex.InnerExceptions;
        }
        catch (Exception ex)
        {
            output.WriteLine("Exception has been caught: {0}, with message {1}.", ex.GetType(), ex.Message);
            throw;
        }
        
        if (exes == null)
            exes = new ReadOnlyCollection<Exception>(new Exception[0]);

        // Assert
        Assert.True(hasThrown);
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
                        exes.Count == 1 && exes[0] is InvalidOperationException
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
                        exes.Count == 2 && exes[0] is InvalidOperationException
                        && exes[1] is FormatException
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