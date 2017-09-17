using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingDB
    {
        TBilling tb;
        ConnectDB conn;
        public TBillingDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tb = new TBilling();
            tb.t_patient_id = "t_patient_id";
            tb.t_visit_id = "t_visit_id";
            tb.billing_billing_number = "billing_billing_number";
            tb.billing_billing_date_time = "billing_billing_date_time";
            tb.billing_financial_date = "billing_financial_date";
            tb.billing_active = "billing_active";
            tb.billing_staff_cancle = "billing_staff_cancle";
            tb.billing_cancle_date_time = "billing_cancle_date_time";
            tb.billing_staff_record = "billing_staff_record";
            tb.t_billing_id = "t_billing_id";
            tb.billing_patient_share = "billing_patient_share";
            tb.billing_payer_share = "billing_payer_share";
            tb.billing_total = "billing_total";
            tb.billing_paid = "billing_paid";
            tb.billing_remain = "billing_remain";
            tb.billing_deduct = "billing_deduct";
            tb.billing_payback = "billing_payback";
        }
    }
}
