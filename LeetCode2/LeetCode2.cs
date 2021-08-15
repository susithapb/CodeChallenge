using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2
{
    class LeetCode2
    {
        public static int LengthOfLastWord(string s)
        {

            if (s.IndexOf(" ") == -1)
                return s.Length;
            else
            {
                var lastWord = s.Trim().Split(' ').Last();
                return lastWord.Length;
            }

        }

        static void Main(string[] args)
        {
            string s = " aaa ";

            int result = LengthOfLastWord(s);
            Console.WriteLine("Length of Last Word  = {0}", result);
            Console.Read();

        }
    }
}
