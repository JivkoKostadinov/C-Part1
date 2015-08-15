using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            decimal sum = 0.00m;
            decimal number = decimal.MinValue;
            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);



        }
    }
}
