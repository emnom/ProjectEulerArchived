using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public static class Prime
    {
        public static List<int> GetNumberOfPrimes(int numberOfPrimes)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int current = 3;
            while (primes.Count < numberOfPrimes)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (current % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(current);
                }
                current++;
            }
            return primes;
        }
        
       public static List<int> GetPrimesBelow(int upperLimit)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int current = 3;
            while (current < upperLimit)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (current % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(current);
                    Console.WriteLine(current);
                }
                current+=2;
            }
            return primes;
        }
    }
}
