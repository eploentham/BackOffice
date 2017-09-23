using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TVisitPrimarySymptom:Persistent
    {
        public String t_visit_id { get; set; }
        public String t_patient_id { get; set; }
        public String record_date_time { get; set; }
        public String visit_primary_symptom_staff_record { get; set; }
        public String visit_primary_symptom_staff_modify { get; set; }
        public String visit_primary_symptom_staff_cancel { get; set; }
        public String visit_primary_symptom_active { get; set; }
        public String visit_primary_symptom_general_symptom { get; set; }
        public String visit_primary_symptom_main_symptom { get; set; }
        public String visit_primary_symptom_current_illness { get; set; }
        public String t_visit_primary_symptom_id { get; set; }
    }
}
