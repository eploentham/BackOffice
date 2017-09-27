using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientXnDB
    {
        TPatientXn tpx;
        ConnectDB conn;
        public TPatientXnDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tpx = new TPatientXn();
            tpx.patient_xn_active = "patient_xn_active";
            tpx.patient_xn_year = "patient_xn_year";
            tpx.patient_xray_number = "patient_xray_number";
            tpx.t_patient_id = "t_patient_id";
            tpx.t_patient_xn_id = "t_patient_xn_id";

            tpx.pkField = "t_patient_xn_id";
            tpx.table = "t_patient_xn";
        }
    }
}
