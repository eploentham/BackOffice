using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FForeignerDB
    {
        FForeigner ff;
        ConnectDB conn;
        public FForeignerDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            ff = new FForeigner();
            ff.foreigner_description = "foreigner_description";
            ff.f_foreigner_id = "f_foreigner_id";

            ff.pkField = "f_foreigner_id";
            ff.table = "f_foreigner";
        }
    }
}
