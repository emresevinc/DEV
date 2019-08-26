using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Card.Entity;

namespace Card.Host.WebServices
{
    /// <summary>
    /// Summary description for CardService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CardService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Entity.Card> GetCardListByCustomerNumber(long customerNumber)
        {
            return Operation.CardOperation.CardList.Where(w => w.CustomerNumber == customerNumber)?.ToList();
        }

        [WebMethod]
        public List<Entity.Card> GetCardByCardRefNumber(string cardRefNumber)
        {
            return Operation.CardOperation.CardList.Where(w => w.CardRefNumber == cardRefNumber)?.ToList();
        }
    }
}
