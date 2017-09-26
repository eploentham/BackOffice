using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingDeductDB
    {
        TBillingDeduct tbd;
        ConnectDB conn;
        public TBillingDeductDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbd = new TBillingDeduct();
            tbd.billing_deduct_baht = "billing_deduct_baht";
            tbd.billing_deduct_remark = "billing_deduct_remark";
            tbd.t_billing_deduct_id = "t_billing_deduct_id";
            tbd.t_billing_id = "t_billing_id";

            tbd.pkField = "t_billing_deduct_id";
            tbd.table = "t_billing_deduct";
        }
    }
}
