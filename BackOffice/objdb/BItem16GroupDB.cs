using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItem16GroupDB
    {
        BItem16Group bi16g; 
        ConnectDB conn;
        public BItem16GroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bi16g = new BItem16Group();
            bi16g.item_16_group_number = "";
            bi16g.item_16_group_description = "";
            bi16g.item_16_group_active = "";
            bi16g.billgroup_id = "";
            bi16g.b_item_16_group_id = "";
        }
    }
}
