using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingReceiptSubGroupDB
    {
        TBillingReceiptBillingSubGroup tbrbsg;
        ConnectDB conn;
        public TBillingReceiptSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbrbsg = new TBillingReceiptBillingSubGroup();
            tbrbsg.billing_receipt_billing_subgroup_active = "billing_receipt_billing_subgroup_active";
            tbrbsg.billing_receipt_billing_subgroup_draw = "billing_receipt_billing_subgroup_draw";
            tbrbsg.billing_receipt_billing_subgroup_paid = "billing_receipt_billing_subgroup_paid";
            tbrbsg.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
            tbrbsg.t_billing_invoice_billing_subgroup_id = "t_billing_invoice_billing_subgroup_id";
            tbrbsg.t_billing_receipt_billing_subgroupcol = "t_billing_receipt_billing_subgroupcol";
            tbrbsg.t_billing_receipt_billing_subgroup_id = "t_billing_receipt_billing_subgroup_id";
            tbrbsg.t_billing_receipt_id = "t_billing_receipt_id";
            tbrbsg.t_patient_id = "t_patient_id";
            tbrbsg.t_visit_id = "t_visit_id";

            tbrbsg.pkField = "t_billing_receipt_billing_subgroup_id";
            tbrbsg.table = "t_billing_receipt_billing_subgroup";
        }
    }
}
