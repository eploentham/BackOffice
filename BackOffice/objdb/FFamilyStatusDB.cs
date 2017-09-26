using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FFamilyStatusDB
    {
        FFamilyStatus ffs;
        ConnectDB conn;
        public FFamilyStatusDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            ffs = new FFamilyStatus();
            ffs.family_status_description = "family_status_description";
            ffs.f_family_status_id = "f_family_status_id";

            ffs.pkField = "f_family_status_id";
            ffs.table = "f_family_status";
        }
    }
}
