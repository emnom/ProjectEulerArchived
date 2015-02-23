using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = Prime.GetPrimes(10001);
            Console.WriteLine(primes[primes.Count - 1]);
            Console.ReadLine();
        }
    }
}
