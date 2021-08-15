using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestFromRight
{
    class LeetCode2
    {
        static void nextGreatest(int[] arr)
        {
            int size = arr.Length;

            int max_from_right = arr[size - 1];

            arr[size - 1] = -1;

            for (int i = size - 2; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = max_from_right;
                if (temp > max_from_right)
                    max_from_right = temp;

            }

            foreach (var x in arr)
            {
                Console.Write(x + ", ");
            }
            Console.ReadLine();



        }
        static void Main(string[] args)
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            nextGreatest(arr);
        }
    }
}
