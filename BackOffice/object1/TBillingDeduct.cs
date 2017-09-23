using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingDeduct:Persistent
    {
        public String t_billing_id { get; set; }
        public String billing_deduct_baht { get; set; }
        public String billing_deduct_remark { get; set; }
        public String t_billing_deduct_id { get; set; }
    }
}
