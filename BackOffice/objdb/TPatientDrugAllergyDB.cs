using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientDrugAllergyDB
    {
        TPatientDrugAllergy tpda;
        ConnectDB conn;
        public TPatientDrugAllergyDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tpda = new TPatientDrugAllergy();
            tpda.b_item_drug_standard_id = "b_item_drug_standard_id";
            tpda.b_item_id = "b_item_id"; ;
            tpda.patient_drug_allergy_common_name = "patient_drug_allergy_common_name";
            tpda.patient_drug_allergy_drug_standard_description = "patient_drug_allergy_drug_standard_description";
            tpda.patient_drug_allergy_record_date_time = "patient_drug_allergy_record_date_time";
            tpda.patient_drug_allergy_symptom = "patient_drug_allergy_symptom";
            tpda.t_patient_drug_allergy_id = "t_patient_drug_allergy_id";
            tpda.t_patient_id = "t_patient_id";
            
            tpda.pkField = "t_patient_drug_allergy_id";
            tpda.table = "t_patient_drug_allergy";
        }
    }
}
