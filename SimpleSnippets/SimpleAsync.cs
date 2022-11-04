using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public class SimpleAsync
    {
        public static void Run()
        {
            DoSomeSync();
            var task = DoSomeAsync();
            DoSomemoreSync();
            task.Wait();
            Console.ReadLine();
        }

        public static void DoSomeSync()
        {
            Console.WriteLine("DoSomeSync");
        }
        public static void DoSomemoreSync()
        {
            Console.WriteLine("DoSomemoreSync");
        }
        public static async Task DoSomeAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Large Process");
                //Large Process
            });
        }
       
    }

    public class SimpleAsyncClient
    {
       

    }
}
