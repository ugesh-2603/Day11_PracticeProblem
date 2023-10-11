using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_PracticeProblem
{
    internal class Remaining_Chaptercs
    {
        public static void RemainingChepters()
        {
            int N = 4;
            int[] arr = { 1, 4, 5, 7, 9, 16, 17, 26 };
            int K = 3;
            int kPosition = 0;
            for (int i = 0; i < arr.Length; i = i + 2)
            {
                if (arr[i] <= K && K <= arr[i + 1])
                {
                    kPosition = (i / 2) + 1;
                }
            }
            Console.WriteLine(N - kPosition + 1);
        }
    }
}
