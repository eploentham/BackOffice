using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TVisitPrimarySymptomDB
    {
        TVisitPrimarySymptom tvps;
        ConnectDB conn;
        public TVisitPrimarySymptomDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tvps = new TVisitPrimarySymptom();
            tvps.record_date_time = "record_date_time";
            tvps.t_patient_id = "t_patient_id";
            tvps.t_visit_id = "t_visit_id";
            tvps.t_visit_primary_symptom_id = "t_visit_primary_symptom_id";
            tvps.visit_primary_symptom_active = "visit_primary_symptom_active";
            tvps.visit_primary_symptom_current_illness = "visit_primary_symptom_current_illness";
            tvps.visit_primary_symptom_general_symptom = "visit_primary_symptom_general_symptom";
            tvps.visit_primary_symptom_main_symptom = "visit_primary_symptom_main_symptom";
            tvps.visit_primary_symptom_staff_cancel = "visit_primary_symptom_staff_cancel";
            tvps.visit_primary_symptom_staff_modify = "visit_primary_symptom_staff_modify";
            tvps.visit_primary_symptom_staff_record = "visit_primary_symptom_staff_record";

            tvps.pkField = "t_visit_primary_symptom_id";
            tvps.table = "t_visit_primary_symptom";
        }
    }
}
