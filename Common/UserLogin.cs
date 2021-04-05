using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Order_for_digital_printing_of_Photos.Common
{
    [Serializable]
    public class UserLogin
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userPwd { get; set; }
        public int status { get; set; }
        public string role { get; set; }
        public string name { get; set; }
    }
}