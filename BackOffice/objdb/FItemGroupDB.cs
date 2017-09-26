using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FItemGroupDB
    {
        FItemGroup fig;
        ConnectDB conn;
        public FItemGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fig = new FItemGroup();
            fig.f_item_group_id = "f_item_group_id";
            fig.item_group_description = "item_group_description";

            fig.pkField = "f_item_group_id";
            fig.table = "f_item_group";
        }
    }
}
