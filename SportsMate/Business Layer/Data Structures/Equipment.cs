using SportsMate.Business_Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Data_Structures
{
    public class Equipment
    {
        public EquipmentName EquipmentName { get; set; }
        public int Quantity { get; set; }

        public Sport Sport { get; set; }
        public Equipment()
        {

        }
    }
}
