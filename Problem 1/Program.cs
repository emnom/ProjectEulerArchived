using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int counter = 1; counter < 1000; counter++)
            {
                if (counter%3 == 0 || counter%5 == 0)
                {
                    sum += counter;
                    Console.WriteLine(counter);
                }
            }

            Console.WriteLine("Sonuc: " + sum);
            Console.ReadLine();
        }
    }
}
