using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientFamilyHistoryDB
    {
        ConnectDB conn;
        TPatientFamilyHistory tpfh;
        public TPatientFamilyHistoryDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tpfh = new TPatientFamilyHistory();
            tpfh.patient_family_history_description = "patient_family_history_description";
            tpfh.patient_family_history_record_date_time = "patient_family_history_record_date_time";
            tpfh.patient_family_history_staff_record = "patient_family_history_staff_record";
            tpfh.patient_family_history_topic = "patient_family_history_topic";
            tpfh.t_patient_family_history_id = "t_patient_family_history_id";
            tpfh.t_patient_id = "t_patient_id";

            tpfh.pkField = "t_patient_family_history_id";
            tpfh.table = "t_patient_family_history";
        }
    }
}
