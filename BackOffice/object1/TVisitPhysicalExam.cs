using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TVisitPhysicalExam:Persistent
    {
        public String visit_physical_exam_body { get; set; }
        public String visit_physical_exam_detail { get; set; }
        public String t_visit_id { get; set; }
        public String t_patient_id { get; set; }
        public String visit_physical_exam_staff_execute { get; set; }
        public String record_date_time { get; set; }
        public String t_visit_physical_exam_id { get; set; }
    }
}
