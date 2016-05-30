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

        #region Retry by condition
        
        public RetryConditionDelegate RetryUntil { get; private set; }
        
        public RetryOptions Until(RetryConditionDelegate conditionMethod)
        {
            if (conditionMethod == null)
            {
                throw new ArgumentNullException(nameof(conditionMethod));
            }
            
            Type |= RetryType.Until;
            RetryUntil = conditionMethod;
            
            return this;
        }
        
        #endregion
        
        #region Throw aggregate exception on finalizing
        
        public bool ThrowExceptionOnLastRetry { get; private set; }
        
        public RetryOptions ThrowException()
        {
            ThrowExceptionOnLastRetry = true;
            
            return this;
        }
        
        #endregion
        
        #region Exceptions to watch out for
        
        public List<Tuple<Type, Func<Exception, bool>>> RetryOnExceptions { get; } = new List<Tuple<Type, Func<Exception, bool>>>();
        
        public RetryOptions OnException<T>() where T : Exception
        {
            RetryOnExceptions.RemoveAll(p => p.Item1 == typeof(T));
            RetryOnExceptions.Add(new Tuple<Type, Func<Exception, bool>>(typeof(T), p => true));
            
            return this;
        }
        
        public RetryOptions OnException<T>(Func<Exception, bool> testExceptionFunc) where T : Exception
        {
            if (testExceptionFunc == null)
            {
                throw new ArgumentNullException(nameof(testExceptionFunc));
            }
            
            RetryOnExceptions.RemoveAll(p => p.Item1 == typeof(T));
            RetryOnExceptions.Add(new Tuple<Type, Func<Exception, bool>>(typeof(T), testExceptionFunc));
            
            return this;
        }
        
        #endregion

        public WaitType WaitBetweenRetriesType { get; private set; } 
        
        public TimeSpan? WaitForDuration { get; private set; }
        
        #region Wait
        
        public RetryOptions WaitFor(int milliseconds)
        {
            if (milliseconds <= 0)
            {
                throw new ArgumentException(nameof(milliseconds));
            }
            
            WaitBetweenRetriesType = WaitType.For;
            WaitForDuration = TimeSpan.FromMilliseconds(milliseconds);
            
            return this;
        }
        
        public RetryOptions WaitFor(TimeSpan timeSpan)
        {
            if (timeSpan < TimeSpan.Zero)
            {
                throw new ArgumentException(nameof(timeSpan));
            }
            
            WaitBetweenRetriesType = WaitType.For;
            WaitForDuration = timeSpan;
            
            return this;
        }
        
        public RetryWaitDelegate WaitUntilDelegate { get; set; }
        
        public RetryOptions WaitUntil(RetryWaitDelegate waitMethod)
        {
            if (waitMethod == null)
            {
                throw new ArgumentNullException(nameof(waitMethod));
            }
            
            WaitBetweenRetriesType = WaitType.Until;
            WaitUntilDelegate = waitMethod;
            
            return this;
        }
        
        #endregion

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
            
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = times
            };

            return options;
        }
        
        /// <summary>
        /// Retry once.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Once()
        {
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 1
            };

            return options;
        }
        
        /// <summary>
        /// Retry twice.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions Twice()
        {
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 2
            };

            return options;
        }
        
        /// <summary>
        /// Retry three times.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions ThreeTimes()
        {
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 3
            };

            return options;
        }
        
        /// <summary>
        /// Retry five times.
        /// </summary>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions FiveTimes()
        {
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.Times,
                RetryTimes = 5
            };

            return options;
        }

        /// <summary>
        /// Retries for a specific time span.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <param name="timeSpan">How long to retry, as a time span.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions For(TimeSpan timeSpan)
        {
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.For,
                RetryFor = timeSpan
            };

            return options;
        }

        /// <summary>
        /// Retries for a specific number of milliseconds.
        /// </summary>
        /// <param name="options">Retry options to configure.</param>
        /// <param name="milliseconds">How long to retry, in milliseconds.</param>
        /// <returns>The configured retry options.</returns>
        public static RetryOptions For(int milliseconds)
        {
            RetryOptions options = new RetryOptions()
            {
                Type = RetryType.For,
                RetryFor = TimeSpan.FromMilliseconds(milliseconds)
            };

            return options;
        }
    }
}