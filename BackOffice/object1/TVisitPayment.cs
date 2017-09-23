using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TVisitPayment:Persistent
    {
        public String t_visit_id { get; set; }
        public String b_contract_plans_id { get; set; }
        public String b_contract_id { get; set; }
        public String visit_payment_card_number { get; set; }
        public String visit_payment_card_issue_date { get; set; }
        public String visit_payment_card_expire_date { get; set; }
        public String visit_payment_main_hospital { get; set; }
        public String visit_payment_sub_hospital { get; set; }
        public String visit_payment_priority { get; set; }
        public String visit_payment_money_limit { get; set; }
        public String visit_payment_used_money_limit { get; set; }
        public String visit_payment_staff_record { get; set; }
        public String visit_payment_record_date_time { get; set; }
        public String visit_payment_staff_update { get; set; }
        public String visit_payment_update_date_time { get; set; }
        public String visit_payment_staff_cancel { get; set; }
        public String visit_payment_cancel_date_time { get; set; }
        public String visit_payment_active { get; set; }
        public String status_payment { get; set; }
        public String b_deduct_id { get; set; }
        public String primary_symptom { get; set; }
        public String t_visit_payment_id { get; set; }
    }
}
