using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FNationDB
    {
        FNation fn;
        ConnectDB conn;
        public FNationDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fn = new FNation();
            fn.f_nation_id = "f_nation_id";
            fn.nation_description = "nation_description";

            fn.pkField = "f_nation_id";
            fn.table = "f_nation";
        }
    }
}
