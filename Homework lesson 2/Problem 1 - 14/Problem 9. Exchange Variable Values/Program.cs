using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;
            Console.WriteLine("Before exchange \u2192 number1={0}\tnumber2={1}", number1, number2);
            int number3;
            number3 = number1;
            number1 = number2;
            number2 = number3;
            Console.WriteLine("After exchange \u2192 number1={0}\tnumber2={1}", number1, number2);
        }
    }
}
