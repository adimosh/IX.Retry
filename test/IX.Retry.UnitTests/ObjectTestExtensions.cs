using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IX.Retry.UnitTests
{
    internal static class ObjectTestExtensions
    {
        public static bool MultiVerify<TObject>(this TObject obj, Func<TObject, bool> verifyFunction)
        {
            return verifyFunction(obj);
        }

        public static bool MultiVerify<TObject>(this TObject obj, Func<TObject, bool> verifyFunction1, Func<TObject, bool> verifyFunction2)
        {
            return verifyFunction1(obj) && verifyFunction2(obj);
        }

        public static bool MultiVerify<TObject>(this TObject obj, Func<TObject, bool> verifyFunction1, Func<TObject, bool> verifyFunction2, Func<TObject, bool> verifyFunction3)
        {
            return verifyFunction1(obj) && verifyFunction2(obj) && verifyFunction3(obj);
        }

        public static bool MultiVerify<TObject>(this TObject obj, Func<TObject, bool> verifyFunction1, Func<TObject, bool> verifyFunction2, Func<TObject, bool> verifyFunction3, Func<TObject, bool> verifyFunction4)
        {
            return verifyFunction1(obj) && verifyFunction2(obj) && verifyFunction3(obj) && verifyFunction4(obj);
        }
    }
}