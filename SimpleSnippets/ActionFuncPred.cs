using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public class ActionFuncPred
    {        
        public static void Run()
        {
            Predicate<string> longWords = delegate (string word) { return word.Length > 2; };
            Predicate<string>  startsWith =  (string word) => { return word.StartsWith("d"); }; 
            //Predicate<int> fn = x => x > 0;
            string[] words = { "abc", "ddddddd", "assssssd" };
            longWords += startsWith;
            int res = Count(words, longWords);

            Action<int> CW = Console.WriteLine;
            //Action does not return anything
            Action<string> log = new Action<string>(LogInfo);
            log.Invoke("Hi ALL");
            //log("aaa");
            Console.ReadLine();


            Func<int, int, int> addFunc = Add;// new Func<int, int, int>(Add);
            int result = addFunc(3, 4);
            CW(result);
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

        static int Count<T>(T [] arr, Predicate<T> condition)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (condition(arr[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
