using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = Prime.GetPrimesBelow(2000000);
            long total = 0;
            for (int i = 0; i < primes.Count; i++)
            {
                total += primes[i];
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
