using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAdress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine("{0}",companyName);
            Console.WriteLine("Adress: {0}",companyAdress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            Console.WriteLine("Fax: {0}",faxNumber,null);
            Console.WriteLine("webSite site:{0}",webSite);
            Console.WriteLine("Manager:{0} {1} (age:{2} , tel :{3})",firstName,lastName,managerAge,managerPhone);




        }
    }
}
