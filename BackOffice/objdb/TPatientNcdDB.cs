using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientNcdDB
    {
        TPatientNcd tpn;
        ConnectDB conn;
        public TPatientNcdDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tpn = new TPatientNcd();
            tpn.b_ncd_group_id = "b_ncd_group_id";
            tpn.patient_ncd_modify_date_time = "patient_ncd_modify_date_time";
            tpn.patient_ncd_number = "patient_ncd_number";
            tpn.patient_ncd_record_date_time = "patient_ncd_record_date_time";
            tpn.patient_ncd_staff_modify = "patient_ncd_staff_modify";
            tpn.patient_ncd_staff_record = "patient_ncd_staff_record";
            tpn.t_patient_id = "t_patient_id";
            tpn.t_patient_ncd_id = "t_patient_ncd_id";

            tpn.pkField = "t_patient_ncd_id";
            tpn.table = "t_patient_ncd";
        }
    }
}
