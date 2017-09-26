using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FItemBillingGroupDB
    {
        FItemBillingGroup fibg;
        ConnectDB conn;
        public FItemBillingGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fibg = new FItemBillingGroup();
            fibg.f_item_billing_group_id = "f_item_billing_group_id";
            fibg.item_billing_group_description = "item_billing_group_description";

            fibg.pkField = "f_item_billing_group_id"; ;
            fibg.table = "f_item_billing_group";
        }
    }
}
