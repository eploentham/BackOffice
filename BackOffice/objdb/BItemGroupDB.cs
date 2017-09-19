using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemGroupDB
    {
        BItemGroup big;
        ConnectDB conn;
        public BItemGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            big = new BItemGroup();
            big.item_group_number = "item_group_number";
            big.item_group_description = "item_group_description";
            big.item_group_staff_owner = "item_group_staff_owner";
            big.item_group_status = "item_group_status";
            big.item_group = "item_group";
            big.b_item_group_id = "b_item_group_id";
            big.item_price = "item_price";
        }
    }
}
