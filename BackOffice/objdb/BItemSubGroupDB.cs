using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemSubGroupDB
    {
        BItemSubGroup bisg;
        ConnectDB conn;
        public BItemSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bisg = new BItemSubGroup();
            bisg.item_subgroup_number = "item_subgroup_number";
            bisg.item_subgroup_description = "item_subgroup_description";
            bisg.f_item_group_id = "f_item_group_id";
            bisg.item_subgroup_active = "item_subgroup_active";
            bisg.b_item_subgroup_id = "b_item_subgroup_id";
        }
    }
}
