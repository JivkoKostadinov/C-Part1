using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //get from console number
            //find odd nums sum
            //find even nums sum
            //compare sums
            //if even > right
            //else if even < left
            //else straight
            //print direction and bigger sum

            long randomNumber = long.Parse(Console.ReadLine());
            string convertNumber = randomNumber.ToString();
            int oddSum = 0;
            int evenSum = 0;

            foreach (var item in convertNumber)
            {
                int currentNumber = Convert.ToInt32(item.ToString());
                int checkNumber = currentNumber % 2;

                if (checkNumber == 0)
                {
                    oddSum = currentNumber + oddSum;
                }
                else
                {
                    evenSum = currentNumber + evenSum;                    
                }                
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("right " + evenSum);  
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left " + oddSum);
            }
            else if (oddSum == evenSum)
            {
                Console.WriteLine("straight " + oddSum);
            }


        }
    }
}
