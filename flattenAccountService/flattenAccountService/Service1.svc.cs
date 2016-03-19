using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace flattenAccountService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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
