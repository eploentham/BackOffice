using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingReceiptDB
    {
        TBillingReceipt tbr;
        ConnectDB conn;
        public TBillingReceiptDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbr = new TBillingReceipt();
            tbr.billing_receipt_active = "billing_receipt_active";
            tbr.billing_receipt_date_time = "billing_receipt_date_time";
            tbr.billing_receipt_number = "billing_receipt_number";
            tbr.billing_receipt_paid = "billing_receipt_paid";
            tbr.billing_receipt_staff_record = "billing_receipt_staff_record";
            tbr.f_billing_receipt_model_id = "f_billing_receipt_model_id";
            tbr.receipt_number = "receipt_number";
            tbr.t_billing_id = "t_billing_id";
            tbr.t_billing_receipt_id = "t_billing_receipt_id";
            tbr.t_patient_id = "t_patient_id";
            tbr.t_visit_id = "t_visit_id";

            tbr.pkField = "t_billing_receipt_id";
            tbr.table = "t_billing_receipt";
        }
    }
}
