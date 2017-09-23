using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TVisitVitalSign:Persistent
    {
        public String t_visit_id { get; set; }
        public String record_time { get; set; }
        public String record_date { get; set; }
        public String visit_vital_sign_height { get; set; }
        public String visit_vital_sign_weight { get; set; }
        public String visit_vital_sign_blood_presure { get; set; }
        public String visit_vital_sign_temperature { get; set; }
        public String visit_vital_sign_heart_rate { get; set; }
        public String visit_vital_sign_respiratory_rate { get; set; }
        public String visit_vital_sign_general_symptom { get; set; }
        public String f_visit_nutrition_level_id { get; set; }
        public String visit_vital_sign_staff_record { get; set; }
        public String visit_vital_sign_current_illness_symptom { get; set; }
        public String t_patient_id { get; set; }
        public String visit_vital_sign_bmi { get; set; }
        public String visit_vital_sign_note { get; set; }
        public String visit_vital_sign_check_date { get; set; }
        public String visit_vital_sign_check_time { get; set; }
        public String visit_vital_sign_staff_modify { get; set; }
        public String visit_vital_sign_modify_date_time { get; set; }
        public String visit_vital_sign_active { get; set; }
        public String visit_waistline { get; set; }
        public String visit_dtx { get; set; }
        public String visit_vital_sign_waistline { get; set; }
        public String visit_vital_sign_waistline_inch { get; set; }
        public String visit_vital_sign_chest_line { get; set; }
        public String visit_vital_sign_head_line { get; set; }
        public String visit_vital_sign_breath_in { get; set; }
        public String visit_vital_sign_breath_out { get; set; }
        public String t_visit_vital_sign_id { get; set; }
    }
}
