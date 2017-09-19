using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientDB
    {
        ConnectDB conn;
        TPatient tp;
        public TPatientDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tp = new TPatient();
            tp.patient_hn = "patient_hn";
            tp.f_patient_prefix_id = "f_patient_prefix_id";
            tp.patient_firstname = "patient_firstname";
            tp.patient_lastname = "patient_lastname";
            tp.patient_xn = "patient_xn";
            tp.f_sex_id = "f_sex_id";
            tp.patient_birthday = "patient_birthday";
            tp.patient_house = "patient_house";
            tp.patient_road = "patient_road";
            tp.patient_moo = "patient_moo";
            tp.patient_tambon = "patient_tambon";
            tp.patient_amphur = "patient_amphur";
            tp.patient_changwat = "patient_changwat";
            tp.f_marriage_id = "f_marriage_id";
            tp.f_occupation_id = "f_occupation_id";
            tp.f_patient_race_id = "f_patient_race_id";
            tp.f_nation_id = "f_nation_id";
            tp.f_religion_id = "f_religion_id";
            tp.f_education_type_id = "f_education_type_id";
            tp.f_family_status_id = "f_family_status_id";
            tp.father_firstname = "father_firstname";
            tp.mother_firstname = "mother_firstname";
            tp.couple_firstname = "couple_firstname";
            tp.patient_move_in_date_time = "patient_move_in_date_time";
            tp.f_discharge_status_id = "f_discharge_status_id";
            tp.patient_discharge_date_time = "patient_discharge_date_time";
            tp.f_blood_group_id = "f_blood_group_id";
            tp.f_foreigner_id = "f_foreigner_id";
            tp.f_patient_area_status_id = "f_patient_area_status_id";
            tp.father_pid = "father_pid";
            tp.mather_pid = "mather_pid";
            tp.couple_pid = "couple_pid";
            tp.patient_community_status = "patient_community_status";
            tp.patient_private_doctor = "patient_private_doctor";
            tp.patient_pid = "patient_pid";
            tp.mother_lastname = "mother_lastname";
            tp.father_lastname = "father_lastname";
            tp.couple_lastname = "couple_lastname";
            tp.patient_phone_number = "patient_phone_number";
            tp.couple_f_relation_id = "couple_f_relation_id";
            tp.contact_phone_number = "contact_phone_number";
            tp.contact_sex_id = "contact_sex_id";
            tp.contact_house = "contact_house";
            tp.contact_moo = "contact_moo";
            tp.contact_changwat = "contact_changwat";
            tp.contact_amphur = "contact_amphur";
            tp.contact_tambon = "contact_tambon";
            tp.contact_road = "contact_road";
            tp.contact_firstname = "contact_firstname";
            tp.contact_lastname = "contact_lastname";
            tp.patient_birthday_true = "patient_birthday_true";
            tp.patient_merged = "patient_merged";
            tp.date_create = "date_create";
            tp.date_modi = "date_modi";
            tp.date_cancel = "date_cancel";
            tp.user_create = "user_create";
            tp.user_modi = "user_modi";
            tp.user_cancel = "user_cancel";
            tp.Active = "active";
            tp.drugallergy = "drugallergy";
            tp.language_for_print = "language_for_print";
            tp.mobile_phone = "mobile_phone";
            tp.contact_mobile_phone = "contact_mobile_phone";
            tp.has_home_in_pcu = "has_home_in_pcu";
            tp.t_health_family_id = "t_health_family_id";
            tp.other_country_address = "other_country_address";
            tp.is_other_country = "is_other_country";
            tp.contact_id = "contact_id";
            tp.contact_namet = "contact_namet";
            tp.contact_join_id = "contact_join_id";
            tp.contact_join_namet = "contact_join_namet";
            tp.ss_patient_hn = "ss_patient_hn";
            tp.patient_soi = "patient_soi";
            tp.patient_contact_soi = "patient_contact_soi";
            tp.status_chronic = "status_chronic";
            tp.status_hiv = "status_hiv";
            tp.patient_status_hiv = "patient_status_hiv";
            tp.contact_f_relation_id = "contact_f_relation_id";
            tp.remark1 = "remark1";
            tp.remark2 = "remark2";
            tp.t_patient_id = "t_patient_id";

            tp.pkField = "t_patient_id";
            tp.table = "t_patient";
        }
        private TPatient setData(TPatient p, DataTable dt)
        {
            p.Active = dt.Rows[0][tp.Active].ToString();
            p.contact_amphur = dt.Rows[0][tp.contact_amphur].ToString();
            p.contact_changwat = dt.Rows[0][tp.contact_changwat].ToString();
            p.contact_firstname = dt.Rows[0][tp.contact_firstname].ToString();
            p.contact_f_relation_id= dt.Rows[0][tp.contact_f_relation_id].ToString();
            p.contact_house = dt.Rows[0][tp.contact_house].ToString();
            p.contact_id= dt.Rows[0][tp.contact_id].ToString();
            p.contact_join_id= dt.Rows[0][tp.contact_join_id].ToString();
            p.contact_join_namet= dt.Rows[0][tp.contact_join_namet].ToString();
            p.contact_lastname= dt.Rows[0][tp.contact_lastname].ToString();

            p.contact_mobile_phone= dt.Rows[0][tp.contact_mobile_phone].ToString();
            p.contact_moo= dt.Rows[0][tp.contact_moo].ToString();
            p.contact_namet= dt.Rows[0][tp.contact_namet].ToString();
            p.contact_phone_number= dt.Rows[0][tp.contact_phone_number].ToString();
            p.contact_road= dt.Rows[0][tp.contact_road].ToString();
            p.contact_sex_id= dt.Rows[0][tp.contact_sex_id].ToString();
            p.contact_tambon= dt.Rows[0][tp.contact_tambon].ToString();
            p.couple_firstname= dt.Rows[0][tp.couple_firstname].ToString();
            p.couple_f_relation_id= dt.Rows[0][tp.couple_f_relation_id].ToString();
            p.couple_lastname= dt.Rows[0][tp.couple_lastname].ToString();

            p.couple_pid= dt.Rows[0][tp.couple_pid].ToString();
            p.date_cancel= dt.Rows[0][tp.date_cancel].ToString();
            p.date_create= dt.Rows[0][tp.date_create].ToString();
            p.date_modi= dt.Rows[0][tp.date_modi].ToString();
            p.drugallergy= dt.Rows[0][tp.drugallergy].ToString();
            p.father_firstname= dt.Rows[0][tp.father_firstname].ToString();
            p.father_lastname= dt.Rows[0][tp.father_lastname].ToString();
            p.father_pid= dt.Rows[0][tp.father_pid].ToString(); ;
            p.f_blood_group_id= dt.Rows[0][tp.f_blood_group_id].ToString();
            p.f_discharge_status_id= dt.Rows[0][tp.f_discharge_status_id].ToString();

            p.f_education_type_id= dt.Rows[0][tp.f_education_type_id].ToString();
            p.f_family_status_id= dt.Rows[0][tp.f_family_status_id].ToString();
            p.f_foreigner_id= dt.Rows[0][tp.f_foreigner_id].ToString();
            p.f_marriage_id= dt.Rows[0][tp.f_marriage_id].ToString();
            p.f_nation_id= dt.Rows[0][tp.f_nation_id].ToString();
            p.f_occupation_id= dt.Rows[0][tp.f_occupation_id].ToString();
            p.f_patient_area_status_id= dt.Rows[0][tp.f_patient_area_status_id].ToString();
            p.f_patient_prefix_id= dt.Rows[0][tp.f_patient_prefix_id].ToString();
            p.f_patient_race_id= dt.Rows[0][tp.f_patient_race_id].ToString();
            p.f_religion_id= dt.Rows[0][tp.f_religion_id].ToString();

            p.f_sex_id= dt.Rows[0][tp.f_sex_id].ToString();
            p.has_home_in_pcu= dt.Rows[0][tp.has_home_in_pcu].ToString();
            p.is_other_country= dt.Rows[0][tp.is_other_country].ToString();
            p.language_for_print = dt.Rows[0][tp.language_for_print].ToString();
            p.mather_pid= dt.Rows[0][tp.mather_pid].ToString();
            p.mobile_phone= dt.Rows[0][tp.mobile_phone].ToString();
            p.mother_firstname= dt.Rows[0][tp.mother_firstname].ToString();
            p.mother_lastname= dt.Rows[0][tp.mother_lastname].ToString();
            p.other_country_address= dt.Rows[0][tp.other_country_address].ToString();
            p.patient_amphur= dt.Rows[0][tp.patient_amphur].ToString();

            p.patient_birthday= dt.Rows[0][tp.patient_birthday].ToString();
            p.patient_birthday_true= dt.Rows[0][tp.patient_birthday_true].ToString();
            p.patient_changwat= dt.Rows[0][tp.patient_changwat].ToString();
            p.patient_community_status= dt.Rows[0][tp.patient_community_status].ToString();
            p.patient_contact_soi= dt.Rows[0][tp.patient_contact_soi].ToString();
            p.patient_discharge_date_time = dt.Rows[0][tp.patient_discharge_date_time].ToString();
            p.patient_firstname= dt.Rows[0][tp.patient_firstname].ToString();
            p.patient_hn= dt.Rows[0][tp.patient_hn].ToString();
            p.patient_house= dt.Rows[0][tp.patient_house].ToString();
            p.patient_lastname = dt.Rows[0][tp.patient_lastname].ToString();

            p.patient_merged= dt.Rows[0][tp.patient_merged].ToString();
            p.patient_moo= dt.Rows[0][tp.patient_moo].ToString();
            p.patient_move_in_date_time= dt.Rows[0][tp.patient_move_in_date_time].ToString();
            p.patient_phone_number= dt.Rows[0][tp.patient_phone_number].ToString();
            p.patient_pid= dt.Rows[0][tp.patient_pid].ToString();
            p.patient_private_doctor= dt.Rows[0][tp.patient_private_doctor].ToString();
            p.patient_road= dt.Rows[0][tp.patient_road].ToString();
            p.patient_soi= dt.Rows[0][tp.patient_soi].ToString();
            p.patient_status_hiv= dt.Rows[0][tp.patient_status_hiv].ToString();
            p.patient_tambon= dt.Rows[0][tp.patient_tambon].ToString();

            p.patient_xn= dt.Rows[0][tp.patient_xn].ToString();
            p.remark1= dt.Rows[0][tp.remark1].ToString();
            p.remark2= dt.Rows[0][tp.remark2].ToString();
            p.ss_patient_hn= dt.Rows[0][tp.ss_patient_hn].ToString();
            p.status_chronic= dt.Rows[0][tp.status_chronic].ToString();
            p.status_hiv= dt.Rows[0][tp.status_hiv].ToString();
            p.t_health_family_id= dt.Rows[0][tp.t_health_family_id].ToString();
            p.t_patient_id= dt.Rows[0][tp.t_patient_id].ToString();
            p.user_cancel= dt.Rows[0][tp.user_cancel].ToString();
            p.user_create= dt.Rows[0][tp.user_create].ToString();

            p.user_modi= dt.Rows[0][tp.user_modi].ToString();            

            return p;
        }
        public TPatient selectPk(String id)
        {
            TPatient p;
            String sql = "";
            DataTable dt = new DataTable();

            sql = "Select dtr.* " +
                "From " + tp.table + " dtr " +
                "Where dtr." + tp.pkField + "='" + id + "'";

            dt = conn.selectData(sql, "orc_ma");
            p = dt.Rows.Count > 0 ? setData(new TPatient(), dt) : new TPatient();

            return p;
        }
    }
}
