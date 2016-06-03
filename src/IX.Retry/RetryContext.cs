using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
        
        public async Task BeginRetryProcessAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            CheckDisposed();
            
            DateTime now = DateTime.UtcNow;
            int retries = 0;
            List<Exception> exceptions = new List<Exception>();
            bool shouldRetry = true;
            
            do
            {
                shouldRetry = RunOnce(exceptions, now, ref retries);
                
                if (shouldRetry && options.WaitBetweenRetriesType != WaitType.None)
                {
                    TimeSpan waitFor = GetRetryTimeSpan(retries, now);
                    await Task.Delay((int)waitFor.TotalMilliseconds, cancellationToken);
                }
            } while (shouldRetry);
            
            ThrowExceptions(shouldRetry, exceptions);
        }
        
        public void BeginRetryProcess()
        {
            CheckDisposed();
            
            DateTime now = DateTime.UtcNow;
            int retries = 0;
            List<Exception> exceptions = new List<Exception>();
            bool shouldRetry = true;
            
            do
            {
                shouldRetry = RunOnce(exceptions, now, ref retries);
                
                if (shouldRetry && options.WaitBetweenRetriesType != WaitType.None)
                {
                    TimeSpan waitFor = GetRetryTimeSpan(retries, now);
                    Task.Delay((int)waitFor.TotalMilliseconds).Wait();
                }
            } while (shouldRetry);
            
            ThrowExceptions(shouldRetry, exceptions);
        }
        
        private bool RunOnce(IList<Exception> exceptions, DateTime now, ref int retries)
        {
            bool shouldRetry = true;
            
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

                if (options.Type.HasFlag(RetryType.Times) && retries >= options.RetryTimes - 1)
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
            
            return shouldRetry;
        }
        
        private TimeSpan GetRetryTimeSpan(int retries, DateTime now)
        {
            TimeSpan waitFor;
            if (options.WaitBetweenRetriesType == WaitType.For && options.WaitForDuration.HasValue)
            {
                waitFor = options.WaitForDuration.Value;
            }
            else if (options.WaitBetweenRetriesType == WaitType.Until)
            {
                waitFor = options.WaitUntilDelegate.Invoke(retries, now, options);
            }
            return waitFor;
        }
        
        private void ThrowExceptions(bool shouldRetry, IEnumerable<Exception> exceptions)
        {
            if (!shouldRetry && options.ThrowExceptionOnLastRetry)
            {
                throw new AggregateException(exceptions);
            }
        }
        
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        
        private void CheckDisposed()
        {
            if (disposedValue)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
        }

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

        ~RetryContext() {
          Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}