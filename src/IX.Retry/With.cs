using System;
using System.Threading;

namespace IX.Retry
{
    /// <summary>
    /// Contains static methods that facilitate retries.
    /// </summary>
    public static partial class With
    {
        #region With result

        #region Function, returns result

        /// <summary>
        /// Invokes a <see cref="System.Func{TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<TResult>(Func<TResult> func, IRetryPolicy retryPolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T">The first function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg">The first function parameter, of the type specified in <typeparamref name="T"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<T, TResult>(Func<T, TResult> func, IRetryPolicy retryPolicy, T arg, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<T1, T2, TResult>(Func<T1, T2, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, cancellationToken);
        }

        /// <summary>
        /// Invokes a <see cref="System.Func{T1, T2, T3, T4, TResult}"/> with a retry policy and a cancellation token.
        /// </summary>
        /// <typeparam name="T1">The first function parameter type.</typeparam>
        /// <typeparam name="T2">The second function parameter type.</typeparam>
        /// <typeparam name="T3">The third function parameter type.</typeparam>
        /// <typeparam name="T4">The fourth function parameter type.</typeparam>
        /// <typeparam name="TResult">The result of the call.</typeparam>
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
        /// <param name="retryPolicy">A retry policy to apply to the function.</param>
        /// <param name="arg1">The first function parameter, of the type specified in <typeparamref name="T1"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg2">The second function parameter, of the type specified in <typeparamref name="T2"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg3">The third function parameter, of the type specified in <typeparamref name="T3"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg4">The fourth function parameter, of the type specified in <typeparamref name="T4"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg5">The fifth function parameter, of the type specified in <typeparamref name="T5"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="arg6">The sixth function parameter, of the type specified in <typeparamref name="T6"/>. This parameter is not null-checked and is forwarded directly to the function.</param>
        /// <param name="cancellationToken">The task's (optional) <see cref="System.Threading.CancellationToken"/>.</param>
        /// <returns>The result of the operation, after retries, of the type <typeparamref name="TResult"/>.</returns>
        public static TResult Retry<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, cancellationToken);
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
        /// <param name="func">The function to execute with retry.</param>
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
        public static TResult Retry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, IRetryPolicy retryPolicy, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, CancellationToken cancellationToken = default(CancellationToken))
        {
            return func.WithRetry(retryPolicy, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, cancellationToken);
        }

        #endregion

        #endregion With result
    }
}
