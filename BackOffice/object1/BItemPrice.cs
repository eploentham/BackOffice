using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemPrice:Persistent
    {
        public String item_price_number { get; set; }
        public String b_item_id { get; set; }
        public String item_price_active_date { get; set; }
        public String item_price_cost { get; set; }
        public String b_item_price_id { get; set; }
        public String item_price { get; set; }
        public String item_price_opd { get; set; }
        public String item_price_ipd { get; set; }
        public String date_start { get; set; }
        public String date_end { get; set; }
        public String Active { get; set; }
    }
}
