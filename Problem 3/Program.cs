using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastPrime = 0;
            long theNumber = 600851475143;
            var primes = Prime.GetNumberOfPrimes(1000);

            var found = false;
            while (true)
            {
                for (int i = 0; i < primes.Count; i++)
                {
                    lastPrime = primes[i];
                    while (true)
                    {
                        if (theNumber%lastPrime == 0)
                        {
                            theNumber = theNumber/lastPrime;
                            if (theNumber == 1)
                            {
                                found = true;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                if (found)
                    break;
            }

            Console.WriteLine(lastPrime);
            Console.ReadLine();
        }


    }
}
