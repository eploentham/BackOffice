using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TOperation:Persistent
    {
        public String t_visit_id { get; set; }
        public String operation_no { get; set; }
        public String operation_doctor { get; set; }
        public String operation_doctor_immediately { get; set; }
        public String operation_date_time { get; set; }
        public String operation_run_time { get; set; }
        public String operation_room { get; set; }
        public String operation_comment { get; set; }
        public String operation_method { get; set; }
        public String operation_weight { get; set; }
        public String operation_height { get; set; }
        public String operation_npo_date_time { get; set; }
        public String operation_sender { get; set; }
        public String operation_set_staff { get; set; }
        public String operation_appiontment_date_time { get; set; }
        public String t_operation_id { get; set; }
    }
}
