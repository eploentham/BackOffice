using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingInvoiceSubGroupDB
    {
        TBillingInvoiceBillingSubGroup tbibsg;
        ConnectDB conn;
        public TBillingInvoiceSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbibsg = new TBillingInvoiceBillingSubGroup();
            tbibsg.billing_invoice_billing_subgroup_active = "billing_invoice_billing_subgroup_active";
            tbibsg.billing_invoice_billing_subgroup_draw = "billing_invoice_billing_subgroup_draw";
            tbibsg.billing_invoice_billing_subgroup_patient_share = "billing_invoice_billing_subgroup_patient_share";
            tbibsg.billing_invoice_billing_subgroup_patient_share_ceil = "billing_invoice_billing_subgroup_patient_share_ceil";
            tbibsg.billing_invoice_billing_subgroup_payer_share = "billing_invoice_billing_subgroup_payer_share";
            tbibsg.billing_invoice_billing_subgroup_payer_share_ceil = "billing_invoice_billing_subgroup_payer_share_ceil";
            tbibsg.billing_invoice_billing_subgroup_total = "billing_invoice_billing_subgroup_total";
            tbibsg.billing_invoice_item_payer_orginal = "billing_invoice_item_payer_orginal";
            tbibsg.billing_invoice_item_payer_status = "billing_invoice_item_payer_status";
            tbibsg.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
            tbibsg.b_item_subgroup_id = "b_item_subgroup_id";
            tbibsg.t_billing_id = "t_billing_id";
            tbibsg.t_billing_invoice_billing_subgroup_id = "t_billing_invoice_billing_subgroup_id";
            tbibsg.t_billing_invoice_id = "t_billing_invoice_id";
            tbibsg.t_patient_id = "t_patient_id";
            tbibsg.t_payment_id = "t_payment_id";
            tbibsg.t_visit_id = "t_visit_id";

            tbibsg.pkField = "t_billing_invoice_billing_subgroup_id";
            tbibsg.table = "t_billing_invoice_billing_subgroup";
        }
    }
}
