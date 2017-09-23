using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientFamilyHistory:Persistent
    {
        public String t_patient_id { get; set; }
        public String patient_family_history_description { get; set; }
        public String patient_family_history_staff_record { get; set; }
        public String patient_family_history_record_date_time { get; set; }
        public String patient_family_history_topic { get; set; }
        public String t_patient_family_history_id { get; set; }
    }
}
