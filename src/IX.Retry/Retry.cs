using System;
using System.Threading;
using System.Threading.Tasks;

namespace IX.Retry
{
    /// <summary>
    /// A class for containing retry operations.
    /// </summary>
    public static class Retry
    {
        /// <summary>
        /// Retry now, with a default set of options.
        /// </summary>
        /// <param name="action">The action to try and retry.</param>
        public static void Now(Action action)
        {
            Run(action, new RetryOptions());
        }

        /// <summary>
        /// Retry now, asynchronously, with an optional cancellation token.
        /// </summary>
        /// <param name="action">The action to try and retry.</param>
        /// <param name="cancellationToken">The current operation's cancellation token.</param>
        /// <returns>A task that can be awaited on.</returns>
        public static async Task NowAsync(Action action, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Run(action, new RetryOptions());
        }

        /// <summary>
        /// Retry now, with specified options.
        /// </summary>
        /// <param name="action">The action to try and retry.</param>
        /// <param name="options">The retry options.</param>
        public static void Now(Action action, RetryOptions options)
        {
            Run(action, options);
        }

        /// <summary>
        /// Retry now, asynchronously, with specified options and an optional cancellation token.
        /// </summary>
        /// <param name="action">The action to try and retry.</param>
        /// <param name="options">The retry options.</param>
        /// <param name="cancellationToken">The current operation's cancellation token.</param>
        /// <returns>A task that can be awaited on.</returns>
        public static async Task NowAsync(Action action, RetryOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Run(action, options);
        }

        /// <summary>
        /// Retry now, with a method to build up options.
        /// </summary>
        /// <param name="action">The action to try and retry.</param>
        /// <param name="optionsSetter">A method to build up options on the fly.</param>
        public static void Now(Action action, Action<RetryOptions> optionsSetter)
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            var options = new RetryOptions();
            optionsSetter(options);
            
            Run(action, options);
        }

        /// <summary>
        /// Retry now, asynchronously, with a method to build up options and an optional cancellation token.
        /// </summary>
        /// <param name="action">The action to try and retry.</param>
        /// <param name="optionsSetter">A method to build up options on the fly.</param>
        /// <param name="cancellationToken">The current operation's cancellation token.</param>
        /// <returns>A task that can be awaited on.</returns>
        public static async Task NowAsync(Action action, Action<RetryOptions> optionsSetter, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            await Task.Yield();

            cancellationToken.ThrowIfCancellationRequested();

            Now(action, optionsSetter);
        }

        public static Action Later(Action action)
        {
            return () => Run(action, new RetryOptions());
        }

        public static Action Later(Action action, RetryOptions options)
        {
            return () => Run(action, options);
        }

        public static Action Later(Action action, Action<RetryOptions> optionsSetter)
        {
            if (optionsSetter == null)
            {
                throw new ArgumentNullException(nameof(optionsSetter));
            }

            var options = new RetryOptions();
            optionsSetter(options);
            
            return () => Run(action, options);
        }

        private static void Run(Action action, RetryOptions options, CancellationToken cancellationToken = default(CancellationToken))
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