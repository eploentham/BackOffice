using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BNcdGroup:Persistent
    {
        public String ncd_group_number { get; set; }
        public String ncd_group_description { get; set; }
        public String ncd_group_pattern { get; set; }
        public String ncd_group_value { get; set; }
        public String b_group_chronic_id { get; set; }
        public String b_ncd_group_id { get; set; }
    }
}
