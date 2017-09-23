using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TResultLab:Persistent
    {
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String t_order_id { get; set; }
        public String result_lab_value { get; set; }
        public String result_lab_unit { get; set; }
        public String result_lab_staff_record { get; set; }
        public String record_date_time { get; set; }
        public String result_lab_name { get; set; }
        public String result_lab_active { get; set; }
        public String result_lab_complete { get; set; }
        public String b_item_id { get; set; }
        public String f_lab_result_type_id { get; set; }
        public String result_lab_max { get; set; }
        public String result_lab_min { get; set; }
        public String b_lab_result_group_id { get; set; }
        public String result_lab_index { get; set; }
        public String b_item_lab_result_id { get; set; }
        public String result_lab_normal_flag { get; set; }
        public String status_approved { get; set; }
        public String approved_staff_record { get; set; }
        public String result_lab_value_old { get; set; }
        public String status_approve { get; set; }
        public String result_lab_approve_staff { get; set; }
        public String result_lab_modify_staff { get; set; }
        public String result_lab_modify_date_time { get; set; }
        public String sort_lab { get; set; }
        public String t_result_lab_id { get; set; }
    }
}
