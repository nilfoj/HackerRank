using System;


namespace HackerRank
{

    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {

            int somaDiagonal01 = 0;
            int somaDiagonal02 = 0;

            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                somaDiagonal01 += arr[i][i];
                somaDiagonal02 += arr[i][n - 1 -i];
            }

            return Math.Abs(somaDiagonal01 - somaDiagonal02);
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp =>
                Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);
         
        }
    }
}