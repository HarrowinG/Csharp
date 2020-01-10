using System.Collections.Generic;
using System.Threading.Tasks;

namespace Csharp.Threading
{
    class StaticFieldSafe
    {
        private static int Counter;

        private class Holder
        {
            public int counter;
        }

        public static async void CheckObjectCounter()
        {
            var holder = new Holder();
            var tasks = new List<Task>();
            for (int i = 0; i < 100; i++)
            {
                var task1 = Task.Run(() => ++holder.counter);
                var task2 = Task.Run(() => --holder.counter);
                tasks.Add(task1);
                tasks.Add(task2);
            }

            await Task.WhenAll(tasks);
            var a = holder.counter;  //sometimes will not be 0 because of unsafe object field
            var b = 0;
        }

        public static async void CheckStaticCounter()
        {
            var tasks = new List<Task>();
            for (int i = 0; i < 100; i++)
            {
                var task1 = Task.Run(() => ++Counter);
                var task2 = Task.Run(() => --Counter);
                tasks.Add(task1);
                tasks.Add(task2);
            }
            
            await Task.WhenAll(tasks);
            var a = Counter;  //always 0 because of safe static field
            var b = 0;
        }

        public static void Run()
        {
            CheckObjectCounter();
            CheckStaticCounter();
        }
    }
}
