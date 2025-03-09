using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ShipMovementDTO
    {
        public int MovementID { get; set; }
        public string ShipName { get; set; }  // Ships tablosundan gelen isim
        public string PortName { get; set; }  // Ports tablosundan gelen isim
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
    }
}
