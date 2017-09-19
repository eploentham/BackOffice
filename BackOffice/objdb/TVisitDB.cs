using System;
using System.Collections.Generic;
using System.Data;
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
            tv.Active = "active";
            tv.visit_hn  = "visit_hn";
            tv.vn  = "vn";
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
            tv.status_ipd_discharge  = "status_ipd_discharge";
            tv.status_money_discharge  = "status_money_discharge";
            tv.status_doctor_discharge  = "status_doctor_discharge";
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
            tv.status_appointment  = "status_appointment";
            tv.status_admit  = "status_admit";
            tv.status_refer  = "status_refer";
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
            tv.status_scan_sn_dx  = "status_scan_sn_dx";
            tv.status_lab_approve  = "status_lab_approve";
            tv.visit_lab_approve_staff  = "visit_lab_approve_staff";
            tv.visit_primary_symtom  = "visit_primary_symtom";
            tv.b_visit_bed_id  = "b_visit_bed_id";
            tv.b_visit_room_id  = "b_visit_room_id";
            tv.status_prepare_discharge  = "status_prepare_discharge";
            tv.prepare_discharge_date_time  = "prepare_discharge_date_time";
            tv.prepare_discharge_message  = "prepare_discharge_message";
            tv.visit_diagnosis_notice  = "visit_diagnosis_notice";
            tv.t_visit_id  = "t_visit_id";
            tv.VnSeq = "vn_seq";
            tv.VnSum = "vn_sum";

            tv.pkField = "t_visit_id";
            tv.table = "t_visit";
        }
        private TVisit setData(TVisit p, DataTable dt)
        {
            p.Active = dt.Rows[0][tv.Active].ToString();
            p.b_contract_plans_id = dt.Rows[0][tv.b_contract_plans_id].ToString();
            p.b_ncd_group_id = dt.Rows[0][tv.b_ncd_group_id].ToString();
            p.b_service_point_id = dt.Rows[0][tv.b_service_point_id].ToString();
            p.b_visit_bed_id = dt.Rows[0][tv.b_visit_bed_id].ToString();
            p.b_visit_clinic_id = dt.Rows[0][tv.b_visit_clinic_id].ToString();
            p.b_visit_office_id_refer_in = dt.Rows[0][tv.b_visit_office_id_refer_in].ToString();
            p.b_visit_office_id_refer_out = dt.Rows[0][tv.b_visit_office_id_refer_out].ToString();
            p.b_visit_room_id = dt.Rows[0][tv.b_visit_room_id].ToString();
            p.b_visit_ward_id = dt.Rows[0][tv.b_visit_ward_id].ToString();
            p.contact_id = dt.Rows[0][tv.contact_id].ToString();
            p.contact_join_id = dt.Rows[0][tv.contact_join_id].ToString();
            p.contact_join_namet = dt.Rows[0][tv.contact_join_namet].ToString();
            p.contact_namet = dt.Rows[0][tv.contact_namet].ToString();
            p.f_emergency_status_id = dt.Rows[0][tv.f_emergency_status_id].ToString();
            p.f_refer_cause_id = dt.Rows[0][tv.f_refer_cause_id].ToString();
            p.f_visit_ipd_discharge_id = dt.Rows[0][tv.f_visit_ipd_discharge_id].ToString();
            p.f_visit_ipd_discharge_type_id = dt.Rows[0][tv.f_visit_ipd_discharge_type_id].ToString();
            p.f_visit_opd_discharge_id = dt.Rows[0][tv.f_visit_opd_discharge_id].ToString();
            p.f_visit_status_id = dt.Rows[0][tv.f_visit_status_id].ToString();
            p.f_visit_type_id = dt.Rows[0][tv.f_visit_type_id].ToString();
            p.prepare_discharge_date_time = dt.Rows[0][tv.prepare_discharge_date_time].ToString();
            p.prepare_discharge_message = dt.Rows[0][tv.prepare_discharge_message].ToString();
            p.service_location = dt.Rows[0][tv.service_location].ToString();
            p.status_admit = dt.Rows[0][tv.status_admit].ToString();
            p.status_appointment = dt.Rows[0][tv.status_appointment].ToString();
            p.status_doctor_discharge = dt.Rows[0][tv.status_doctor_discharge].ToString();
            p.status_ipd_discharge = dt.Rows[0][tv.status_ipd_discharge].ToString();
            p.status_lab_approve = dt.Rows[0][tv.status_lab_approve].ToString();
            p.status_money_discharge = dt.Rows[0][tv.status_money_discharge].ToString();
            p.status_prepare_discharge = dt.Rows[0][tv.status_prepare_discharge].ToString();
            p.status_refer = dt.Rows[0][tv.status_refer].ToString();
            p.status_scan_sn_dx = dt.Rows[0][tv.status_scan_sn_dx].ToString();
            p.surveillance_case_id = dt.Rows[0][tv.surveillance_case_id].ToString();
            p.t_patient_appointment_id = dt.Rows[0][tv.t_patient_appointment_id].ToString();
            p.t_patient_id = dt.Rows[0][tv.t_patient_id].ToString();
            p.t_visit_id = dt.Rows[0][tv.t_visit_id].ToString();
            p.visit_an = dt.Rows[0][tv.visit_an].ToString();
            p.visit_bed = dt.Rows[0][tv.visit_bed].ToString();
            p.visit_begin_admit_date_time = dt.Rows[0][tv.visit_begin_admit_date_time].ToString();
            p.visit_begin_visit_time = dt.Rows[0][tv.visit_begin_visit_time].ToString();
            p.visit_cal_date_appointment = dt.Rows[0][tv.visit_cal_date_appointment].ToString();
            p.visit_cause_appointment = dt.Rows[0][tv.visit_cause_appointment].ToString();
            p.visit_deny_allergy = dt.Rows[0][tv.visit_deny_allergy].ToString();
            p.visit_diagnosis_notice = dt.Rows[0][tv.visit_diagnosis_notice].ToString();
            p.visit_dx = dt.Rows[0][tv.visit_dx].ToString();
            p.visit_dx_stat = dt.Rows[0][tv.visit_dx_stat].ToString();
            p.visit_emergency_staff = dt.Rows[0][tv.visit_emergency_staff].ToString();
            p.visit_financial_discharge_time = dt.Rows[0][tv.visit_financial_discharge_time].ToString();
            p.visit_financial_record_date_time = dt.Rows[0][tv.visit_financial_record_date_time].ToString();
            p.visit_financial_record_staff = dt.Rows[0][tv.visit_financial_record_staff].ToString();
            p.visit_first_visit = dt.Rows[0][tv.visit_first_visit].ToString();
            p.visit_hn = dt.Rows[0][tv.visit_hn].ToString();
            p.visit_hospital_service = dt.Rows[0][tv.visit_hospital_service].ToString();
            p.visit_lab_approve_staff = dt.Rows[0][tv.visit_lab_approve_staff].ToString();
            p.visit_lab_status_id = dt.Rows[0][tv.visit_lab_status_id].ToString();
            p.visit_locking = dt.Rows[0][tv.visit_locking].ToString();
            p.visit_lock_date_time = dt.Rows[0][tv.visit_lock_date_time].ToString();
            p.visit_ncd = dt.Rows[0][tv.visit_ncd].ToString();
            p.visit_notice = dt.Rows[0][tv.visit_notice].ToString();
            p.visit_observe = dt.Rows[0][tv.visit_observe].ToString();
            p.visit_patient_age = dt.Rows[0][tv.visit_patient_age].ToString();
            p.visit_patient_self_doctor = dt.Rows[0][tv.visit_patient_self_doctor].ToString();
            p.visit_patient_type = dt.Rows[0][tv.visit_patient_type].ToString();
            p.visit_pcu_service = dt.Rows[0][tv.visit_pcu_service].ToString();
            p.visit_pregnant = dt.Rows[0][tv.visit_pregnant].ToString();
            p.visit_primary_symtom = dt.Rows[0][tv.visit_primary_symtom].ToString();
            p.visit_queue = dt.Rows[0][tv.visit_queue].ToString();
            p.visit_record_date_time = dt.Rows[0][tv.visit_record_date_time].ToString();
            p.visit_record_staff = dt.Rows[0][tv.visit_record_staff].ToString();
            p.visit_staff_doctor_discharge = dt.Rows[0][tv.visit_staff_doctor_discharge].ToString();
            p.visit_staff_doctor_discharge_date_time = dt.Rows[0][tv.visit_staff_doctor_discharge_date_time].ToString();
            p.visit_staff_financial_discharge = dt.Rows[0][tv.visit_staff_financial_discharge].ToString();
            p.visit_staff_lock = dt.Rows[0][tv.visit_staff_lock].ToString();
            p.visit_staff_observe = dt.Rows[0][tv.visit_staff_observe].ToString();
            p.vn = dt.Rows[0][tv.vn].ToString();
            p.VnSeq = dt.Rows[0][tv.VnSeq].ToString();
            p.VnSum = dt.Rows[0][tv.VnSum].ToString();

            return p;
        }
        private String insert(TVisit p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.vn.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + tv.table + "(" + tv.Active + "," + tv.b_contract_plans_id + ","+ tv.b_ncd_group_id + ","+
                    tv.b_service_point_id + "," + tv.b_visit_bed_id + "," + tv.b_visit_clinic_id + "," +
                    tv.b_visit_office_id_refer_in + "," + tv.b_visit_office_id_refer_out + "," + tv.b_visit_room_id + "," +
                    tv.b_visit_ward_id + "," + tv.contact_id + "," + tv.contact_join_id + "," +
                    tv.contact_join_namet + "," + tv.contact_namet + "," + tv.f_emergency_status_id + "," +
                    tv.f_refer_cause_id + "," + tv.f_visit_ipd_discharge_id + "," + tv.f_visit_ipd_discharge_type_id + "," +
                    tv.f_visit_opd_discharge_id + "," + tv.f_visit_status_id + "," + tv.f_visit_type_id + "," +
                    tv.prepare_discharge_date_time + "," + tv.prepare_discharge_message + "," + tv.service_location + "," +
                    tv.status_admit + "," + tv.status_appointment + "," + tv.status_doctor_discharge + "," +
                    tv.status_ipd_discharge + "," + tv.status_lab_approve + "," + tv.status_money_discharge + "," +
                    tv.status_prepare_discharge + "," + tv.status_refer + "," + tv.status_scan_sn_dx + "," +
                    tv.surveillance_case_id + "," + tv.t_patient_appointment_id + "," + tv.t_patient_id + "," +
                    tv.t_visit_id + "," + tv.visit_an + "," + tv.visit_bed + "," +
                    tv.visit_begin_admit_date_time + "," + tv.visit_begin_visit_time + "," + tv.visit_cal_date_appointment + "," +
                    tv.visit_cause_appointment + "," + tv.visit_deny_allergy + "," + tv.visit_diagnosis_notice + "," +
                    tv.visit_dx + "," + tv.visit_dx_stat + "," + tv.visit_emergency_staff + "," +
                    tv.visit_financial_discharge_time + "," + tv.visit_financial_record_date_time + "," + tv.visit_financial_record_staff + "," +
                    tv.visit_first_visit + "," + tv.visit_hn + "," + tv.visit_hospital_service + "," +
                    tv.visit_lab_approve_staff + "," + tv.visit_lab_status_id + "," + tv.visit_locking + "," +
                    tv.visit_lock_date_time + "," + tv.visit_ncd + "," + tv.visit_notice + "," +
                    tv.visit_observe + "," + tv.visit_patient_age + "," + tv.visit_patient_self_doctor + "," +
                    tv.visit_patient_type + "," + tv.visit_pcu_service + "," + tv.visit_pregnant + "," +
                    tv.visit_primary_symtom + "," + tv.visit_queue + "," + tv.visit_record_date_time + "," +
                    tv.visit_record_staff + "," + tv.visit_staff_doctor_discharge + "," + tv.visit_staff_doctor_discharge_date_time + "," +
                    tv.visit_staff_financial_discharge + "," + tv.visit_staff_lock + "," + tv.visit_staff_observe + "," +
                    tv.vn + "," + tv.VnSeq + "," + tv.VnSum + ") " +
                    "Values('" + p.Active + "','" + p.b_contract_plans_id + "','" + p.b_ncd_group_id + "','" +
                    p.b_service_point_id + "','" + p.b_visit_bed_id + "','" + p.b_visit_clinic_id + "','" +
                    p.b_visit_office_id_refer_in + "','" + p.b_visit_office_id_refer_out + "','" + p.b_visit_room_id + "','" +
                    p.b_visit_ward_id + "','" + p.contact_id + "','" + p.contact_join_id + "','" +
                    p.contact_join_namet + "','" + p.contact_namet + "','" + p.f_emergency_status_id + "','" +
                    p.f_refer_cause_id + "','" + p.f_visit_ipd_discharge_id + "','" + p.f_visit_ipd_discharge_type_id + "','" +
                    p.f_visit_opd_discharge_id + "','" + p.f_visit_status_id + "','" + p.f_visit_type_id + "','" +
                    p.prepare_discharge_date_time + "','" + p.prepare_discharge_message + "','" + p.service_location + "','" +
                    p.status_admit + "','" + p.status_appointment + "','" + p.status_doctor_discharge + "','" +
                    p.status_ipd_discharge + "','" + p.status_lab_approve + "','" + p.status_money_discharge + "','" +
                    p.status_prepare_discharge + "','" + p.status_refer + "','" + p.status_scan_sn_dx + "','" +
                    p.surveillance_case_id + "','" + p.t_patient_appointment_id + "','" + p.t_patient_id + "','" +
                    p.t_visit_id + "','" + p.visit_an + "','" + p.visit_bed + "','" +
                    p.visit_begin_admit_date_time + "','" + p.visit_begin_visit_time + "','" + p.visit_cal_date_appointment + "','" +
                    p.visit_cause_appointment + "','" + p.visit_deny_allergy + "','" + p.visit_diagnosis_notice + "','" +
                    p.visit_dx + "','" + p.visit_dx_stat + "','" + p.visit_emergency_staff + "','" +
                    p.visit_financial_discharge_time + "','" + p.visit_financial_record_date_time + "','" + p.visit_financial_record_staff + "','" +
                    p.visit_first_visit + "','" + p.visit_hn + "','" + p.visit_hospital_service + "','" +
                    p.visit_lab_approve_staff + "','" + p.visit_lab_status_id + "','" + p.visit_locking + "','" +
                    p.visit_lock_date_time + "','" + p.visit_ncd + "','" + p.visit_notice + "','" +
                    p.visit_observe + "','" + p.visit_patient_age + "','" + p.visit_patient_self_doctor + "','" +
                    p.visit_patient_type + "','" + p.visit_pcu_service + "','" + p.visit_pregnant + "','" +
                    p.visit_primary_symtom + "','" + p.visit_queue + "','" + p.visit_record_date_time + "','" +
                    p.visit_record_staff + "','" + p.visit_staff_doctor_discharge + "','" + p.visit_staff_doctor_discharge_date_time + "','" +
                    p.visit_staff_financial_discharge + "','" + p.visit_staff_lock + "','" + p.visit_staff_observe + "','" +
                    p.vn + "','" + p.VnSeq + "','" + p.VnSum + "') ";
                chk = conn.ExecuteNonQueryAutoIncrement(sql, "orc_ba");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }

            return chk;
        }
    }
}
