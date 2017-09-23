using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemDrupUOM:Persistent
    {
        public String item_drug_uom_number { get; set; }
        public String item_drug_uom_description { get; set; }
        public String item_drug_uom_active { get; set; }
        public String b_item_drug_uom_id { get; set; }
    }
}
