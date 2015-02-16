using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPrime = 10000;
            int lastPrime = 0;
            long theNumber = 600851475143;
            List<int> primes = new List<int>();
            primes.Add(2);
            for (int i = 3; i < maxPrime; i++)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }

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
