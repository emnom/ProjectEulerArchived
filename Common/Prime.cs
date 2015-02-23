using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public static class Prime
    {
        public static List<int> GetPrimes(int numberOfPrimes)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int count = 3;
            while (primes.Count < numberOfPrimes)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (count % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(count);
                }
                count++;
            }
            return primes;
        }
    }
}
