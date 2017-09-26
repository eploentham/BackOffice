using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingReceiptDetailDB
    {
        TBillingReceiptDetail tbrd;
        ConnectDB conn;
        public TBillingReceiptDetailDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbrd = new TBillingReceiptDetail();
            tbrd.billing_receipt_detail_creditor_code = "billing_receipt_detail_creditor_code";
            tbrd.billing_receipt_detail_creditor_name = "billing_receipt_detail_creditor_name";
            tbrd.billing_receipt_detail_credit_number = "billing_receipt_detail_credit_number";
            tbrd.billing_receipt_detail_paid = "billing_receipt_detail_paid";
            tbrd.billing_receipt_detail_remark = "billing_receipt_detail_remark";
            tbrd.b_billing_receipt_creditor_id = "b_billing_receipt_creditor_id";
            tbrd.f_billing_receipt_type_id = "f_billing_receipt_type_id";
            tbrd.t_billing_receipt_detail_id = "t_billing_receipt_detail_id";
            tbrd.t_billing_receipt_id = "t_billing_receipt_id";
            tbrd.t_patient_id = "t_patient_id";

            tbrd.pkField = "t_billing_receipt_detail_id";
            tbrd.table = "t_billing_receipt_detail";
        }
    }
}
