using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemSetDB
    {
        BItemSet bis;
        ConnectDB conn;
        public BItemSetDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bis = new BItemSet();
            bis.b_item_group_id = "b_item_group_id";
            bis.b_item_id = "b_item_id";
            bis.item_set_status = "item_set_status";
            bis.b_item_set_id = "b_item_set_id";
            bis.item_price = "item_price";
        }
    }
}
