using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FEmergencyStatusDB
    {
        FEmergencyStatus fes;
        ConnectDB conn;
        public FEmergencyStatusDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fes = new FEmergencyStatus();
            fes.emergency_status_description = "emergency_status_description";
            fes.f_emergency_status_id = "f_emergency_status_id";

            fes.pkField = "f_emergency_status_id";
            fes.table = "f_emergency_status";
        }
    }
}
