using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BBankDB
    {
        BBank bb;
        ConnectDB conn;
        public BBankDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bb = new BBank();
            bb.b_bank_active = "b_bank_active";
            bb.b_bank_id = "b_bank_id";
            bb.b_bank_namet = "b_bank_namet";

            bb.pkField = "b_bank_id";
            bb.table = "b_bank";
        }
    }
}
