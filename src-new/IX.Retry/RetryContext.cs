using System;
using System.Collections.Generic;
using System.Linq;

namespace IX.Retry
{
    internal class RetryContext : IDisposable
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
            if (disposedValue)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
            
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

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                options = null;
                actionToRetry = null;

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~RetryContext() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}