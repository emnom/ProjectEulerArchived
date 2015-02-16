using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            int max = 999;
            int min = 100;
            int cutoff = 498;
            int lastPalindrom = 0;
            int lasti = 0;
            int lastj = 0;

            for (int i = max; i >= cutoff; i--)
            {
                for (int j = i; j >= min; j--)
                {
                    var product = i*j;
                    if (IsPalindrom(product) && product > lastPalindrom)
                    {
                        lastPalindrom = product;
                        lasti = i;
                        lastj = j;
                        break;
                    }   
                }
            }
            Console.WriteLine("{0} ms.", (DateTime.Now - start).TotalMilliseconds);
            Console.WriteLine("{0} x {1} = {2}", lasti, lastj, lastPalindrom);
            Console.ReadLine();
        }

        static bool IsPalindrom(int value)
        {
            var stringForm = value.ToString();
            var reverseString = "";
            for (int i = stringForm.Length ; i > 0; i--)
            {
                reverseString += stringForm[i - 1];
            }
            var reverse = int.Parse(reverseString);

            return value == reverse;
        }
    }
}
