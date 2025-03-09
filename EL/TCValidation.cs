using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class TCValidation
    {
        public int ValidationID { get; set; }
        public int UserID { get; set; }
        public bool ValidationStatus { get; set; }
        public DateTime ValidatedAt{ get; set; }
    }
}
