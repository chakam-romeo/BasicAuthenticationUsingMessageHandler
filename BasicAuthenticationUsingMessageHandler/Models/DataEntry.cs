using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationUsingMessageHandler.Models
{
    public class DataEntry
    {
        public int CodeRequest { get; set; }
        public string MessageResult { get; set; }
        public Users user { get; set; }

    }
}