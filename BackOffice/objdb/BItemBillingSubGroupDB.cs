using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemBillingSubGroupDB
    {
        BItemBillingSubGroup bibs;
        ConnectDB conn;
        public BItemBillingSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bibs = new BItemBillingSubGroup();
            bibs.item_billing_subgroup_number = "item_billing_subgroup_number";
            bibs.item_billing_subgroup_description = "item_billing_subgroup_description";
            bibs.f_item_billing_group_id = "f_item_billing_group_id";
            bibs.item_billing_subgroup_active = "item_billing_subgroup_active";
            bibs.item_billing_subgroup_descriptione = "item_billing_subgroup_descriptione";
            bibs.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
        }
    }
}
