// Team: Localhost:3000
// Implemented by: Alexander Schultz
// Functionality: change and return new account info
// Date of completion: TO BE COMPLETED

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace updateAcctInfoService
{
    [ServiceContract]
    public interface updateAcctInfoService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/returnCountString?value={input}")] // define user input
        string changeAcctInfo(string value);
    }
}
