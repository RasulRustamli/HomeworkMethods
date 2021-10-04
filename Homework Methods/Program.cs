using System;

namespace Homework_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cem(25));
            sum(25);
        }
        public static int cem(int a)
        {
            int sum = 0;
            for(int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void sum(int a)
        {
            int sum = 0;
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

