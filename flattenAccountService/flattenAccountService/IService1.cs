// Team: Localhost:3000
// Implemented by: Alexander Schultz
// Functionality: close out account after being verified
// Date of completion: TO BE COMPLETED

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace flattenAccountService
{
    [ServiceContract]
    public interface flattenAcctService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/flattenAccount?acctIDin={acctIDin}")]        // define input format
        string flattenAcct(string acctIDin);
    }
}
