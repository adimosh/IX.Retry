using System;
using System.Threading.Tasks;
using Xunit;

namespace IX.Retry.UnitTests
{

	public class RetryTest_FuncResult_Asynchronous_0_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();

            int result = await With.RetryAsync(new Func<int>(DelegateMethod_FuncResult_Asynchronous_0_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1));

			Assert.True(retries == maxRetries);
			Assert.Equal(result, -32768);
        }

        private int DelegateMethod_FuncResult_Asynchronous_0_1()
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return -32768;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_1_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();

            int result = await With.RetryAsync(new Func<int, int>(DelegateMethod_FuncResult_Asynchronous_1_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1);
			int expectedResult = param1;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_1_1(int param1)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_2_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int>(DelegateMethod_FuncResult_Asynchronous_2_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2);
			int expectedResult = param1 + param2;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_2_1(int param1, int param2)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_3_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_3_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3);
			int expectedResult = param1 + param2 + param3;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_3_1(int param1, int param2, int param3)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_4_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_4_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4);
			int expectedResult = param1 + param2 + param3 + param4;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_4_1(int param1, int param2, int param3, int param4)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_5_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_5_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5);
			int expectedResult = param1 + param2 + param3 + param4 + param5;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_5_1(int param1, int param2, int param3, int param4, int param5)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_6_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_6_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_6_1(int param1, int param2, int param3, int param4, int param5, int param6)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_7_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_7_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_7_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_8_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_8_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_8_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_9_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_9_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_9_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_10_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_10_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_10_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_11_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_11_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_11_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_12_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_12_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_12_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_13_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_13_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_13_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_14_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_14_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_14_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_15_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();
            int param15 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_15_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_15_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_16_1
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();
            int param15 = r.Next();
            int param16 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_16_1), Policy.CountBasedRetryPolicy<InvalidOperationException>(1), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_16_1(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_0_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();

            int result = await With.RetryAsync(new Func<int>(DelegateMethod_FuncResult_Asynchronous_0_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(1));

			Assert.True(retries == maxRetries);
			Assert.Equal(result, -32768);
        }

        private int DelegateMethod_FuncResult_Asynchronous_0_2()
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return -32768;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_1_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();

            int result = await With.RetryAsync(new Func<int, int>(DelegateMethod_FuncResult_Asynchronous_1_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1);
			int expectedResult = param1;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_1_2(int param1)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_2_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int>(DelegateMethod_FuncResult_Asynchronous_2_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2);
			int expectedResult = param1 + param2;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_2_2(int param1, int param2)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_3_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_3_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3);
			int expectedResult = param1 + param2 + param3;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_3_2(int param1, int param2, int param3)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_4_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_4_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4);
			int expectedResult = param1 + param2 + param3 + param4;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_4_2(int param1, int param2, int param3, int param4)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_5_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_5_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5);
			int expectedResult = param1 + param2 + param3 + param4 + param5;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_5_2(int param1, int param2, int param3, int param4, int param5)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_6_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_6_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_6_2(int param1, int param2, int param3, int param4, int param5, int param6)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_7_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_7_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_7_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_8_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_8_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_8_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_9_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_9_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_9_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_10_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_10_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_10_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_11_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_11_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_11_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_12_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_12_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_12_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_13_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_13_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_13_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_14_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_14_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_14_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_15_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();
            int param15 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_15_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_15_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_16_2
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 2;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();
            int param15 = r.Next();
            int param16 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_16_2), Policy.CountBasedRetryPolicy<InvalidOperationException>(2), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_16_2(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_0_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 1;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();

            int result = await With.RetryAsync(new Func<int>(DelegateMethod_FuncResult_Asynchronous_0_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(1));

			Assert.True(retries == maxRetries);
			Assert.Equal(result, -32768);
        }

        private int DelegateMethod_FuncResult_Asynchronous_0_3()
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return -32768;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_1_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();

            int result = await With.RetryAsync(new Func<int, int>(DelegateMethod_FuncResult_Asynchronous_1_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1);
			int expectedResult = param1;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_1_3(int param1)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_2_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int>(DelegateMethod_FuncResult_Asynchronous_2_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2);
			int expectedResult = param1 + param2;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_2_3(int param1, int param2)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_3_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_3_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3);
			int expectedResult = param1 + param2 + param3;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_3_3(int param1, int param2, int param3)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_4_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_4_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4);
			int expectedResult = param1 + param2 + param3 + param4;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_4_3(int param1, int param2, int param3, int param4)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_5_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_5_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5);
			int expectedResult = param1 + param2 + param3 + param4 + param5;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_5_3(int param1, int param2, int param3, int param4, int param5)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_6_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_6_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_6_3(int param1, int param2, int param3, int param4, int param5, int param6)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_7_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_7_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_7_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_8_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_8_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_8_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_9_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_9_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_9_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_10_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_10_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_10_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_11_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_11_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_11_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_12_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_12_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_12_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_13_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_13_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_13_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_14_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_14_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_14_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_15_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();
            int param15 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_15_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_15_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15;
        }
	}

	public class RetryTest_FuncResult_Asynchronous_16_3
	{
		int retries;
		int maxRetries;

        [Fact]
        public async Task Test()
        {
			maxRetries = 3;
			retries = 0;

			Random r = new Random();
			int param1 = r.Next();
            int param2 = r.Next();
            int param3 = r.Next();
            int param4 = r.Next();
            int param5 = r.Next();
            int param6 = r.Next();
            int param7 = r.Next();
            int param8 = r.Next();
            int param9 = r.Next();
            int param10 = r.Next();
            int param11 = r.Next();
            int param12 = r.Next();
            int param13 = r.Next();
            int param14 = r.Next();
            int param15 = r.Next();
            int param16 = r.Next();

            int result = await With.RetryAsync(new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(DelegateMethod_FuncResult_Asynchronous_16_3), Policy.CountBasedRetryPolicy<InvalidOperationException>(3), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16);
			int expectedResult = param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16;

			Assert.True(retries == maxRetries);
			Assert.Equal(expectedResult, result);
        }

        private int DelegateMethod_FuncResult_Asynchronous_16_3(int param1, int param2, int param3, int param4, int param5, int param6, int param7, int param8, int param9, int param10, int param11, int param12, int param13, int param14, int param15, int param16)
        {
            if (retries < maxRetries)
            {
                retries++;
                throw new InvalidOperationException();
            }

			return param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16;
        }
	}
}