using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TVisitDB
    {
        ConnectDB conn;
        TVisit tv;
        public TVisitDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tv = new TVisit();
            tv.visit_hn  = "visit_hn";
            tv.visit_vn  = "visit_vn";
            tv.f_visit_type_id  = "f_visit_type_id";
            tv.visit_begin_visit_time  = "visit_begin_visit_time";
            tv.visit_financial_discharge_time  = "visit_financial_discharge_time";
            tv.visit_notice  = "visit_notice";
            tv.b_visit_office_id_refer_in  = "b_visit_office_id_refer_in";
            tv.b_visit_office_id_refer_out  = "b_visit_office_id_refer_out";
            tv.f_visit_opd_discharge_id  = "f_visit_opd_discharge_id";
            tv.f_visit_ipd_discharge_type_id  = "f_visit_ipd_discharge_type_id";
            tv.f_visit_ipd_discharge_id  = "f_visit_ipd_discharge_id";
            tv.visit_locking  = "visit_locking";
            tv.visit_staff_lock  = "visit_staff_lock";
            tv.visit_lock_date_time  = "visit_lock_date_time";
            tv.f_visit_status_id  = "f_visit_status_id";
            tv.visit_pregnant  = "visit_pregnant";
            tv.b_visit_clinic_id  = "b_visit_clinic_id";
            tv.b_visit_ward_id  = "b_visit_ward_id";
            tv.visit_bed  = "visit_bed";
            tv.visit_observe  = "visit_observe";
            tv.visit_patient_type  = "visit_patient_type";
            tv.visit_queue  = "visit_queue";
            tv.b_service_point_id  = "b_service_point_id";
            tv.visit_staff_observe  = "visit_staff_observe";
            tv.visit_dx  = "visit_dx";
            tv.visit_ipd_discharge_status  = "visit_ipd_discharge_status";
            tv.visit_money_discharge_status  = "visit_money_discharge_status";
            tv.visit_doctor_discharge_status  = "visit_doctor_discharge_status";
            tv.t_patient_id  = "t_patient_id";
            tv.visit_staff_financial_discharge  = "visit_staff_financial_discharge";
            tv.visit_staff_doctor_discharge  = "visit_staff_doctor_discharge";
            tv.visit_staff_doctor_discharge_date_time  = "visit_staff_doctor_discharge_date_time";
            tv.visit_an  = "visit_an";
            tv.visit_dx_stat  = "visit_dx_stat";
            tv.visit_begin_admit_date_time  = "visit_begin_admit_date_time";
            tv.visit_deny_allergy  = "visit_deny_allergy";
            tv.visit_first_visit  = "visit_first_visit";
            tv.visit_patient_self_doctor  = "visit_patient_self_doctor";
            tv.visit_patient_age  = "visit_patient_age";
            tv.visit_pcu_service  = "visit_pcu_service";
            tv.visit_hospital_service  = "visit_hospital_service";
            tv.visit_lab_status_id  = "visit_lab_status_id";
            tv.visit_ncd  = "visit_ncd";
            tv.b_ncd_group_id  = "b_ncd_group_id";
            tv.f_refer_cause_id  = "f_refer_cause_id";
            tv.f_emergency_status_id  = "f_emergency_status_id";
            tv.visit_emergency_staff  = "visit_emergency_staff";
            tv.visit_have_appointment  = "visit_have_appointment";
            tv.visit_have_admit  = "visit_have_admit";
            tv.visit_have_refer  = "visit_have_refer";
            tv.t_patient_appointment_id  = "t_patient_appointment_id";
            tv.visit_cal_date_appointment  = "visit_cal_date_appointment";
            tv.visit_cause_appointment  = "visit_cause_appointment";
            tv.b_contract_plans_id  = "b_contract_plans_id";
            tv.contact_id  = "contact_id";
            tv.contact_namet  = "contact_namet";
            tv.contact_join_id  = "contact_join_id";
            tv.contact_join_namet  = "contact_join_namet";
            tv.surveillance_case_id  = "surveillance_case_id";
            tv.visit_record_date_time  = "visit_record_date_time";
            tv.visit_record_staff  = "visit_record_staff";
            tv.visit_financial_record_date_time  = "visit_financial_record_date_time";
            tv.visit_financial_record_staff  = "visit_financial_record_staff";
            tv.service_location  = "service_location";
            tv.visit_have_scan_sn_dx  = "visit_have_scan_sn_dx";
            tv.visit_status_lab_approve  = "visit_status_lab_approve";
            tv.visit_lab_approve_staff  = "visit_lab_approve_staff";
            tv.visit_primary_symtom  = "visit_primary_symtom";
            tv.b_visit_bed_id  = "b_visit_bed_id";
            tv.b_visit_room_id  = "b_visit_room_id";
            tv.status_prepare_discharge  = "status_prepare_discharge";
            tv.prepare_discharge_date_time  = "prepare_discharge_date_time";
            tv.prepare_discharge_message  = "prepare_discharge_message";
            tv.visit_diagnosis_notice  = "visit_diagnosis_notice";
            tv.t_visit_id  = "t_visit_id";
        }
    }
}
