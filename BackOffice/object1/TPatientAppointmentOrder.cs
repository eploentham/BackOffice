using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientAppointmentOrder:Persistent
    {
        public String t_patient_id { get; set; }
        public String t_patient_appointment_id { get; set; }
        public String b_item_id { get; set; }
        public String patient_appointment_order_common_name { get; set; }
        public String t_patient_appointment_order_id { get; set; }
    }
}
