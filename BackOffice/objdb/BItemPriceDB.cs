using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemPriceDB
    {
        BItemPrice bip;
        ConnectDB conn;
        public BItemPriceDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bip = new BItemPrice();
            bip.item_price_number = "item_price_number";
            bip.b_item_id = "b_item_id";
            bip.item_price_active_date = "item_price_active_date";
            bip.item_price_cost = "item_price_cost";
            bip.b_item_price_id = "b_item_price_id";
            bip.item_price = "item_price";
        }
    }
}
