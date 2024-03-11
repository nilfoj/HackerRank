using System;

namespace HackerRank
{
    class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice += 1;
                }
                else if (a[i] < b[i])
                {
                    bob += 1;
                }
            }

            return new List<int> { alice, bob };
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
