using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._01_Arrays_and_strings
{
    public static class CheckStringRotation
    {
        // Checks if a string is a rotation of the other
        public static void Run()
        {
            Console.WriteLine(IsRotate("waterbottle", "erbottlewat"));
        }

        private static bool IsRotate(string s1, string s2)
        {
            if (s1.Length == s2.Length && s1.Length > 0)
            {
                string joinedWords = s1 + s1;
                return joinedWords.Contains(s2);
            }
            return false;
        }
    }
}
