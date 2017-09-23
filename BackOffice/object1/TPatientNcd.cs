using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientNcd:Persistent
    {
        public String t_patient_id { get; set; }
        public String b_ncd_group_id { get; set; }
        public String patient_ncd_number { get; set; }
        public String patient_ncd_staff_record { get; set; }
        public String patient_ncd_record_date_time { get; set; }
        public String patient_ncd_staff_modify { get; set; }
        public String patient_ncd_modify_date_time { get; set; }
        public String t_patient_ncd_id { get; set; }
    }
}
