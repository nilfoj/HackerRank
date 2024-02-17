using System;

namespace HackerRank
{
    class SMFirst
    {

        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {

            Console.Clear();
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            
            Console.Write(sum);
        }
    }
}