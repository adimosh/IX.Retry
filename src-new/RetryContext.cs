using System;

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
            bool shouldRetry = false;
            
            do
            {
                try
                {
                    actionToRetry();
                }
                catch (Exception ex)
                {
                    if (options.Type.HasFlag(RetryType.Times) && retries > options.RetryTimes)
                    {
                        if (options.ThrowExceptionOnLastRetry)
                        {
                            throw;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    // Check other conditions here
                    
                    retries++;
                }
            } while (true);
        }
    }
}