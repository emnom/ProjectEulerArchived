using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 4000000;
            int sum = 2;
            int first = 1;
            int second = 2;
            int fibonacci = 0;
            while(true)
            {
                fibonacci = first + second;
                if (fibonacci >= max)
                    break;
                if (fibonacci % 2 == 0)
                    sum += fibonacci;

                first = second;
                second = fibonacci;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
