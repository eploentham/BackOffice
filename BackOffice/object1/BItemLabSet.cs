using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemLabSet:Persistent
    {
        public String item_lab_set_number { get; set; }
        public String b_item_id { get; set; }
        public String item_lab_set_description { get; set; }
        public String b_item_lab_set_id { get; set; }
    }
}
