using System;

namespace Algorithms
{

    class Program
    {
        static int findMaximum(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c || a == c)
                {
                    return a;
                }
            }

            if (b > c)
            {
                if (b > a || a == b)
                {
                    return b;
                }
            }

            return c;
        }

        static int findMaximum2(int a, int b, int c)
        {
            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            return max;
        }


        static int findMaximum3(params int[] list)
        {
            int max = list[0];
            foreach (int num in list){
               max = num > max ? num : max;
            }
           return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(findMaximum3(1, 2, 3, 5, 8, 2, 0, 0, 13, 2, 22, 3, 43, 1, 100, 0, 0, 0, 14));
            Console.WriteLine(findMaximum2(8, 8, 1));
            Console.WriteLine(findMaximum2(3, 2, 3));
            Console.WriteLine(findMaximum2(1, 1, 9));
            Console.WriteLine(findMaximum2(1, 9, 9));
        }
    }
}