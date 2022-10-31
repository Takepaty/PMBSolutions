using PMBSolutions.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBSolutions.SubscriptionContext
{
    public class User : Base 
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
