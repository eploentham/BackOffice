using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.objdb
{
    class BGroupChronicDB
    {
        BGroupChronic bgc;
        ConnectDB conn;

        public BGroupChronicDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bgc = new BGroupChronic();
            bgc.b_group_chronic_id = "b_group_chronic_id";
            bgc.group_chronic_active = "group_chronic_active"; ;
            bgc.group_chronic_description_en = "group_chronic_description_en";
            bgc.group_chronic_description_th = "group_chronic_description_th"; ;
            bgc.group_chronic_number = "group_chronic_number";

            bgc.pkField = "b_group_chronic_id";
            bgc.table = "b_group_chronic";
        }
    }
}
