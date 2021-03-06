﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientAppointment:Persistent
    {
        public String t_patient_id { get; set; }
        public String patient_appoint_date_time { get; set; }
        public String patient_appointment_date { get; set; }
        public String patient_appointment_time { get; set; }
        public String patient_appointment { get; set; }
        public String patient_appointment_doctor { get; set; }
        public String patient_appointment_clinic { get; set; }
        public String patient_appointment_notice { get; set; }
        public String patient_appointment_staff { get; set; }
        public String t_visit_id { get; set; }
        public String patient_appointment_auto_visit { get; set; }
        public String b_visit_queue_setup_id { get; set; }
        public String patient_appointment_status { get; set; }
        public String patient_appointment_vn { get; set; }
        public String patient_appointment_staff_record { get; set; }
        public String patient_appointment_record_date_time { get; set; }
        public String patient_appointment_staff_update { get; set; }
        public String patient_appointment_update_date_time { get; set; }
        public String patient_appointment_staff_cancel { get; set; }
        public String patient_appointment_cancel_date_time { get; set; }
        public String patient_appointment_active { get; set; }
        public String r_rp1853_aptype_id { get; set; }
        public String t_patient_appointment_id { get; set; }
    }
}
