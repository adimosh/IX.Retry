using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace IX.Retry.UnitTests
{
    internal partial class RetryTestMethodWrapper
    {
        private Task RetryTestFuncWithTaskMethod<TException1>()
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>()
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7) });
		}

        private Task RetryTestFuncWithTaskMethod<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
                where TException1 : Exception, new()
                where TException2 : Exception, new()
                where TException3 : Exception, new()
                where TException4 : Exception, new()
                where TException5 : Exception, new()
                where TException6 : Exception, new()
                where TException7 : Exception, new()
                where TException8 : Exception, new()
        {
		    return RetryTestAsyncMethod(new[] { typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4), typeof(TException5), typeof(TException6), typeof(TException7), typeof(TException8) });
		}

        private static void RetryTestFuncWithTaskMethodGenerator()
        {
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 0), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 0),
				typeof(Func<Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 1), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 1),
				typeof(Func<int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 2), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 2),
				typeof(Func<int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 3), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 3),
				typeof(Func<int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 4), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 4),
				typeof(Func<int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 5), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 5),
				typeof(Func<int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 6), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 6),
				typeof(Func<int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 7), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 7),
				typeof(Func<int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 8), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 8),
				typeof(Func<int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 9), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 9),
				typeof(Func<int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 10), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 10),
				typeof(Func<int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 11), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 11),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 12), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 12),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 13), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 13),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 14), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 14),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 15), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 15),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 1, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 1 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 2, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 2 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 3, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 3 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 4, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 4 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 5, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 5 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 6, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 6 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 7, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 7 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
			
            delegateInformation.Add(new Tuple<string, int, int>("functask", 8, 16), new Tuple<MethodInfo, Type>(
			    typeof(RetryTestMethodWrapper).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Single(p => p.Name == "RetryTestFuncWithTaskMethod" && p.GetGenericArguments().Length == 8 && p.GetParameters().Length == 16),
				typeof(Func<int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int, Task>)
			));
        }        
    }
}