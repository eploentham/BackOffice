using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BVisitWard:Persistent
    {
        public String visit_ward_number { get; set; }
        public String visit_ward_description { get; set; }
        public String visit_ward_active { get; set; }
        public String visit_ward_color { get; set; }
        public String b_visit_ward_id { get; set; }
    }
}
