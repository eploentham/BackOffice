using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TVisitPaymentDB
    {
        TVisitPayment tvp;
        ConnectDB conn;
        public TVisitPaymentDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tvp = new TVisitPayment();
            tvp.b_contract_id = "b_contract_id";
            tvp.b_contract_plans_id = "b_contract_plans_id";
            tvp.b_deduct_id = "b_deduct_id";
            tvp.primary_symptom = "primary_symptom";
            tvp.status_payment = "status_payment";
            tvp.t_visit_id = "t_visit_id";
            tvp.t_visit_payment_id = "t_visit_payment_id";
            tvp.visit_payment_active = "visit_payment_active";
            tvp.visit_payment_cancel_date_time = "visit_payment_cancel_date_time";
            tvp.visit_payment_card_expire_date = "visit_payment_card_expire_date";
            tvp.visit_payment_card_issue_date = "visit_payment_card_issue_date";
            tvp.visit_payment_card_number = "visit_payment_card_number";
            tvp.visit_payment_main_hospital = "visit_payment_main_hospital";
            tvp.visit_payment_money_limit = "visit_payment_money_limit";
            tvp.visit_payment_priority = "visit_payment_priority";
            tvp.visit_payment_record_date_time = "visit_payment_record_date_time";
            tvp.visit_payment_staff_cancel = "visit_payment_staff_cancel";
            tvp.visit_payment_staff_record = "visit_payment_staff_record";
            tvp.visit_payment_staff_update = "visit_payment_staff_update";
            tvp.visit_payment_sub_hospital = "visit_payment_sub_hospital";
            tvp.visit_payment_update_date_time = "visit_payment_update_date_time";
            tvp.visit_payment_used_money_limit = "visit_payment_used_money_limit";

            tvp.pkField = "t_visit_payment_id";
            tvp.table = "t_visit_payment";
        }
    }
}
