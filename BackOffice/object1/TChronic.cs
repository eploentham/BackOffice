using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TChronic:Persistent
    {
        public String chronic_hn { get; set; }
        public String chronic_vn { get; set; }
        public String chronic_diagnosis_date { get; set; }
        public String chronic_discharge_date { get; set; }
        public String f_chronic_discharge_status_id { get; set; }
        public String chronic_notice { get; set; }
        public String chronic_icd10 { get; set; }
        public String t_visit_id { get; set; }
        public String t_patient_id { get; set; }
        public String record_date_time { get; set; }
        public String chronic_site_treat { get; set; }
        public String t_health_family_id { get; set; }
        public String modify_date_time { get; set; }
        public String cancel_date_time { get; set; }
        public String staff_record { get; set; }
        public String staff_modify { get; set; }
        public String staff_cancel { get; set; }
        public String chronic_active { get; set; }
        public String chronic_survey_date { get; set; }
        public String t_chronic_id { get; set; }
    }
}
