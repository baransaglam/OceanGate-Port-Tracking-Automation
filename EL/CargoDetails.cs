using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class CargoDetails
    {
        public int CargoDetailID { get; set; }
        public int ShipID { get; set; }
        public int MovementID { get; set; }
        public string CargoDescription { get; set; }
        public string CargoType { get; set; }
        public decimal Weight { get; set; }
        public int Units { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }             
        public DateTime DeliveryDate { get; set; }     
        public DateTime EstimatedDeliveryDate { get; set; }     
        public string CustomsDetails { get; set; }           
    }
}
