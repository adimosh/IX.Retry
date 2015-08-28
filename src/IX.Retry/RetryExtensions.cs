using System;
using System.Threading;
using System.Threading.Tasks;

namespace IX.Retry
{
    /// <summary>
    /// Extension methods for retrying actions and functions.
    /// </summary>
    public static class RetryExtensions
    {
        #region Asynchronous

        #region Without result

        private static async Task DoRetryAsync(Func<CancellationToken, Task> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (retryPolicy == null)
                throw new NullReferenceException(nameof(retryPolicy));

            cancellationToken.ThrowIfCancellationRequested();

            ShouldRetry shouldRetry = retryPolicy.ExecuteRetryPolicy();

            for (int i = 0; ; i++)
            {
                try
                {
                    await action(cancellationToken);
                    return;
                }
                catch (Exception ex)
                {
                    TimeSpan retryInterval;
                    if (!shouldRetry(i, ex, out retryInterval))
                        throw;

                    if (TimeSpan.Zero < retryInterval)
                        await
#if NET40
                            TaskEx
#else
                            Task
#endif
                            .Delay(retryInterval, cancellationToken);
                }

                cancellationToken.ThrowIfCancellationRequested();
            }
        }

#region Function, returning task

        /// <summary>
        /// Invokes a <see cref="System.Func{TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync(this Func<Task> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg">The first function parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T>(this Func<T, Task> action, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2>(this Func<T1, T2, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3>(this Func<T1, T2, T3, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="T16">The sixteenth function parameter type.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg16">The sixteenth function parameter, of the type specified in <typeparamref name="T16"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

#endregion

#region Action

        /// <summary>
        /// Invokes an <see cref="System.Action"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync(this Action action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg">The first action parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T>(this Action<T> action, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2>(this Action<T1, T2> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3>(this Action<T1, T2, T3> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg14">The fourteenth action parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth action parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg14">The fourteenth action parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg15">The fifteenth action parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth action parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth action parameter type.</typeparam>
        /// <typeparam name="T16">The sixteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg14">The fourteenth action parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg15">The fifteenth action parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg16">The sixteenth action parameter, of the type specified in <typeparamref name="T16"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>A <see cref="System.Threading.Tasks.Task"/> that can be awaited.</returns>
        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); return TaskExtensions.EmptyTask; }, retryPolicy, cancellationToken);
        }

#endregion

#endregion Without result

#region With result

        private static async Task<TResult> DoRetryAsync<TResult>(Func<CancellationToken, Task<TResult>> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (retryPolicy == null)
                throw new NullReferenceException(nameof(retryPolicy));

            cancellationToken.ThrowIfCancellationRequested();

            ShouldRetry shouldRetry = retryPolicy.ExecuteRetryPolicy();

            for (int i = 0; ; i++)
            {
                try
                {
                    return await action(cancellationToken);
                }
                catch (Exception ex)
                {
                    TimeSpan retryInterval;
                    if (!shouldRetry(i, ex, out retryInterval))
                        throw;

                    if (TimeSpan.Zero < retryInterval)
                        await
#if NET40
                            TaskEx
#else
                            Task
#endif
                            .Delay(retryInterval, cancellationToken);
                }

                cancellationToken.ThrowIfCancellationRequested();
            }
        }

#region Function, returns result

        /// <summary>
        /// Invokes a <see cref="System.Func{TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<TResult>(this Func<TResult> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action()), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg">The first function parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T, TResult>(this Func<T, TResult> action, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, TResult>(this Func<T1, T2, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="T16">The sixteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg16">The sixteenth function parameter, of the type specified in <typeparamref name="T16"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p =>
#if NET40
                TaskEx
#else
                Task
#endif
                .FromResult(action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)), retryPolicy, cancellationToken);
        }

#endregion

#region Function, returns task of result

        /// <summary>
        /// Invokes a <see cref="System.Func{TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<TResult>(this Func<Task<TResult>> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg">The first function parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T, TResult>(this Func<T, Task<TResult>> action, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, TResult>(this Func<T1, T2, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, TResult>(this Func<T1, T2, T3, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="T16">The sixteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg16">The sixteenth function parameter, of the type specified in <typeparamref name="T16"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static Task<TResult> WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

#endregion

#endregion With result

#endregion Asynchronous

#region Synchronous

#region Without result

        private static void DoRetry(Action<CancellationToken> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (retryPolicy == null)
                throw new NullReferenceException(nameof(retryPolicy));

            if (cancellationToken.IsCancellationRequested)
                return;

            ShouldRetry shouldRetry = retryPolicy.ExecuteRetryPolicy();

            for (int i = 0; ; i++)
            {
                try
                {
                    action(cancellationToken);
                    return;
                }
                catch (Exception ex)
                {
                    TimeSpan retryInterval;
                    if (!shouldRetry(i, ex, out retryInterval))
                        return;

                    if (TimeSpan.Zero < retryInterval)
                        Thread.Sleep(retryInterval);
                }

                if (cancellationToken.IsCancellationRequested)
                    return;
            }
        }

#region Action

        /// <summary>
        /// Invokes an <see cref="System.Action"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry(this Action action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg">The first action parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T>(this Action<T> action, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2>(this Action<T1, T2> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3>(this Action<T1, T2, T3> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg14">The fourteenth action parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth action parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg14">The fourteenth action parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg15">The fifteenth action parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes an <see cref="System.Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first action parameter type.</typeparam>
        /// <typeparam name="T2">The second action parameter type.</typeparam>
        /// <typeparam name="T3">The third action parameter type.</typeparam>
        /// <typeparam name="T4">The fourth action parameter type.</typeparam>
        /// <typeparam name="T5">The fifth action parameter type.</typeparam>
        /// <typeparam name="T6">The sixth action parameter type.</typeparam>
        /// <typeparam name="T7">The seventh action parameter type.</typeparam>
        /// <typeparam name="T8">The eighth action parameter type.</typeparam>
        /// <typeparam name="T9">The ninth action parameter type.</typeparam>
        /// <typeparam name="T10">The tenth action parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh action parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth action parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth action parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth action parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth action parameter type.</typeparam>
        /// <typeparam name="T16">The sixteenth action parameter type.</typeparam>
        /// <param name="action">The action to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the action.</param>
        /// <param name="arg1">The first action parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg2">The second action parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg3">The third action parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg4">The fourth action parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg5">The fifth action parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg6">The sixth action parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg7">The seventh action parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg8">The eighth action parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg9">The ninth action parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg10">The tenth action parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg11">The eleventh action parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg12">The twelfth action parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg13">The thirteenth action parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg14">The fourteenth action parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg15">The fifteenth action parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="arg16">The sixteenth action parameter, of the type specified in <typeparamref name="T16"/>. This parameter is not null-checked and is forwarded directly to the action.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

#endregion

#endregion Without result

#region With result

        private static TResult DoRetry<TResult>(Func<CancellationToken, TResult> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (retryPolicy == null)
                throw new NullReferenceException(nameof(retryPolicy));

            cancellationToken.ThrowIfCancellationRequested();

            ShouldRetry shouldRetry = retryPolicy.ExecuteRetryPolicy();

            for (int i = 0; ; i++)
            {
                try
                {
                    return action(cancellationToken);
                }
                catch (Exception ex)
                {
                    TimeSpan retryInterval;
                    if (!shouldRetry(i, ex, out retryInterval))
                        throw;

                    if (TimeSpan.Zero < retryInterval)
                        Thread.Sleep(retryInterval);
                }

                cancellationToken.ThrowIfCancellationRequested();
            }
        }

#region Function, returns result

        /// <summary>
        /// Invokes a <see cref="System.Func{TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<TResult>(this Func<TResult> action, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg">The first function parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T, TResult>(this Func<T, TResult> action, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, TResult>(this Func<T1, T2, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="T5">The fifth function parameter type.</typeparam>
        /// <typeparam name="T6">The sixth function parameter type.</typeparam>
        /// <typeparam name="T7">The seventh function parameter type.</typeparam>
        /// <typeparam name="T8">The eighth function parameter type.</typeparam>
        /// <typeparam name="T9">The ninth function parameter type.</typeparam>
        /// <typeparam name="T10">The tenth function parameter type.</typeparam>
        /// <typeparam name="T11">The eleventh function parameter type.</typeparam>
        /// <typeparam name="T12">The twelfth function parameter type.</typeparam>
        /// <typeparam name="T13">The thirteenth function parameter type.</typeparam>
        /// <typeparam name="T14">The fourteenth function parameter type.</typeparam>
        /// <typeparam name="T15">The fifteenth function parameter type.</typeparam>
        /// <typeparam name="T16">The sixteenth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="action">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg7">The seventh function parameter, of the type specified in <typeparamref name="T7"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg8">The eighth function parameter, of the type specified in <typeparamref name="T8"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg9">The ninth function parameter, of the type specified in <typeparamref name="T9"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg10">The tenth function parameter, of the type specified in <typeparamref name="T10"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg11">The eleventh function parameter, of the type specified in <typeparamref name="T11"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg12">The twelfth function parameter, of the type specified in <typeparamref name="T12"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg13">The thirteenth function parameter, of the type specified in <typeparamref name="T13"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg14">The fourteenth function parameter, of the type specified in <typeparamref name="T14"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg15">The fifteenth function parameter, of the type specified in <typeparamref name="T15"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg16">The sixteenth function parameter, of the type specified in <typeparamref name="T16"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> action, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            return DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

#endregion

#endregion With result

#endregion Synchronous
    }
}