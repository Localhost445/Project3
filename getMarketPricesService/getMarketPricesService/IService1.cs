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
    [ServiceContract]
    public interface getMarketPricesService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/getMarketPrice?markSymbol={markSymbol}")]        // define input format
        string getMarketPrice(string markSymbol);
    }
}
