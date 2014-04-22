/* Problem 1. ValleyBall
 */

using System;

class Program
{
    static void Main()
    {
        double isLeap = (Console.ReadLine() == "leap") ? 1.15 : 1.0;
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        double answer = 0;

        answer = 2.0 * holidays / 3.0;
        answer += ((3.0 / 4.0) * (48.0 - hometown));
        answer += hometown * 1;
        answer *= isLeap;

        Console.WriteLine(Math.Truncate(answer));
    }
}