using System;
using System.Collections.Generic;

namespace IX.Retry.UnitTests
{
    public partial class RetryTheories
    {
	    static partial void GenerateTestData(List<object[]> objects, Random r, List<Type> exceptionTypes)
		{
            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    1,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    2,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    3,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] {  },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

            objects.Add(new object[]
                {
                    4,
                    new int[] { r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next(), r.Next() },
                    new Type[] { exceptionTypes[0], exceptionTypes[1], exceptionTypes[2], exceptionTypes[3], exceptionTypes[4], exceptionTypes[5], exceptionTypes[6], exceptionTypes[7] }
                });

		}
	}
}