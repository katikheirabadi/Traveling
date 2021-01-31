using System;
using System.Collections.Generic;
using System.Text;

namespace Travelling.Core.Models
{
    public class UserLogin
    {
        public int id { get; set; }
        public string Token { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int userid { get; set; }
        public User user { get; set; }
    }
}
