using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Operation
{
    public class CardOperation
    {
        private static List<Entity.Card> cardList = new List<Entity.Card>
        {
            new Entity.Card{CardNumber = "1234", CardRefNumber = "5678", CustomerNumber = 1 },
            new Entity.Card{CardNumber = "3245", CardRefNumber = "2131", CustomerNumber = 1 }
        };
        private CardOperation()
        {
        }
        public static List<Entity.Card> CardList { get { return cardList; } }
    }
}
