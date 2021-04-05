using SportsMate.Business_Layer.Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Data_Structures
{
    public class SessionRole
    {
        public Account Account { get; set; }
        public MemberRole CurrentSessionRole { get; set; }
    }
}
