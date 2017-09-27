using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TResultLabDB
    {
        TResultLab trl;
        ConnectDB conn;
        public TResultLabDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            trl = new TResultLab();
            trl.approved_staff_record = "approved_staff_record";
            trl.b_item_id = "b_item_id";
            trl.b_item_lab_result_id = "b_item_lab_result_id";
            trl.b_lab_result_group_id = "b_lab_result_group_id";
            trl.f_lab_result_type_id = "f_lab_result_type_id";
            trl.record_date_time = "record_date_time";
            trl.result_lab_active = "result_lab_active";
            trl.result_lab_approve_staff = "result_lab_approve_staff";
            trl.result_lab_complete = "result_lab_complete";
            trl.result_lab_index = "result_lab_index";
            trl.result_lab_max = "result_lab_max";
            trl.result_lab_min = "result_lab_min";
            trl.result_lab_modify_date_time = "result_lab_modify_date_time";
            trl.result_lab_modify_staff = "result_lab_modify_staff";
            trl.result_lab_name = "result_lab_name";
            trl.result_lab_normal_flag = "result_lab_normal_flag";
            trl.result_lab_staff_record = "result_lab_staff_record";
            trl.result_lab_unit = "result_lab_unit";
            trl.result_lab_value = "result_lab_value";
            trl.result_lab_value_old = "result_lab_value_old";
            trl.sort_lab = "sort_lab";
            trl.status_approve = "status_approve";
            trl.status_approved = "status_approved";
            trl.t_order_id = "t_order_id";
            trl.t_patient_id = "t_patient_id";
            trl.t_result_lab_id = "t_result_lab_id";
            trl.t_visit_id = "t_visit_id";

            trl.pkField = "t_result_lab_id";
            trl.table = "t_result_lab";
        }
    }
}
