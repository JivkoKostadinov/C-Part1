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
            int nominatorA = int.Parse(Console.ReadLine());
            int denominatorB = int.Parse(Console.ReadLine());
            int nominatorC = int.Parse(Console.ReadLine());
            int nominatorD = int.Parse(Console.ReadLine());

            // decimal fractionBA = Convert.ToDecimal(denominatorB) / Convert.ToDecimal(nominatorA);
            // decimal fractionDC = Convert.ToDecimal(nominatorD) / Convert.ToDecimal(nominatorC);

            decimal fractionBA = Convert.ToDecimal(nominatorA) / Convert.ToDecimal(denominatorB);
            decimal fractionDC = Convert.ToDecimal(nominatorC) / Convert.ToDecimal(nominatorD);

            decimal totalCakes = fractionBA + fractionDC;
         

            if (totalCakes >= 1)
            {
                int complateCakes = Convert.ToInt32(totalCakes);
                Console.WriteLine(complateCakes);
            }
            else
            {
                Console.WriteLine(String.Format("{0:0.0000000000000000000000}", totalCakes));
            }

            int someFraction = (denominatorB * nominatorD);
            int firstPart = Convert.ToInt32(totalCakes * someFraction);

            Console.WriteLine(firstPart.ToString() + "/" + someFraction.ToString());
        }
    }
}
