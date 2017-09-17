using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TOrderDB
    {
        TOrder to;
        ConnectDB conn;

        public TOrderDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            to = new TOrder();
            to.t_visit_id = "t_visit_id";
            to.b_item_id = "b_item_id";
            to.order_staff_verify = "order_staff_verify";
            to.order_verify_date_time = "order_verify_date_time";
            to.order_staff_execute = "order_staff_execute";
            to.order_executed_date_time = "order_executed_date_time";
            to.order_staff_discontinue = "order_staff_discontinue";
            to.order_discontinue_date_time = "order_discontinue_date_time";
            to.order_staff_dispense = "order_staff_dispense";
            to.order_dispense_date_time = "order_dispense_date_time";
            to.order_service_point = "order_service_point";
            to.b_item_subgroup_id = "b_item_subgroup_id";
            to.order_charge_complete = "order_charge_complete";
            to.f_order_status_id = "f_order_status_id";
            to.order_secret = "order_secret";
            to.order_continue = "order_continue";
            to.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
            to.t_patient_id = "t_patient_id";
            to.f_item_group_id = "f_item_group_id";
            to.order_common_name = "order_common_name";
            to.order_refer_out = "order_refer_out";
            to.order_request = "order_request";
            to.order_staff_order = "order_staff_order";
            to.order_date_time = "order_date_time";
            to.order_complete = "order_complete";
            to.order_cost = "order_cost";
            to.order_notice = "order_notice";
            to.order_drug_allergy = "order_drug_allergy";
            to.order_cause_cancel_resultlab = "order_cause_cancel_resultlab";
            to.order_staff_report = "order_staff_report";
            to.order_report_date_time = "order_report_date_time";
            to.order_home = "order_home";
            to.b_item_16_group_id = "b_item_16_group_id";
            to.doctor_id = "doctor_id";
            to.hight_alert = "hight_alert";
            to.order_specified = "order_specified";
            to.order_specified_data = "order_specified_data";
            to.order_time_check = "order_time_check";
            to.order_status_doctor = "order_status_doctor";
            to.result_lab_approve_staff = "result_lab_approve_staff";
            to.order_alert = "order_alert";
            to.order_approve_date_time = "order_approve_date_time";
            to.order_approve_staff = "order_approve_staff";
            to.status_print_report_item = "status_print_report_item";
            to.order_start_time = "order_start_time";
            to.order_end_time = "order_end_time";
            to.status_rate = "status_rate";
            to.order_operation_no = "order_operation_no";
            to.order_operation_status = "order_operation_status";
            to.status_no_close_day_import = "status_no_close_day_import";
            to.lot_request_number = "lot_request_number";
            to.order_status_physical = "order_status_physical";
            to.t_order_id = "t_order_id";
            to.order_price = "order_price";
            to.order_qty = "order_qty";
        }
    }
}
