using System;
using System.Threading;
using System.Threading.Tasks;

namespace IX.Retry
{
    public class Retry
    {
        public void Now(Action action)
        {
            Run(action, new RetryOptions());
        }

        public async Task NowAsync(Action action, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Run(action, new RetryOptions());
        }

        public void Now(Action action, RetryOptions options)
        {
            Run(action, options);
        }

        public async Task NowAsync(Action action, RetryOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Run(action, options);
        }

        public void Now(Action action, Action<RetryOptions> optionsSetter)
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            var options = new RetryOptions();
            optionsSetter(options);
            
            Run(action, options);
        }

        public async Task NowAsync(Action action, Action<RetryOptions> optionsSetter, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Now(action, optionsSetter);
        }

        public Action Later(Action action)
        {
            return () => Run(action, new RetryOptions());
        }

        public Action Later(Action action, RetryOptions options)
        {
            return () => Run(action, options);
        }

        public Action Later(Action action, Action<RetryOptions> optionsSetter)
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            var options = new RetryOptions();
            optionsSetter(options);
            
            return () => Run(action, options);
        }

        private void Run(Action action, RetryOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            
            using (RetryContext context = new RetryContext(options, action))
            {
                context.BeginRetryProcess();
            }
        }
    }
}