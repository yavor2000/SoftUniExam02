/* Problem 2. Odd or even sum
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sumOdd = 0, sumEven = 0;
        for (int i = 0; i < 2*n; i++)
        {
            if (i%2==0) sumOdd += int.Parse(Console.ReadLine());
            else sumEven += int.Parse(Console.ReadLine());
        }
        
        if (sumOdd == sumEven) Console.WriteLine("Yes, sum={0}", sumOdd);
        else Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
    }
}