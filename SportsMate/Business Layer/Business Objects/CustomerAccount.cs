using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Business_Objects
{
    public class CustomerAccount : Account
    {
        public CustomerAccount(string FirstName, string LastName, string Birthday) : base(FirstName,LastName, Birthday)
        {

        }
    }
}
