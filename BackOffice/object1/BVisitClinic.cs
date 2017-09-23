using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BVisitClinic:Persistent
    {
        public String visit_clinic_number { get; set; }
        public String visit_clinic_description { get; set; }
        public String f_service_group_id { get; set; }
        public String visit_clinic_active { get; set; }
        public String b_visit_clinic_id { get; set; }
    }
}
