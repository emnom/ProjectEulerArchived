using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 333; i++)
            {
                for (int j = i+1; j < 500; j++)
                {
                    var k = 1000 - (i + j);
                    if(i*i+j*j == k*k)
                    {
                        Console.WriteLine("i:{0}, j:{1}, k:{2}, product:{3}", i, j, k, i*j*k);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
