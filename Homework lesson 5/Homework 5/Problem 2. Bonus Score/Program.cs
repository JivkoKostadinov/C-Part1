using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bonus_Score
{
    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if ((inputNumber <=1)|| (inputNumber >= 3))
            {
                Console.WriteLine(inputNumber * 10 );
            }
            else if ( inputNumber <=4 || inputNumber >=6)
            {
                Console.WriteLine(inputNumber * 100);
            }
            else if ( inputNumber <=7 || inputNumber >=9)
            {
                Console.WriteLine(inputNumber * 1000);
            }
            else if (inputNumber >1 || inputNumber < 9)
            {
                Console.WriteLine("Invalid score");
            }


        }
    }
}
