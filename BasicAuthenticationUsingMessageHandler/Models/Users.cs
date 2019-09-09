using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationUsingMessageHandler.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string UserEmailID { get; set; }
        public string UserRoles { get; set; }
    }
}