using System;

namespace HackerRank
{
    class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {

            List<int> result = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    ;
                }

            }

            return result;

        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            foreach (int i in result) 
            { 
                Console.WriteLine(i + " ");
            }





        }
    }
}