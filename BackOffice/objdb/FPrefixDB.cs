using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FPrefixDB
    {
        FPrefix fp;
        ConnectDB conn;
        public FPrefixDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fp = new FPrefix();
            fp.active = "active";
            fp.f_prefix_id = "f_prefix_id";
            fp.f_sex_id = "f_sex_id";
            fp.f_tlock_id = "f_tlock_id";
            fp.prefix_description = "prefix_description";

            fp.pkField = "f_prefix_id";
            fp.table = "f_prefix";
        }
    }
}
