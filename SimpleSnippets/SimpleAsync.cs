using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public class SimpleAsync
    {
        public void Run()
        {
            DoSomeSync();
            var task = DoSomeAsync();
            DoSomemoreSync();
            task.Wait();
            Console.ReadLine();
        }

        public void DoSomeSync()
        {

        }
        public void DoSomemoreSync()
        {

        }
        public async Task DoSomeAsync()
        {
            await Task.Run(() =>
            {
                //Large Process
            });
        }
       
    }

    public class SimpleAsyncClient
    {
       

    }
}
