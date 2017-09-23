using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TResulyXray:Persistent
    {
        public String result_xray_xn { get; set; }
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String result_xray { get; set; }
        public String result_xray_film_size { get; set; }
        public String result_xray_staff_execute { get; set; }
        public String record_date_time { get; set; }
        public String result_xray_description { get; set; }
        public String t_order_id { get; set; }
        public String result_xray_notice { get; set; }
        public String result_xray_staff_record { get; set; }
        public String result_xray_active { get; set; }
        public String result_xray_complete { get; set; }
        public String t_patient_xn_id { get; set; }
        public String result_xray_time { get; set; }
        public String date_doctor_result { get; set; }
        public String doctor_id { get; set; }
        public String t_result_xray_id { get; set; }
    }
}
