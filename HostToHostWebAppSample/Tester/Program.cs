using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1) GetCardListByCustomerNumber");
            Console.WriteLine("2) GetCardListByCardRefNumber");
            Console.Write("Select service:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Customer.Host.TestService.GetCardListByCustomerNumber();
                    break;
                case "2":
                    Customer.Host.TestService.GetCardListByCardRefNumber();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

    }
}
