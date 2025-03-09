using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Reports
    {
        public int ReportID { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public DateTime CreatedAt{ get; set; }
    }
}
