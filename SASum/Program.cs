using System;

namespace HackerRank
{
    class Result
    {
        public static int simpleArraySum(List<int> ar)
        {
     
            int sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }
            
            return sum;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.simpleArraySum(ar);

            Console.WriteLine(result);
        }
    }
}