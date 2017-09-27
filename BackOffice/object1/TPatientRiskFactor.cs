using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientRiskFactor:Persistent
    {
        public String t_patient_id { get; set; }
        public String patient_risk_factor_description { get; set; }
        public String patient_risk_factor_staff_record { get; set; }
        public String patient_risk_factor_record_date_time { get; set; }
        public String patient_risk_factor_topic { get; set; }
        public String t_patient_risk_factor_id { get; set; }        
    }
}
