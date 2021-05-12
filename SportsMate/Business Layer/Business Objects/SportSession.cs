using SportsMate.Business_Layer.Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Business_Objects

{
    public abstract class SportSession
    {
        private List<Account> SessionMembers { get; set; }

        private Map Map { get; set; }

        public Sport Sport { get; set; }

        public SportSession(List<Account> InitialMembers, Sport Sport)
        {
            this.SessionMembers = InitialMembers;
        }

        public abstract void InitiateDiscussion();
        

        // TDOO finish this one to check all the accounts equipments, if they match with the sports
        public Boolean GetCurrentFulfilledEquipment()
        {
            throw new Exception();
        }
    }
}
