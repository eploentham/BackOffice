using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientRiskFactorDB
    {
        TPatientRiskFactor tprf;
        ConnectDB conn;
        public TPatientRiskFactorDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tprf = new TPatientRiskFactor();
            tprf.patient_risk_factor_description = "patient_risk_factor_description";
            tprf.patient_risk_factor_record_date_time = "patient_risk_factor_record_date_time";
            tprf.patient_risk_factor_staff_record = "patient_risk_factor_staff_record";
            tprf.patient_risk_factor_topic = "patient_risk_factor_topic";
            tprf.t_patient_id = "t_patient_id";
            tprf.t_patient_risk_factor_id = "t_patient_risk_factor_id";

            tprf.pkField = "t_patient_risk_factor_id";
            tprf.table = "t_patient_risk_factor";
        }
    }
}
