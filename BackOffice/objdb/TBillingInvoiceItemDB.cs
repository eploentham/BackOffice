using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingInvoiceItemDB
    {
        TBillingInvoiceItem tbii;
        ConnectDB conn;
        public TBillingInvoiceItemDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbii = new TBillingInvoiceItem();
            tbii.billing_invoice_item_active = "billing_invoice_item_active";
            tbii.billing_invoice_item_draw = "billing_invoice_item_draw";
            tbii.billing_invoice_item_patient_share = "billing_invoice_item_patient_share";
            tbii.billing_invoice_item_patient_share_ceil = "billing_invoice_item_patient_share_ceil";
            tbii.billing_invoice_item_payer_orginal = "billing_invoice_item_payer_orginal";
            tbii.billing_invoice_item_payer_share = "billing_invoice_item_payer_share";
            tbii.billing_invoice_item_payer_share_ceil = "billing_invoice_item_payer_share_ceil";
            tbii.billing_invoice_item_payer_status = "billing_invoice_item_payer_status";
            tbii.billing_invoice_item_total = "billing_invoice_item_total";
            tbii.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
            tbii.b_item_id = "b_item_id";
            tbii.t_billing_invoice_id = "t_billing_invoice_id";
            tbii.t_billing_invoice_item_id = "t_billing_invoice_item_id";
            tbii.t_order_item_id = "t_order_item_id";
            tbii.t_patient_id = "t_patient_id";
            tbii.t_payment_id = "t_payment_id";
            tbii.t_visit_id = "t_visit_id";

            tbii.pkField = "t_billing_invoice_item_id";
            tbii.table = "t_billing_invoice_item";
        }
    }
}
