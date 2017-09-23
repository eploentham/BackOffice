using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TPatientDrugAllergy:Persistent
    {
        public String t_patient_id { get; set; }
        public String b_item_id { get; set; }
        public String patient_drug_allergy_common_name { get; set; }
        public String patient_drug_allergy_symptom { get; set; }
        public String b_item_drug_standard_id { get; set; }
        public String patient_drug_allergy_drug_standard_description { get; set; }
        public String patient_drug_allergy_record_date_time { get; set; }
        public String t_patient_drug_allergy_id { get; set; }
    }
}
