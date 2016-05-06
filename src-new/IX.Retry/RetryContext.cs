using System;
using System.Collections.Generic;
using System.Linq;

namespace IX.Retry
{
    internal class RetryContext
    {
        private RetryOptions options;
        private Action actionToRetry;
        
        public RetryContext(RetryOptions options, Action actionToRetry)
        {
            this.options = options;
            this.actionToRetry = actionToRetry;
        }
        
        public void BeginRetryProcess()
        {
            DateTime now = DateTime.UtcNow;
            int retries = 0;
            List<Exception> exceptions = new List<Exception>();
            bool shouldRetry = true;
            
            do
            {
                try
                {
                    actionToRetry();
                }
                catch (Exception ex)
                {
                    if (options.RetryOnExceptions.Count > 0 &&
                        !options.RetryOnExceptions.Any(p => p.Item1 == ex.GetType() && p.Item2(ex)))
                    {
                        throw;
                    }
                    
                    exceptions.Add(ex);

                    if (options.Type.HasFlag(RetryType.Times) && retries > options.RetryTimes)
                    {
                        shouldRetry = false;
                    }
                    
                    if (shouldRetry && options.Type.HasFlag(RetryType.For) && (DateTime.UtcNow - now) > options.RetryFor)
                    {
                        shouldRetry = false;
                    }
                    
                    if (shouldRetry && options.Type.HasFlag(RetryType.Until) && options.RetryUntil(retries, now, exceptions, options))
                    {
                        shouldRetry = false;
                    }
                    
                    retries++;
                }
            } while (shouldRetry);

            if (!shouldRetry && options.ThrowExceptionOnLastRetry)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}