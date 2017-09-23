using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingInvoiceItem:Persistent
    {
        public String t_billing_invoice_id { get; set; }
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String t_order_item_id { get; set; }
        public String b_item_id { get; set; }
        public String t_payment_id { get; set; }
        public String billing_invoice_item_draw { get; set; }
        public String billing_invoice_item_active { get; set; }
        public String b_item_billing_subgroup_id { get; set; }
        public String billing_invoice_item_patient_share_ceil { get; set; }
        public String billing_invoice_item_payer_share_ceil { get; set; }
        public String billing_invoice_item_payer_status { get; set; }
        public String t_billing_invoice_item_id { get; set; }
        public String billing_invoice_item_patient_share { get; set; }
        public String billing_invoice_item_payer_share { get; set; }
        public String billing_invoice_item_total { get; set; }
        public String billing_invoice_item_payer_orginal { get; set; }
    }
}
