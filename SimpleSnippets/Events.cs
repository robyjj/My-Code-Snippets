using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public delegate void Notify();
    class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }

    class Runner
    {
        public static void Main(string[] args)
        {
            ProcessBusinessLogic b1 = new ProcessBusinessLogic();
            b1.ProcessCompleted += bl_ProcessCompleted;
            b1.StartProcess();
        }
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
