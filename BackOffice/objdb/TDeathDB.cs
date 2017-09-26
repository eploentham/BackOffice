using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TDeathDB
    {
        TDeath td;
        ConnectDB conn;
        public TDeathDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            td = new TDeath();
            td.death_active = "death_active";
            td.death_cause = "death_cause";
            td.death_comorbidity = "death_comorbidity";
            td.death_complication = "death_complication";
            td.death_date_time = "death_date_time";
            td.death_external_cause_of_injury = "death_external_cause_of_injury";
            td.death_gravida_week = "death_gravida_week";
            td.death_hn = "death_hn";
            td.death_others = "death_others";
            td.death_pregnant = "death_pregnant";
            td.death_primary_diagnosis = "death_primary_diagnosis";
            td.death_site = "death_site";
            td.death_staff_record = "death_staff_record";
            td.death_vn = "death_vn";
            td.t_death_id = "t_death_id";
            td.t_health_family_id = "t_health_family_id";
            td.t_patient_id = "t_patient_id";
            td.t_visit_id = "t_visit_id";

            td.pkField = "t_death_id";
            td.table = "t_death";
        }
    }
}
