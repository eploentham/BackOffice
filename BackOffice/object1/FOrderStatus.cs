using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class FOrderStatus:Persistent
    {
        public String order_status_description { get; set; }
        public String f_order_status_id { get; set; }
    }
}
