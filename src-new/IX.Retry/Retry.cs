using System;
using System.Threading;
using System.Threading.Tasks;

namespace IX.Retry
{
    public class Retry
    {
        public void Now(Action action)
        {
            RetryContext c = new RetryContext(new RetryOptions(), action);
            c.BeginRetryProcess();
        }

        public async Task NowAsync(Action action, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Now(action);
        }

        public void Now(Action action, Action<RetryOptions> optionsSetter)
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            var options = new RetryOptions();
            optionsSetter(options);
            RetryContext c = new RetryContext(options, action);
            c.BeginRetryProcess();
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
    }
}