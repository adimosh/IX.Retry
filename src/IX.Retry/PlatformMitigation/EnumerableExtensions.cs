#if MONOANDROID10 || MONOTOUCH10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class EnumerableExtensions
    {
        public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> condition)
        {
            IEnumerator<T> enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (condition(enumerator.Current))
                    return true;
            }

            return false;
        }
    }
}
#endif