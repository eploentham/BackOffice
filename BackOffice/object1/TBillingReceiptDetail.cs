using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingReceiptDetail:Persistent
    {
        public String t_billing_receipt_id { get; set; }
        public String t_patient_id { get; set; }
        public String f_billing_receipt_type_id { get; set; }
        public String b_billing_receipt_creditor_id { get; set; }
        public String billing_receipt_detail_creditor_code { get; set; }
        public String billing_receipt_detail_creditor_name { get; set; }
        public String billing_receipt_detail_credit_number { get; set; }
        public String billing_receipt_detail_remark { get; set; }
        public String billing_receipt_detail_paid { get; set; }
        public String t_billing_receipt_detail_id { get; set; }
    }
}
