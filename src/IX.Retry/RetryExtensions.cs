using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IX.Retry
{
    public static class RetryExtensions
    {
        #region Return type Func<Task>

        public static async Task WithRetryAsync(this Func<Task> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T>(this Func<T, Task> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2>(this Func<T1, T2, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3>(this Func<T1, T2, T3, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

        #endregion

        #region Return type Func<Task<TResult>>

        public static async Task WithRetryAsync<TResult>(this Func<Task<TResult>> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T, TResult>(this Func<T, Task<TResult>> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, TResult>(this Func<T1, T2, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, TResult>(this Func<T1, T2, T3, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

        #endregion

        #region Return type Func<TResult>

        public static async Task WithRetryAsync<TResult>(this Func<TResult> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T, TResult>(this Func<T, TResult> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, TResult>(this Func<T1, T2, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        #endregion

        #region Return type Action

        public static async Task WithRetryAsync(this Action action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T>(this Action<T> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2>(this Action<T1, T2> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3>(this Action<T1, T2, T3> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        #endregion

        private static async Task DoRetryAsync(Func<CancellationToken, Task> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (retryPolicy == null)
                throw new NullReferenceException(nameof(retryPolicy));

            cancellationToken.ThrowIfCancellationRequested();

            ShouldRetry shouldRetry = retryPolicy();

            for (int i = 0; ; i++)
            {
                try
                {
                    await action(cancellationToken);
                }
                catch (Exception ex)
                {
                    TimeSpan retryInterval;
                    if (!shouldRetry(i, ex, out retryInterval))
                        return;

                    if (TimeSpan.Zero < retryInterval)
                        await Task.Delay(retryInterval, cancellationToken);
                }

                cancellationToken.ThrowIfCancellationRequested();
            }
        }

        #region Return type Func<Task>

        public static async Task WithRetryAsync(this Func<Task> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T>(this Func<T, Task> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2>(this Func<T1, T2, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3>(this Func<T1, T2, T3, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

        #endregion

        #region Return type Func<Task<TResult>>

        public static async Task WithRetryAsync<TResult>(this Func<Task<TResult>> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T, TResult>(this Func<T, Task<TResult>> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, TResult>(this Func<T1, T2, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, TResult>(this Func<T1, T2, T3, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

        #endregion

        #region Return type Func<TResult>

        public static async Task WithRetryAsync<TResult>(this Func<TResult> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T, TResult>(this Func<T, TResult> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, TResult>(this Func<T1, T2, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        #endregion

        #region Return type Action

        public static async Task WithRetryAsync(this Action action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T>(this Action<T> action, RetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2>(this Action<T1, T2> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3>(this Action<T1, T2, T3> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static async Task WithRetryAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            await DoRetryAsync(p => { action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); return Task.FromResult(0); }, retryPolicy, cancellationToken);
        }

        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11), retryPolicy, cancellationToken);
        }

        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), retryPolicy, cancellationToken);
        }

        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13), retryPolicy, cancellationToken);
        }

        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14), retryPolicy, cancellationToken);
        }

        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15), retryPolicy, cancellationToken);
        }

        public static void WithRetry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, RetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (action == null)
                throw new NullReferenceException(nameof(action));

            DoRetry(p => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16), retryPolicy, cancellationToken);
        }

        #endregion

        private static void DoRetry(Action<CancellationToken> action, RetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (retryPolicy == null)
                throw new NullReferenceException(nameof(retryPolicy));

            if (cancellationToken.IsCancellationRequested)
                return;

            ShouldRetry shouldRetry = retryPolicy();

            for (int i = 0; ; i++)
            {
                try
                {
                    action(cancellationToken);
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
    }
}