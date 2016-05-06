using System;
using System.Collections.Generic;

namespace IX.Retry
{
    public class RetryOptions
    {
        public RetryType Type { get; private set; }
        
        #region Retry by number
        
        public int RetryTimes { get; private set; }
        
        public RetryOptions Times(int times)
        {
            if (times <= 0)
            {
                throw new ArgumentException(nameof(times));
            }
            
            Type |= RetryType.Times;
            RetryTimes = times;

            return this;
        }
        
        public RetryOptions Once()
        {
            Type |= RetryType.Times;
            RetryTimes = 1;

            return this;
        }
        
        public RetryOptions Twice()
        {
            Type |= RetryType.Times;
            RetryTimes = 2;

            return this;
        }
        
        public RetryOptions ThreeTimes()
        {
            Type |= RetryType.Times;
            RetryTimes = 3;

            return this;
        }
        
        public RetryOptions FiveTimes()
        {
            Type |= RetryType.Times;
            RetryTimes = 5;

            return this;
        }
        
        #endregion
        
        #region Retry by timeSpan
        
        public TimeSpan RetryFor { get; private set; }
        
        public RetryOptions For(TimeSpan timeSpan)
        {
            Type |= RetryType.For;
            RetryFor = timeSpan;

            return this;
        }
        
        public RetryOptions For(int milliseconds)
        {
            Type |= RetryType.For;
            RetryFor = TimeSpan.FromMilliseconds(milliseconds);

            return this;
        }
        
        #endregion
        
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
    }
}