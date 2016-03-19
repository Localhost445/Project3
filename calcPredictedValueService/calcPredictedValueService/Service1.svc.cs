// Team: Localhost:3000
// Implemented by: Alexander Schultz
// Functionality: calculate the predicted value of a stock given stock symbol and share count
// Date of completion: TO BE COMPLETED

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace calcPredictedValueService
{
    public class Service1 : calcPredictedValueService1
    {
        public string calcPredValue(string symbol, int count)
        {
            return "fillercalc";
        }
    }
}
