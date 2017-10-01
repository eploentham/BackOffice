using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingReceiptItemDB
    {
        TBillingReceiptItem tbri;
        ConnectDB conn;
        public TBillingReceiptItemDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbri = new TBillingReceiptItem();
            tbri.billing_receipt_item_active = "billing_receipt_item_active";
            tbri.billing_receipt_item_draw = "billing_receipt_item_draw";
            tbri.billing_receipt_item_hn = "billing_receipt_item_hn";
            tbri.billing_receipt_item_paid = "billing_receipt_item_paid";
            tbri.billing_receipt_item_vn = "billing_receipt_item_vn";
            tbri.b_item_id = "b_item_id";
            tbri.t_billing_invoice_item_id = "t_billing_invoice_item_id";
            tbri.t_billing_receipt_id = "t_billing_receipt_id";
            tbri.t_billing_receipt_itemcol = "t_billing_receipt_itemcol";
            tbri.t_billing_receipt_item_id = "t_billing_receipt_item_id";
            tbri.t_patient_id = "t_patient_id";
            tbri.t_payment_id = "t_payment_id";
            tbri.t_visit_id = "t_visit_id";

            tbri.pkField = "t_billing_receipt_item_id";
            tbri.table = "t_billing_receipt_item";
        }
    }
}
