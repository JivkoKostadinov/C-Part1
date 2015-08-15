using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Width = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height = ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (2 * width) + (2 * height);
            double area = width * height;

            Console.WriteLine("Perimeter of rectangle is " + perimeter);
            Console.WriteLine("Area of rectangle is " + area);

        }
    }
}
