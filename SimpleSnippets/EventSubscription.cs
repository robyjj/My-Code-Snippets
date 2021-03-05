using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public static class EventSubscription
    {
        public static void Run() 
        {
            var watcher = new FileSystemWatcher(@"C:\Roby\Newfolder");
            watcher.EnableRaisingEvents = true;
            watcher.Created += new FileSystemEventHandler(OnCreated);
            Console.ReadLine();
        }

        public static void OnCreated(object sender,FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.ChangeType} : {e.Name}");
        }
    }
}
