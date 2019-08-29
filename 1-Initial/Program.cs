using System;

namespace _1_Initial
{
    class Program
    {
        #region 
        public static string NotExtensionMethod(string str)
        {
            return str;
        }
        public static void CountlessParameters(params int[] ps) { }

        public class DisposableClass : IDisposable
        {
            public void Dispose() { }
        }

        #endregion

        static void Main(string[] args)
        {
            #region Exceptions bad practices
            try
            {
                var value = 0;
                var otherValue = 10 / value; // throw DivideByZeroException;
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion

            #region Extension methods
            var str = "Hello Cap";
            str.ExtensionMethod();
            // NotExtensionMethod(str);
            #endregion

            #region Params
            CountlessParameters();
            CountlessParameters(1);
            CountlessParameters(1, 2);
            CountlessParameters(1, 2, 3, 4, 5, 6);
            #endregion

            #region Disposable Class
            using (var disposableClass = new DisposableClass())
            {
                // use disposableClass

            } // disposableClass.Dispose();
            #endregion

            #region Arrow function
            string Method()
            {
                return "";
            }
            string Method2() => "";
            #endregion
        }
    }

    static class Extensions
    {
        public static string ExtensionMethod(this string str)
        {
            return str.Trim();
        }

    }
}
