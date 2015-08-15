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

            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            bool isDivided = (number % 5 == 0) && (number % 7 == 0);

            Console.WriteLine("This number can be divided by 7 and 5 = " + isDivided);
        }
    }
}
