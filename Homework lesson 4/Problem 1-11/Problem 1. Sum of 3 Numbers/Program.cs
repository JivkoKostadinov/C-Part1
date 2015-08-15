using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sum_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOne = decimal.Parse(Console.ReadLine());
            decimal numberTwo = decimal.Parse(Console.ReadLine());
            decimal numberThree = decimal.Parse(Console.ReadLine());

            decimal sum = numberOne + numberTwo + numberThree;

            Console.WriteLine(sum);

        }
    }
}
