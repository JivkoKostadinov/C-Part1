using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start and end value");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine(p);


        }
    }
}
