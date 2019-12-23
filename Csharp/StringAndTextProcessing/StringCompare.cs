using System;
using System.Text;

namespace Csharp.StringAndTextProcessing
{
    class StringCompare
    {
        static void CheckCompareValue()
        {
            var a = "Boston".CompareTo("Austin");
            var d = "foo".CompareTo("FOO");
            var e = "f".CompareTo("F");
            var b = "Boston".CompareTo("Chicago");

            var c = 0;
        }

        static void Encodings()
        {
            foreach (var encoding in Encoding.GetEncodings())
            {
                Console.WriteLine(encoding.Name);
            }

            var a = Encoding.GetEncoding("utf-8");
            var b = new [] {Encoding.Unicode, Encoding.UTF8, Encoding.UTF7, Encoding.Unicode, Encoding.UTF32, Encoding.ASCII};

            var _a = 0;
        }

        public static void Run()
        {
            CheckCompareValue();
            Encodings();
        }
    }
}
