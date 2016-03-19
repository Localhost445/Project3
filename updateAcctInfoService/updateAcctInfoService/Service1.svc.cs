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
    public class Service1 : updateAcctInfoService1
    {
        public string changeAcctInfo(string value)
        {
            string defaultAcctID = "000-0000-000";
            string newAcctID = "";
            // if we have a valid acct id being input
            if (value[3].Equals('-') && value[8].Equals('-') && value.Length == 12)
            {
                return string.Format("New Account ID: {0}", value);
            }
            // otherwise inform user of invalid account ID input
            return "ERROR: Invalid Account ID";
        }
    }
}
