/* Problem 4. Hayvan number
 */

using System;

class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        forloop(9, sum, diff);
    }

    private static void forloop(int p, int sum, int diff)
    {
        int count = 0;
        for (int d1 = 5; d1 < 10; d1++)
            for (int d2 = 5; d2 < 10; d2++)
                for (int d3 = 5; d3 < 10; d3++)
                    for (int d4 = 5; d4 < 10; d4++)
                        for (int d5 = 5; d5 < 10; d5++)
                            for (int d6 = 5; d6 < 10; d6++)
                                for (int d7 = 5; d7 < 10; d7++)
                                    for (int d8 = 5; d8 < 10; d8++)
                                        for (int d9 = 5; d9 < 10; d9++)
                                        {
                                            int sumAll = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9;
                                            if (sum == sumAll)
                                            {
                                                int left = (d1 * 100 + d2 * 10 + d3);
                                                int mid = (d4 * 100 + d5 * 10 + d6);
                                                int right = (d7 * 100 + d8 * 10 + d9);
                                                if (((mid - left) == diff && (right - mid) == diff) && (left <= mid && mid <= right))
                                                {
                                                    Console.WriteLine(left * 1000000 + mid * 1000 + right);
                                                    count++;
                                                }
                                            }
                                        }
        if (count == 0) Console.WriteLine("No");
    }
}