﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object combination = firstWord + " " + secondWord;
            string a = (string)combination;
            Console.WriteLine(a);
        }
    }
}
