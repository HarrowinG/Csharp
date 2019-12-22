using System.Collections.Generic;

namespace Csharp.DynamicBinding
{
    class Dynamic
    {
        static void DynamicAndObjectEquality()
        {
            dynamic x = "hello";
            var a = x.GetType().Name;
            x = 123;
            var b = x.GetType().Name;

            object y = "hello";
            var c = y.GetType().Name;
            y = 123;
            var d = y.GetType().Name;

            var e = typeof(object[]) == typeof(dynamic[]);
            var f = typeof(List<object>) == typeof(List<dynamic>);
        }

        public static void Run()
        {
            DynamicAndObjectEquality();
        }
    }
}
