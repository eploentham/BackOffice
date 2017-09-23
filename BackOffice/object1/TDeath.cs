using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TDeath:Persistent
    {
        public String death_hn { get; set; }
        public String t_visit_id { get; set; }
        public String death_date_time { get; set; }
        public String death_primary_diagnosis { get; set; }
        public String death_comorbidity { get; set; }
        public String death_complication { get; set; }
        public String death_others { get; set; }
        public String death_external_cause_of_injury { get; set; }
        public String death_cause { get; set; }
        public String death_site { get; set; }
        public String death_pregnant { get; set; }
        public String death_gravida_week { get; set; }
        public String death_vn { get; set; }
        public String t_patient_id { get; set; }
        public String death_staff_record { get; set; }
        public String death_active { get; set; }
        public String t_health_family_id { get; set; }
        public String t_death_id { get; set; }
    }
}
