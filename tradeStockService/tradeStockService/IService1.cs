// Team: Localhost:3000
// Implemented by: Alexander Schultz
// Functionality: trade stocks given symbol and desired share count
// Date of completion: TO BE COMPLETED

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace tradeStockService
{
    [ServiceContract]
    public interface tradeStockService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/tradeStock?symbol={symbol}&count={count}")]        // define input format
        string tradeStock(string symbol, int count);

      
    }
}
