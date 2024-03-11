using System;

namespace HackerRank
{
    class Result
    {
        public static long aVeryBigSum(List<long> ar)
        {

            long sum = 0;
            foreach (long num in ar)
            {
                sum += num;
            }

            return sum;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt64(aTemp)).ToList();
            long result = Result.aVeryBigSum(ar);
            Console.WriteLine(result);
        }
    }

}



