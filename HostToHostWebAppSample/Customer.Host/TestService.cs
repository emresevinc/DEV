using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Host
{
    public class TestService
    {
        
        public static void GetCardListByCustomerNumber()
        {
            Console.Write("Select customer number: ");
            string customerNumber = Console.ReadLine();
            if (!long.TryParse(customerNumber, out long nbrCustomerNumber))
            {
                throw new Exception("Customer number does not correct format!");
            }
            CardService cardService = new CardService();
            Card[] cardList = cardService.GetCardListByCustomerNumber(nbrCustomerNumber);
            if(cardList != null)
            {
                Console.WriteLine("The customer have this card(s)! -> ");
                foreach (var item in cardList)
                {
                    Console.WriteLine(item.CardNumber);
                }
            }
        }

        public static void GetCardListByCardRefNumber()
        {
            Console.Write("Select cardRefNumber: ");
            string cardRefNumber = Console.ReadLine();
            CardService cardService = new CardService();
            Card[] cardList = cardService.GetCardByCardRefNumber(cardRefNumber);
            if (cardList != null)
            {
                Console.WriteLine("The customer have this card(s)! -> ");
                foreach (var item in cardList)
                {
                    Console.WriteLine(item.CardNumber);
                }
            }
        }


    }
}