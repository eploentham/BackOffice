using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingReceiptItem:Persistent
    {
        public String t_billing_receipt_id { get; set; }
        public String t_billing_invoice_item_id { get; set; }
        public String b_item_id { get; set; }
        public String billing_receipt_item_draw { get; set; }
        public String billing_receipt_item_active { get; set; }
        public String t_payment_id { get; set; }
        public String billing_receipt_item_vn { get; set; }
        public String t_visit_id { get; set; }
        public String billing_receipt_item_hn { get; set; }
        public String t_patient_id { get; set; }
        public String t_billing_receipt_itemcol { get; set; }
        public String t_billing_receipt_item_id { get; set; }
        public String billing_receipt_item_paid { get; set; }
    }
}
