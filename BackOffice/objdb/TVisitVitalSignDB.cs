using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TVisitVitalSignDB
    {
        TVisitVitalSign tvvs;
        ConnectDB conn;
        public TVisitVitalSignDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tvvs = new TVisitVitalSign();
            tvvs.f_visit_nutrition_level_id = "f_visit_nutrition_level_id";
            tvvs.record_date = "record_date";
            tvvs.record_time = "record_time";
            tvvs.t_patient_id = "t_patient_id";
            tvvs.t_visit_id = "t_visit_id";
            tvvs.t_visit_vital_sign_id = "t_visit_vital_sign_id";
            tvvs.visit_dtx = "visit_dtx";
            tvvs.visit_vital_sign_active = "visit_vital_sign_active";
            tvvs.visit_vital_sign_blood_presure = "visit_vital_sign_blood_presure";
            tvvs.visit_vital_sign_bmi = "visit_vital_sign_bmi";
            tvvs.visit_vital_sign_breath_in = "visit_vital_sign_breath_in";
            tvvs.visit_vital_sign_breath_out = "visit_vital_sign_breath_out";
            tvvs.visit_vital_sign_check_date = "visit_vital_sign_check_date";
            tvvs.visit_vital_sign_check_time = "visit_vital_sign_check_time";
            tvvs.visit_vital_sign_chest_line = "visit_vital_sign_chest_line";
            tvvs.visit_vital_sign_current_illness_symptom = "visit_vital_sign_current_illness_symptom";
            tvvs.visit_vital_sign_general_symptom = "visit_vital_sign_general_symptom";
            tvvs.visit_vital_sign_head_line = "visit_vital_sign_head_line";
            tvvs.visit_vital_sign_heart_rate = "visit_vital_sign_heart_rate";
            tvvs.visit_vital_sign_height = "visit_vital_sign_height";
            tvvs.visit_vital_sign_modify_date_time = "visit_vital_sign_modify_date_time";
            tvvs.visit_vital_sign_note = "visit_vital_sign_note";
            tvvs.visit_vital_sign_respiratory_rate = "visit_vital_sign_respiratory_rate";
            tvvs.visit_vital_sign_staff_modify = "visit_vital_sign_staff_modify";
            tvvs.visit_vital_sign_staff_record = "visit_vital_sign_staff_record";
            tvvs.visit_vital_sign_temperature = "visit_vital_sign_temperature";
            tvvs.visit_vital_sign_waistline = "visit_vital_sign_waistline";
            tvvs.visit_vital_sign_waistline_inch = "visit_vital_sign_waistline_inch";
            tvvs.visit_vital_sign_weight = "visit_vital_sign_weight";
            tvvs.visit_waistline = "visit_waistline";

            tvvs.pkField = "t_visit_vital_sign_id";
            tvvs.table = "t_visit_vital_sign";
        }
    }
}
