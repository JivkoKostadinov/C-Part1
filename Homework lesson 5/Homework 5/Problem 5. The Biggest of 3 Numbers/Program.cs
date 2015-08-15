using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.The_Biggest_of_3_Numbers
{
    class Program
    {
        static void Main()
        {
             double a = double.Parse(Console.ReadLine());
             double b = double.Parse(Console.ReadLine());
             double c = double.Parse(Console.ReadLine());

             if (a > b && a > c && a == 0)
             {
                 Console.WriteLine(a);
             }
             else if (b > a && b > c && b == 0)
             {
                 Console.WriteLine(b);
             }
             else 
             {
                 Console.WriteLine(c);
             }

          
            }
        }
    }

        