using SportsMate.Business_Layer.Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Business_Objects
{
    public class SportVideoSession : SportSession
    {
        public SportVideoSession(List<SessionRole> InitialMembers, Sport sport) : base(InitialMembers, sport)
        {

        }
        public override void InitiateDiscussion()
        {
            throw new NotImplementedException();
        }
    }
}
