using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FOccupationDB
    {
        FOccupation fo;
        ConnectDB conn;
        public FOccupationDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fo = new FOccupation();
            fo.f_occupation_id = "f_occupation_id";
            fo.occupation_description = "occupation_description";

            fo.pkField = "f_occupation_id";
            fo.table = "f_occupation";
        }
    }
}
