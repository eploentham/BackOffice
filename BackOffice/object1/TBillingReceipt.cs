using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingReceipt:Persistent
    {
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String billing_receipt_number { get; set; }
        public String billing_receipt_date_time { get; set; }
        public String billing_receipt_active { get; set; }
        public String t_billing_id { get; set; }
        public String billing_receipt_staff_record { get; set; }
        public String f_billing_receipt_model_id { get; set; }
        public String receipt_number { get; set; }
        public String t_billing_receipt_id { get; set; }
        public String billing_receipt_paid { get; set; }
    }
}
