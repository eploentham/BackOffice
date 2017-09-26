using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FBloodGroupDB
    {
        FBloodGroup fbg;
        ConnectDB conn;
        public FBloodGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fbg = new FBloodGroup();
            fbg.f_blood_group_id = "f_blood_group_id";
            fbg.blood_group_description = "blood_group_description";

            fbg.pkField = "f_blood_group_id";
            fbg.table = "f_blood_group";
        }
    }
}
