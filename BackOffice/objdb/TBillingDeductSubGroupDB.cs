using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingDeductSubGroupDB
    {
        TBillingDeductSubGroup tbdsg;
        ConnectDB conn;
        public TBillingDeductSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbdsg = new TBillingDeductSubGroup();
            tbdsg.billing_deduct_subgroup_baht = "billing_deduct_subgroup_baht";
            tbdsg.billing_deduct_subgroup_percent = "billing_deduct_subgroup_percent";
            tbdsg.t_billing_deduct_subgroup_id = "t_billing_deduct_subgroup_id";
            tbdsg.t_billing_id = "t_billing_id";
            tbdsg.t_billing_invoice_billing_subgroup_id = "t_billing_invoice_billing_subgroup_id";
            tbdsg.t_visit_id = "t_visit_id";

            tbdsg.pkField = "t_billing_deduct_subgroup_id";
            tbdsg.table = "t_billing_deduct_subgroup";
        }
    }
}
