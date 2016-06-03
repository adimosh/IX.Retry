using System;
using System.Collections.Generic;

namespace IX.Retry
{
    /// <summary>
    /// Options for the retrying process.
    /// </summary>
    public class RetryOptions
    {
        /// <summary>
        /// The type of the retrying operation.
        /// </summary>
        /// <returns>What type of retry porocedure to use.</returns>
        public RetryType Type { get; internal set; }
        
        /// <summary>
        /// How many times to retry.
        /// </summary>
        /// <returns>The number of times to attempt retrying.</returns>
        public int RetryTimes { get; internal set; }
        
        /// <summary>
        /// For how long to retry.
        /// </summary>
        /// <returns>The maxiumum time span to retry.</returns>
        public TimeSpan RetryFor { get; internal set; }

        /// <summary>
        /// The condition method to use when evaluating whether to retry or not.
        /// </summary>
        /// <returns>A delegate that can be invoked.</returns>
        public RetryConditionDelegate RetryUntil { get; internal set; }
        
        /// <summary>
        /// Whether or not to throw an exception at the end of the retrying process, if it is unsuccessful.
        /// </summary>
        /// <returns><c>true</c> if an exception should be thrown, <c>false</c> otherwise.</returns>
        public bool ThrowExceptionOnLastRetry { get; internal set; }

        /// <summary>
        /// A list of exceptions and optional conditional methods that will be evaluated when deciding whether or not to retry.
        /// </summary>
        /// <returns>A list of exception/delegate tuples.</returns>
        public List<Tuple<Type, Func<Exception, bool>>> RetryOnExceptions { get; } = new List<Tuple<Type, Func<Exception, bool>>>();

        /// <summary>
        /// The type of waiting to do between retries. By default, no waiting between retries is performed.
        /// </summary>
        /// <returns>The type of waiting.</returns>
        public WaitType WaitBetweenRetriesType { get; internal set; } 
        
        /// <summary>
        /// The duration of time to use as a waiting duration between retries, if enabled.
        /// </summary>
        /// <returns>The waiting duration.</returns>
        public TimeSpan? WaitForDuration { get; internal set; }
        
        /// <summary>
        /// A delegate to define for how long do we need to wait between retries.
        /// </summary>
        /// <returns>A time span to wait for.</returns>
        public RetryWaitDelegate WaitUntilDelegate { get; set; }

        /// <summary>
        /// Retry for a number of times.
        /// </summary>
        /// <param name="times">The number of times to retry. Has to be greater than 0.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Times(int times)
        {
            if (times <= 0)
            {
                throw new ArgumentException(nameof(times));
            }
            
            return new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = times
            };
        }
        
        /// <summary>
        /// Retry once.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Once()
        {
            return new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 1
            };
        }
        
        /// <summary>
        /// Retry twice.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Twice()
        {
            return new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 2
            };
        }
        
        /// <summary>
        /// Retry three times.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions ThreeTimes()
        {
            return new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 3
            };
        }
        
        /// <summary>
        /// Retry five times.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions FiveTimes()
        {
            return new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 5
            };
        }

        /// <summary>
        /// Retries for a specific time span.
        /// </summary>
        /// <param name="timeSpan">How long to retry, as a time span.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions For(TimeSpan timeSpan)
        {
            if (timeSpan < TimeSpan.Zero)
                throw new ArgumentException(nameof(timeSpan));

            return new RetryOptions()
            {
                Type = RetryType.For,
                RetryFor = timeSpan
            };
        }

        /// <summary>
        /// Retries for a specific number of milliseconds.
        /// </summary>
        /// <param name="milliseconds">How long to retry, in milliseconds.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions For(int milliseconds)
        {
            if (milliseconds <= 0)
                throw new ArgumentException(nameof(milliseconds));

            return new RetryOptions()
            {
                Type = RetryType.For,
                RetryFor = TimeSpan.FromMilliseconds(milliseconds)
            };
        }

        /// <summary>
        /// Retries until a specific condition is reached.
        /// </summary>
        /// <param name="conditionMethod">The condition method to evaluate.</param>
        /// <returns>The configured retry options.</returns>
        /// <remarks>
        /// <para>Retrying happens while the <paramref name="conditionMethod" /> method, when executed, returns <c>true</c>.</para>
        /// <para>On first instance that the method return is <c>false</c>, retrying stops.</para>
        /// </remarks>
        public static RetryOptions Until(RetryConditionDelegate conditionMethod)
        {
            if (conditionMethod == null)
            {
                throw new ArgumentNullException(nameof(conditionMethod));
            }
            
            return new RetryOptions()
            {
                Type = RetryType.Until,
                RetryUntil = conditionMethod
            };
        }
        
        /// <summary>
        /// Configures an exception that, when thrown by the code being retried, prompts a retry.
        /// </summary>
        /// <typeparam name="T">The exception type to configure.</typeparam>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions OnException<T>() where T : Exception
        {
            RetryOptions options = new RetryOptions();
            options.RetryOnExceptions.Add(new Tuple<Type, Func<Exception, bool>>(typeof(T), p => true));
            return options;
        }
        
         /// <summary>
        /// Configures an exception that, when thrown by the code being retried, prompts a retry, if the method to test for it allows it.
        /// </summary>
        /// <typeparam name="T">The exception type to configure.</typeparam>
        /// <param name="testExceptionFunc">The method to test the exceptions with.</param>
        /// <returns>The configured retry options.</returns>
       public static RetryOptions OnException<T>(Func<Exception, bool> testExceptionFunc) where T : Exception
        {
            if (testExceptionFunc == null)
            {
                throw new ArgumentNullException(nameof(testExceptionFunc));
            }
            
            RetryOptions options = new RetryOptions();
            options.RetryOnExceptions.Add(new Tuple<Type, Func<Exception, bool>>(typeof(T), testExceptionFunc));
            return options;
        }
        
        /// <summary>
        /// Configures retry options to throw an exception at the end of the retrying process, if it was unsuccessful.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions ThrowException()
        {
            return new RetryOptions()
            {
                ThrowExceptionOnLastRetry = true
            };
        }
        
        /// <summary>
        /// Waiting time between retries.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds to wait for.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions WaitFor(int milliseconds)
        {
            if (milliseconds <= 0)
            {
                throw new ArgumentException(nameof(milliseconds));
            }
            
            return new RetryOptions()
            {
                WaitBetweenRetriesType = WaitType.For,
                WaitForDuration = TimeSpan.FromMilliseconds(milliseconds)
            };
        }
        
        /// <summary>
        /// Waiting time between retries.
        /// </summary>
        /// <param name="timeSpan">The time span to wait between retries.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions WaitFor(TimeSpan timeSpan)
        {
            if (timeSpan < TimeSpan.Zero)
            {
                throw new ArgumentException(nameof(timeSpan));
            }
            
            return new RetryOptions()
            {
                WaitBetweenRetriesType = WaitType.For,
                WaitForDuration = timeSpan
            };
        }

        /// <summary>
        /// Waits a time span that is configured by a given delegate.
        /// </summary>
        /// <param name="waitMethod">The waiting delegate to give the time span.</param>
        /// <returns>The configured retry options.</returns>
        public RetryOptions WaitUntil(RetryWaitDelegate waitMethod)
        {
            if (waitMethod == null)
                throw new ArgumentNullException(nameof(waitMethod));
            
            return new RetryOptions()
            {
                WaitBetweenRetriesType = WaitType.Until,
                WaitUntilDelegate = waitMethod
            };
        }
    }
}