using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    class ActionFuncPred
    {
        static void Main(string[] args)
        {
            //Action does not return anything
            Action<string> log = new Action<string>(LogInfo);
            log.Invoke("Hi ALL");
            //log("aaa");
            Console.ReadLine();


            Func<int, int, int> addFunc = new Func<int, int, int>(Add);
            int result = addFunc(3, 4);
            Console.WriteLine(result);
            Console.ReadLine();

            ///dont specify return type as its always bool
            Predicate<int> IsEven = new Predicate<int>(IsEvenNumber);
            Console.WriteLine(IsEven(10));
            Console.WriteLine(IsEven(1567));
            Console.ReadLine();

        }

        static void LogInfo(string message)
        {
            Console.WriteLine(message);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
    }
}
