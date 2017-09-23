using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingDeductSubGroup:Persistent
    {
        public String t_billing_id { get; set; }
        public String t_visit_id { get; set; }
        public String t_billing_invoice_billing_subgroup_id { get; set; }
        public String billing_deduct_subgroup_percent { get; set; }
        public String billing_deduct_subgroup_baht { get; set; }
        public String t_billing_deduct_subgroup_id { get; set; }
    }
}
