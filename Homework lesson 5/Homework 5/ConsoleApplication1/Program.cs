using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            decimal numberOne = decimal.Parse(Console.ReadLine());
            decimal numberTwo = decimal.Parse(Console.ReadLine());

            
            if (numberOne > numberTwo)
            {
                Console.WriteLine("{0} {1}",numberTwo,numberOne);
            }
            else 
            {
                Console.WriteLine("{0} {1}", numberOne,numberTwo);
            }

        }
    }
}
