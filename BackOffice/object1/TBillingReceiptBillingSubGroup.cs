using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingReceiptBillingSubGroup:Persistent
    {
        public String t_billing_receipt_id { get; set; }
        public String t_billing_invoice_billing_subgroup_id { get; set; }
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String b_item_billing_subgroup_id { get; set; }
        public String billing_receipt_billing_subgroup_draw { get; set; }
        public String billing_receipt_billing_subgroup_active { get; set; }
        public String t_billing_receipt_billing_subgroupcol { get; set; }
        public String t_billing_receipt_billing_subgroup_id { get; set; }
        public String billing_receipt_billing_subgroup_paid { get; set; }
    }
}
