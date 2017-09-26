using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FDischargeStatusDB
    {
        FDischargeStatus fds;
        ConnectDB conn;
        public FDischargeStatusDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fds = new FDischargeStatus();
            fds.discharge_status_description = "discharge_status_description";
            fds.f_discharge_status_id = "f_discharge_status_id";
            fds.pkField = "f_discharge_status_id";
            fds.table = "f_discharge_status";
        }
    }
}
