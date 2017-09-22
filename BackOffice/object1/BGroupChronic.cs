using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BGroupChronic:Persistent
    {
        public String group_chronic_number { get; set; }
        public String group_chronic_description_th { get; set; }
        public String group_chronic_description_en { get; set; }
        public String group_chronic_active { get; set; }
        public String b_group_chronic_id { get; set; }
    }
}
