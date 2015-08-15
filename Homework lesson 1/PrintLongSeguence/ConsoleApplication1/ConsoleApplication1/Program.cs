using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Конзолата приканва потребителя да въведе число между 2 и 100
            Console.WriteLine("Enter positive integer number n between 2 and 100");
            //Запазва числото в променлива, под името numberN(от тип цяло число(integer)), като преобразува въведеното число от потребтеля в конзолата към същия целочисле тип
            int numberN = int.Parse(Console.ReadLine());
 //Създава цикъл, който да се изпълнява докато условието в скобите след while е вярно (докато numberN е по-голямо от 2 ||(логическо или) numberN е по-голямо от 100 
            while (numberN < 2 || numberN > 100)
            {
                //Докато условието е вярно изписва на конзола TRY AGAIN
                Console.WriteLine("Try again");
                //И отново приканва потребителя да въведе число ( демек тук в този цикъл тъй като искаме числото да е межжду 2 и 100, проверяваме дали това наистина е така, ако не приканва потребителя отново да въведе друго число
                numberN = int.Parse(Console.ReadLine());
            }
            //Създава булева променлива, която приема стойност true(вярно)
            bool isPrime = true;
            //Създава променлива, под името брояч, която да е равна на 1 и която да използва в следващия цикъл
            int counter = 1;
            //Trial division
            //Създава следващия цикъл ( докато, брояча е по-малък или равен на корен квадратен от променливата numberN)
            while (counter <= Math.Sqrt(numberN))
            {
                //ако остатъкът от деленото на променливата numberN с променливата counter (в случая 1) е равно на 0(==) и (логическо и) променливата counter е по- голяма от 1
                if (numberN % counter == 0 && counter > 1)
                {
                    //ако горното твърдение е вярно изпълняваме следното -> задаваме нова стойност на променливата isPrime , която да е равна на false (лъжа)
                    isPrime = false;
                }
                //казваме на променливата counter , при всяко завъртане на цикъла да променя стойността си +1( counter = counter +1)(при всяко завъртане на цикъла докато условието след WHILE е вярно)
                counter++;
            }
            //Изписваме на конзолата ИС ЪОУР НУМБЕР ПРИМЕ + стойността на променливата isPrime
            Console.WriteLine("Is your number prime?\n{0}", isPrime);
        }
        }
    }
