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
    public class Service1 : tradeStockService1
    {
        public string tradeStock(string symbol, int count)
        {
            return "fillertrade";
        }
    }
}
