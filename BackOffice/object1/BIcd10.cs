using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BIcd10:Persistent
    {
        public String icd10_number { get; set; }
        public String icd10_description { get; set; }
        public String icd10_other_description { get; set; }
        public String icd10_generate_code { get; set; }
        public String active53 { get; set; }
        public String active { get; set; }
        public String b_icd10_id { get; set; }
    }
}
