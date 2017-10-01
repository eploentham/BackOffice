using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingReceiptDetailDB
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
        private TBillingReceiptDetail setData(TBillingReceiptDetail p, DataTable dt)
        {
            p.billing_receipt_detail_creditor_code = dt.Rows[0][tbrd.billing_receipt_detail_creditor_code].ToString();
            p.billing_receipt_detail_creditor_name = dt.Rows[0][tbrd.billing_receipt_detail_creditor_name].ToString();
            p.billing_receipt_detail_credit_number = dt.Rows[0][tbrd.billing_receipt_detail_credit_number].ToString();
            p.billing_receipt_detail_paid = dt.Rows[0][tbrd.billing_receipt_detail_paid].ToString();
            p.billing_receipt_detail_remark = dt.Rows[0][tbrd.billing_receipt_detail_remark].ToString();
            p.b_billing_receipt_creditor_id = dt.Rows[0][tbrd.b_billing_receipt_creditor_id].ToString();
            p.f_billing_receipt_type_id = dt.Rows[0][tbrd.f_billing_receipt_type_id].ToString();
            p.t_billing_receipt_detail_id = dt.Rows[0][tbrd.t_billing_receipt_detail_id].ToString();
            p.t_billing_receipt_id = dt.Rows[0][tbrd.t_billing_receipt_id].ToString();
            p.t_patient_id = dt.Rows[0][tbrd.t_patient_id].ToString();

            return p;
        }
    }
}
