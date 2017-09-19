using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatient:Persistent
    {
        public String patient_hn { get; set; }
        public String f_patient_prefix_id { get; set; }
        public String patient_firstname { get; set; }
        public String patient_lastname { get; set; }
        public String patient_xn { get; set; }
        public String f_sex_id { get; set; }
        public String patient_birthday { get; set; }
        public String patient_house { get; set; }
        public String patient_road { get; set; }
        public String patient_moo { get; set; }
        public String patient_tambon { get; set; }
        public String patient_amphur { get; set; }
        public String patient_changwat { get; set; }
        public String f_marriage_id { get; set; }
        public String f_occupation_id { get; set; }
        public String f_patient_race_id { get; set; }
        public String f_nation_id { get; set; }
        public String f_religion_id { get; set; }
        public String f_education_type_id { get; set; }
        public String f_family_status_id { get; set; }
        public String father_firstname { get; set; }
        public String mother_firstname { get; set; }
        public String couple_firstname { get; set; }
        public String patient_move_in_date_time { get; set; }
        public String f_discharge_status_id { get; set; }
        public String patient_discharge_date_time { get; set; }
        public String f_blood_group_id { get; set; }
        public String f_foreigner_id { get; set; }
        public String f_patient_area_status_id { get; set; }
        public String father_pid { get; set; }
        public String mather_pid { get; set; }
        public String couple_pid { get; set; }
        public String patient_community_status { get; set; }
        public String patient_private_doctor { get; set; }
        public String patient_pid { get; set; }
        public String mother_lastname { get; set; }
        public String father_lastname { get; set; }
        public String couple_lastname { get; set; }
        public String patient_phone_number { get; set; }
        public String couple_f_relation_id { get; set; }
        public String contact_phone_number { get; set; }
        public String contact_sex_id { get; set; }
        public String contact_house { get; set; }
        public String contact_moo { get; set; }
        public String contact_changwat { get; set; }
        public String contact_amphur { get; set; }
        public String contact_tambon { get; set; }
        public String contact_road { get; set; }
        public String contact_firstname { get; set; }
        public String contact_lastname { get; set; }
        public String patient_birthday_true { get; set; }
        public String patient_merged { get; set; }
        public String date_create { get; set; }
        public String date_modi { get; set; }
        public String date_cancel { get; set; }
        public String user_create { get; set; }
        public String user_modi { get; set; }
        public String user_cancel { get; set; }
        public String Active { get; set; }
        public String drugallergy { get; set; }
        public String language_for_print { get; set; }
        public String mobile_phone { get; set; }
        public String contact_mobile_phone { get; set; }
        public String has_home_in_pcu { get; set; }
        public String t_health_family_id { get; set; }
        public String other_country_address { get; set; }
        public String is_other_country { get; set; }
        public String contact_id { get; set; }
        public String contact_namet { get; set; }
        public String contact_join_id { get; set; }
        public String contact_join_namet { get; set; }
        public String ss_patient_hn { get; set; }
        public String patient_soi { get; set; }
        public String patient_contact_soi { get; set; }
        public String status_chronic { get; set; }
        public String status_hiv { get; set; }
        public String patient_status_hiv { get; set; }
        public String contact_f_relation_id { get; set; }
        public String remark1 { get; set; }
        public String remark2 { get; set; }
        public String t_patient_id { get; set; }
    }
}
