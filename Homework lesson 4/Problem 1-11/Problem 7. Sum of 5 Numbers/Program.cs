using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double sum = 0;
            Console.WriteLine("Please, enter 5 numbers, all in the same line, separated by only one interval ! ");
            string stringOfWords = Console.ReadLine();
            string[] words = stringOfWords.Split(' ');
            foreach (string word in words)
            {
                number = double.Parse(word);
                sum = sum + number;
            }
            Console.WriteLine("The sum of the entered 5 numbers is {0}.", sum);


        }
    }
}
