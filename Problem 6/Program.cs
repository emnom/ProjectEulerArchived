using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumOfSquares = 0;
            long squareOfSums = 0;

            for (int i = 1; i < 101; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }
            squareOfSums = squareOfSums * squareOfSums;

            Console.WriteLine(squareOfSums - sumOfSquares);
            Console.ReadLine();
        }
    }
}
