using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBilling:Persistent
    {
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String billing_billing_number { get; set; }
        public String billing_billing_date_time { get; set; }
        public String billing_financial_date { get; set; }
        public String Active { get; set; }
        public String billing_staff_cancle { get; set; }
        public String billing_cancle_date_time { get; set; }
        public String billing_staff_record { get; set; }
        public String t_billing_id { get; set; }
        public String billing_patient_share { get; set; }
        public String billing_payer_share { get; set; }
        public String billing_total { get; set; }
        public String billing_paid { get; set; }
        public String billing_remain { get; set; }
        public String billing_deduct { get; set; }
        public String billing_payback { get; set; }
        
    }
}
