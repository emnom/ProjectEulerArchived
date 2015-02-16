using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 21;
            while (true)
            {
                var found = true;
                for (int i = 11; i < 21; i++)
                {
                    if (number%i != 0)
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine(number);
                    break;
                }

                number++;
            }

            Console.ReadLine();
        }
    }
}
