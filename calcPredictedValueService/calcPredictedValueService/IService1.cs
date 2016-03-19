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
    [ServiceContract]
    public interface calcPredictedValueService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/calcPredictedValue?symbol={symbol}&count={count}")]        // define input format
        string calcPredValue(string symbol, int count);
    }
}
