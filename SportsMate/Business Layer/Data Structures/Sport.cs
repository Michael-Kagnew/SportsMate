using SportsMate.Business_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Data_Structures
{
    public class Sport
    {
        public SportName Name { get; set; }

        public List<Equipment> RequiredEquipments { get; set; }


    }
}
