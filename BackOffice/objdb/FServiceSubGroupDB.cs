using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FServiceSubGroupDB
    {
        FServiceSubGroup fssg;
        ConnectDB conn;
        public FServiceSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fssg = new FServiceSubGroup();
            fssg.f_service_subgroup_id = "f_service_subgroup_id";
            fssg.service_subgroup_description = "service_subgroup_description";

            fssg.pkField = "f_service_subgroup_id";
            fssg.table = "f_service_subgroup";
        }
    }
}
