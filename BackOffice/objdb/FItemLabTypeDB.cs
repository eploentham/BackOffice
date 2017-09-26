using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FItemLabTypeDB
    {
        FItemLabType fibt;
        ConnectDB conn;
        public FItemLabTypeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fibt = new FItemLabType();
            fibt.id = "id";
            fibt.name = "name";

            fibt.pkField = "id";
            fibt.table = "f_item_lab_type";
        }
    }
}
