using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FServiceGroupDB
    {
        FServiceGroup fsg;
        ConnectDB conn;
        public FServiceGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fsg = new FServiceGroup();
            fsg.f_service_group_id = "f_service_group_id";
            fsg.service_group_description = "service_group_description";

            fsg.pkField = "f_service_group_id";
            fsg.table = "f_service_group";
        }
    }
}
