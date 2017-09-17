using System;
using System.Collections.Generic;
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
            tp.active = "active";
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
        }
    }
}
