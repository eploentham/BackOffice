using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TChronicDB
    {
        TChronic tc;
        ConnectDB conn;
        public TChronicDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tc = new TChronic();
            tc.cancel_date_time = "cancel_date_time";
            tc.chronic_active = "chronic_active";
            tc.chronic_diagnosis_date = "chronic_diagnosis_date";
            tc.chronic_discharge_date = "chronic_discharge_date";
            tc.chronic_hn = "chronic_hn";
            tc.chronic_icd10 = "chronic_icd10";
            tc.chronic_notice = "chronic_notice";
            tc.chronic_site_treat = "chronic_site_treat";
            tc.chronic_survey_date = "chronic_survey_date";
            tc.chronic_vn = "chronic_vn";
            tc.f_chronic_discharge_status_id = "f_chronic_discharge_status_id";
            tc.modify_date_time = "modify_date_time";
            tc.modify_date_time = "modify_date_time";
            tc.record_date_time = "record_date_time";
            tc.staff_cancel = "staff_cancel";
            tc.staff_modify = "staff_modify";
            tc.staff_record = "staff_record";
            tc.t_chronic_id = "t_chronic_id";
            tc.t_health_family_id = "t_health_family_id";
            tc.t_patient_id = "t_patient_id";
            tc.t_visit_id = "t_visit_id";

            tc.pkField = "t_chronic_id";
            tc.table = "t_chronic";
        }
    }
}
