using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                if (i % 3!=0 &&  i % 7 !=0)
                {

                    Console.Write("{0} ",i);

                }

                
            }




        }
    }
}
