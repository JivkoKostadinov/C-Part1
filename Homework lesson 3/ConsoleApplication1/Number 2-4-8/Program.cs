using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_2_4_8
{
    class Program
    {
        static void Main()
        {
            //three numbers A,B,C
            //B is secreed code
            //•	If the code is 2 – find the remainder after A is divided by C. Example: A = 5, C = 3, A % C = 2.
            //•	If the code is 4 – find the sum of A and C. Example: A = 5, C = 3, A + C = 8.
            //•	If the code is 8 – find the product of A and C. Example: A = 5, C = 3, A * C = 15

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int codeNumber2 = firstNumber % thirdNumber;
            int codenumber4 = firstNumber + thirdNumber;
            int codeNumber8 = firstNumber * thirdNumber;

            int R = 0;
            int number = R / 4;
            int finallNumber = 1;
            if (R % 4 == 0)
                  {
                      Console.WriteLine(finallNumber);
                  }
            else
                 {
                     Console.WriteLine(number);
                 }
            if (secondNumber == 2)
                 {
                     R = codeNumber2;
                     Console.WriteLine(codeNumber2);
                 }
            else if (secondNumber == 4)
                 {
                
                     R = codenumber4;
                     Console.WriteLine(codenumber4);
                 }
            else if (secondNumber == 8)
                 {
                     R = codeNumber8;
                     Console.WriteLine(codeNumber8);
                 }
          
           
         


          





        }
    }
}
