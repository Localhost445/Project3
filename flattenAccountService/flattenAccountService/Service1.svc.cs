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
    public class Service1 : flattenAcctService1
    {
        public string flattenAcct(string value)
        {
            string output = "";
            // validate input string first to verify security of account flattening procedure
            if (!value[3].Equals('-') || !value[8].Equals('-')|| value.Length != 12)
            {
                output = "ERROR: The Account ID entered is not valid"; // invalid account ID entered, do not flatten account
            }
            else
            {
                output = string.Format("Account: {0} has been deactivated and all assets have been sold", value); // valid account ID entered, flatten account
            }
            return output;
        }
    }
}
