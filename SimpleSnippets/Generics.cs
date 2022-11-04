using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnippets
{
    public class Generics
    {
        public static void Run()
        {
            Display(2);
            Display(2.5);
            Display("Hello");

            var obj = new Generic<string>();
            obj.Result = "foo";            

            var obj2 = new Generic<int>();
            obj2.Result = 5;
        }
        public static void Display<T>(T a)
        {
            Console.WriteLine($"Value is : {a}");
        }
    }

    public class Generic<T> // where T : class,struct
    {
        public T Result { get; set; }
    }

    
}
