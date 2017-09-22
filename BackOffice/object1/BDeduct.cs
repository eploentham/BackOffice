using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BDeduct:Persistent
    {
        public String deduct_number { get; set; }
        public String deduct_description { get; set; }
        public String deduct_method { get; set; }
        public String b_deduct_id { get; set; }
        public String Active { get; set; }
    }
}
