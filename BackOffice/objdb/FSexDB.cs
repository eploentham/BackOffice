using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FSexDB
    {
        FSex sex;
        ConnectDB conn;
        public FSexDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            sex = new FSex();
            sex.f_sex_id = "f_sex_id";
            sex.sex_description = "sex_description";

            sex.pkField = "f_sex_id";
            sex.table = "f_sex";
        }
    }
}
