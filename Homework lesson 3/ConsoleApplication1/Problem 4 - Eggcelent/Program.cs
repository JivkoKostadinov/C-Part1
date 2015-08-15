using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;//int.Parse(Console.ReadLine());
            int heigh = n * 2;
            int width = 3 * (n + 1);
           // string firstChar = '.';
           // string secondChar = '*';
           // string thirdChar = "@";
  

           //top of the egg
            int topEgg = n + 1;

            Console.Write(new string('.', topEgg));
            Console.Write(new string('*', n - 1));
            Console.WriteLine(new string('.', topEgg));

            //second order
            int nextDots = topEgg - 1;
            



            for (int i = 0; i <= topEgg; i++)
            {
                topEgg--;
                topEgg--;
                Console.Write(new string('.', topEgg ));
                Console.WriteLine('*');

                topEgg++;
         




            }






        }
    }
}
