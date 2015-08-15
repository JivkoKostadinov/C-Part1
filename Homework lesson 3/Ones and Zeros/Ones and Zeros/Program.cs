using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ones_and_Zeros
{
class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = n * 2;
        int widthOfTheEgg = 3 * n - 1;
        int widthOfTheDrawingArea = 3 * n + 1;
        int top = n - 1;
 
        // First line
        Console.Write('.');
        Console.Write(new string('.', n));
        Console.Write(new string('*', top));
        Console.Write(new string('.', n));
        Console.WriteLine('.');
 
        // Upper body part
        int outterDots = n - 2;
        int innerDots = n + 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write('.');
            Console.Write(new string('.', outterDots - i * 2));
            Console.Write('*');
            Console.Write(new string('.', innerDots + i * 4));
            Console.Write('*');
            Console.Write(new string('.', outterDots - i * 2));
            Console.WriteLine('.');
        }
 
        // Central part
        innerDots = widthOfTheEgg - 2;
        for (int i = 0; i < height - (n + 2); i++)
        {
            Console.Write('.');
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.WriteLine('.');
        }
 
        // Lower part
        outterDots = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write('.');
            Console.Write(new string('.', outterDots + i * 2));
            Console.Write('*');
            Console.Write(new string('.', innerDots - i * 4));
            Console.Write('*');
            Console.Write(new string('.', outterDots + i * 2));
            Console.WriteLine('.');
        }
 
        // Last line
        Console.Write('.');
        Console.Write(new string('.', n));
        Console.Write(new string('*', top));
        Console.Write(new string('.', n));
        Console.WriteLine('.');
 
        // Cracks
        Console.SetCursorPosition(2, height / 2);
        for (int i = 0; i < widthOfTheEgg - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.SetCursorPosition(2, height / 2 + 1);
        for (int i = 0; i < widthOfTheEgg - 2; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.SetCursorPosition(0, height + 1);
    }


        }
    }

