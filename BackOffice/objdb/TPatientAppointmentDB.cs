using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientAppointmentDB
    {
        TPatientAppointment tpa;
        ConnectDB conn;
        public TPatientAppointmentDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tpa = new TPatientAppointment();
            tpa.b_visit_queue_setup_id = "b_visit_queue_setup_id";
            tpa.patient_appointment = "patient_appointment";
            tpa.patient_appointment_active = "patient_appointment_active";
            tpa.patient_appointment_auto_visit = "patient_appointment_auto_visit";
            tpa.patient_appointment_cancel_date_time = "patient_appointment_cancel_date_time";
            tpa.patient_appointment_clinic = "patient_appointment_clinic";
            tpa.patient_appointment_date = "patient_appointment_date";
            tpa.patient_appointment_doctor = "patient_appointment_doctor";
            tpa.patient_appointment_notice = "patient_appointment_notice";
            tpa.patient_appointment_record_date_time = "patient_appointment_record_date_time";
            tpa.patient_appointment_staff = "patient_appointment_staff";
            tpa.patient_appointment_staff_cancel = "patient_appointment_staff_cancel";
            tpa.patient_appointment_staff_record = "patient_appointment_staff_record";
            tpa.patient_appointment_staff_update = "patient_appointment_staff_update";
            tpa.patient_appointment_status = "patient_appointment_status";
            tpa.patient_appointment_time = "patient_appointment_time";
            tpa.patient_appointment_update_date_time = "patient_appointment_update_date_time";
            tpa.patient_appointment_vn = "patient_appointment_vn";
            tpa.patient_appoint_date_time = "patient_appoint_date_time";
            tpa.r_rp1853_aptype_id = "r_rp1853_aptype_id";
            tpa.t_patient_id = "t_patient_id";
            tpa.t_patient_appointment_id = "t_patient_appointment_id";
            tpa.t_visit_id = "t_visit_id";

            tpa.pkField = "t_patient_appointment_id";
            tpa.table = "t_patient_appointment";

        }
    }
}
