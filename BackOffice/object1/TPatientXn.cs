using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientXn:Persistent
    {
        public String patient_xray_number { get; set; }
        public String patient_xn_year { get; set; }
        public String t_patient_id { get; set; }
        public String patient_xn_active { get; set; }
        public String t_patient_xn_id { get; set; }
    }
}
