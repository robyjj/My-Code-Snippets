using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public delegate int NumberChanger(int num);
    public class Delegates
    {
        static int num = 10;

        public static int ModifyNumber (int n)
        {
             num += n;
            return num;
        }
        public static void Run()//string[] args)
        {
            NumberChanger nc = ModifyNumber;//new NumberChanger(ModifyNumber);
            nc(10);
            Console.Write(num);
            //Anonymous Method - a method without a name

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var result = list.Find(delegate (int x){
                if (x == 5) return true;
                return false;
            });

            var res = list.Find( (int x)=> {
                if (x == 5) return true;
                return false;
            });
        }
    }

    
}
