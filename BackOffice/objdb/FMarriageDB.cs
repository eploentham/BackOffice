using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FMarriageDB
    {
        FMarriage fm;
        ConnectDB conn;
        public FMarriageDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fm = new FMarriage();
            fm.f_marriage_id = "f_marriage_id";
            fm.marriag_description = "marriag_description";

            fm.pkField = "f_marriage_id";
            fm.table = "f_marriage";
        }
    }
}
