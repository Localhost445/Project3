// Team: Localhost:3000
// Implemented by: Alexander Schultz
// Functionality :return the price of a specific market
// Date of completion: TO BE COMPLETED

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace getMarketPricesService
{
    public class Service1 : getMarketPricesService1
    {
        public string getMarketPrice(string markSymbol)
        {
            if (markSymbol.Equals("DJIA", StringComparison.InvariantCultureIgnoreCase))
            {

            }
            if (markSymbol.Equals("NASDAQ", StringComparison.InvariantCultureIgnoreCase))
            {

            }
            if (markSymbol.Equals("SPX", StringComparison.InvariantCultureIgnoreCase))
            {

            }
            return "fillerMarketPrice";
        }
    }
}
