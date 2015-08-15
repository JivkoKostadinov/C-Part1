using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверете число да ли е нечтно:");
            int Number;
            string Resul = Console.ReadLine();
            int.TryParse(Resul, out Number);


            if (Number % 2 == 0)
            {
                Console.WriteLine("числото е четно :" + Number);
                Console.WriteLine("False");

            }
            else
            {
                Console.WriteLine("числото е нечетно " + Number);
                Console.WriteLine("True");
            }
        }
    }
}
