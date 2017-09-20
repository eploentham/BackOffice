using System;
using System.Collections.Generic;
using System.Data;
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
            to.Active = "active";
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

            to.pkField = "t_order_id";
            to.table = "t_order";
        }
        private TOrder setData(TOrder p, DataTable dt)
        {
            p.Active = dt.Rows[0][to.Active].ToString();
            p.b_item_16_group_id = dt.Rows[0][to.b_item_16_group_id].ToString();
            p.b_item_billing_subgroup_id = dt.Rows[0][to.b_item_billing_subgroup_id].ToString();
            p.b_item_id = dt.Rows[0][to.b_item_id].ToString();
            p.b_item_subgroup_id = dt.Rows[0][to.b_item_subgroup_id].ToString();
            p.doctor_id = dt.Rows[0][to.doctor_id].ToString();
            p.f_item_group_id = dt.Rows[0][to.f_item_group_id].ToString();
            p.f_order_status_id = dt.Rows[0][to.f_order_status_id].ToString();
            p.hight_alert = dt.Rows[0][to.hight_alert].ToString();
            p.lot_request_number = dt.Rows[0][to.lot_request_number].ToString();
            p.order_alert = dt.Rows[0][to.order_alert].ToString();
            p.order_approve_date_time = dt.Rows[0][to.order_approve_date_time].ToString();
            p.order_approve_staff = dt.Rows[0][to.order_approve_staff].ToString();
            p.order_cause_cancel_resultlab = dt.Rows[0][to.order_cause_cancel_resultlab].ToString();
            p.order_charge_complete = dt.Rows[0][to.order_charge_complete].ToString();
            p.order_common_name = dt.Rows[0][to.order_common_name].ToString();
            p.order_complete = dt.Rows[0][to.order_complete].ToString();
            p.order_continue = dt.Rows[0][to.order_continue].ToString();
            p.order_cost = dt.Rows[0][to.order_cost].ToString();
            p.order_date_time = dt.Rows[0][to.order_date_time].ToString();
            p.order_discontinue_date_time = dt.Rows[0][to.order_discontinue_date_time].ToString();
            p.order_dispense_date_time = dt.Rows[0][to.order_dispense_date_time].ToString();
            p.order_drug_allergy = dt.Rows[0][to.order_drug_allergy].ToString();
            p.order_end_time = dt.Rows[0][to.order_end_time].ToString();
            p.order_executed_date_time = dt.Rows[0][to.order_executed_date_time].ToString();
            p.order_home = dt.Rows[0][to.order_home].ToString();
            p.order_notice = dt.Rows[0][to.order_notice].ToString();
            p.order_operation_no = dt.Rows[0][to.order_operation_no].ToString();
            p.order_operation_status = dt.Rows[0][to.order_operation_status].ToString();
            p.order_price = dt.Rows[0][to.order_price].ToString();
            p.order_qty = dt.Rows[0][to.order_qty].ToString();
            p.order_refer_out = dt.Rows[0][to.order_refer_out].ToString();
            p.order_report_date_time = dt.Rows[0][to.order_report_date_time].ToString();
            p.order_request = dt.Rows[0][to.order_request].ToString();
            p.order_secret = dt.Rows[0][to.order_secret].ToString();
            p.order_service_point = dt.Rows[0][to.order_service_point].ToString();
            p.order_specified = dt.Rows[0][to.order_specified].ToString();
            p.order_specified_data = dt.Rows[0][to.order_specified_data].ToString();
            p.order_staff_discontinue = dt.Rows[0][to.order_staff_discontinue].ToString();
            p.order_staff_dispense = dt.Rows[0][to.order_staff_dispense].ToString();
            p.order_staff_execute = dt.Rows[0][to.order_staff_execute].ToString();
            p.order_staff_order = dt.Rows[0][to.order_staff_order].ToString();
            p.order_staff_report = dt.Rows[0][to.order_staff_report].ToString();
            p.order_staff_verify = dt.Rows[0][to.order_staff_verify].ToString();
            p.order_start_time = dt.Rows[0][to.order_start_time].ToString();
            p.order_status_doctor = dt.Rows[0][to.order_status_doctor].ToString();
            p.order_status_physical = dt.Rows[0][to.order_status_physical].ToString();
            p.order_time_check = dt.Rows[0][to.order_time_check].ToString();
            p.order_verify_date_time = dt.Rows[0][to.order_verify_date_time].ToString();
            p.result_lab_approve_staff = dt.Rows[0][to.result_lab_approve_staff].ToString();
            p.status_no_close_day_import = dt.Rows[0][to.status_no_close_day_import].ToString();
            p.status_print_report_item = dt.Rows[0][to.status_print_report_item].ToString();
            p.status_rate = dt.Rows[0][to.status_rate].ToString();
            p.t_order_id = dt.Rows[0][to.t_order_id].ToString();
            p.t_patient_id = dt.Rows[0][to.t_patient_id].ToString();
            p.t_visit_id = dt.Rows[0][to.t_visit_id].ToString();
            
            return p;
        }
        private String insert(TOrder p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.t_visit_id.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + to.table + "(" + to.Active + "," + to.b_item_16_group_id + "," + to.b_item_billing_subgroup_id + "," +
                    to.b_item_id + "," + to.b_item_subgroup_id + "," + to.doctor_id + "," +
                    to.f_item_group_id + "," + to.f_order_status_id + "," + to.hight_alert + "," +
                    to.lot_request_number + "," + to.order_alert + "," + to.order_approve_date_time + "," +
                    to.order_approve_staff + "," + to.order_cause_cancel_resultlab + "," + to.order_charge_complete + "," +
                    to.order_common_name + "," + to.order_complete + "," + to.order_continue + "," +
                    to.order_cost + "," + to.order_date_time + "," + to.order_discontinue_date_time + "," +
                    to.order_dispense_date_time + "," + to.order_drug_allergy + "," + to.order_end_time + "," +
                    to.order_executed_date_time + "," + to.order_home + "," + to.order_notice + "," +
                    to.order_operation_no + "," + to.order_operation_status + "," + to.order_price + "," +
                    to.order_qty + "," + to.order_refer_out + "," + to.order_report_date_time + "," +
                    to.order_request + "," + to.order_secret + "," + to.order_service_point + "," +
                    to.order_specified + "," + to.order_specified_data + "," + to.order_staff_discontinue + "," +
                    to.order_staff_dispense + "," + to.order_staff_execute + "," + to.order_staff_order + "," +
                    to.order_staff_report + "," + to.order_staff_verify + "," + to.order_start_time + "," +
                    to.order_status_doctor + "," + to.order_status_physical + "," + to.order_time_check + "," +
                    to.order_verify_date_time + "," + to.result_lab_approve_staff + "," + to.status_no_close_day_import + "," +
                    to.status_print_report_item + "," + to.status_rate + "," + to.t_order_id + "," +
                    to.t_patient_id + "," + to.t_visit_id + ") " +
                    "Values('" + p.Active + "','" + p.b_item_16_group_id + "','" + p.b_item_billing_subgroup_id + "','" +
                    p.b_item_id + "','" + p.b_item_subgroup_id + "','" + p.doctor_id + "','" +
                    p.f_item_group_id + "','" + p.f_order_status_id + "','" + p.hight_alert + "','" +
                    p.lot_request_number + "','" + p.order_alert + "','" + p.order_approve_date_time + "','" +
                    p.order_approve_staff + "','" + p.order_cause_cancel_resultlab + "','" + p.order_charge_complete + "','" +
                    p.order_common_name + "','" + p.order_complete + "','" + p.order_continue + "','" +
                    p.order_cost + "','" + p.order_date_time + "','" + p.order_discontinue_date_time + "','" +
                    p.order_dispense_date_time + "','" + p.order_drug_allergy + "','" + p.order_end_time + "','" +
                    p.order_executed_date_time + "','" + p.order_home + "','" + p.order_notice + "','" +
                    p.order_operation_no + "','" + p.order_operation_status + "','" + p.order_price + "','" +
                    p.order_qty + "','" + p.order_refer_out + "','" + p.order_report_date_time + "','" +
                    p.order_request + "','" + p.order_secret + "','" + p.order_service_point + "','" +
                    p.order_specified + "','" + p.order_specified_data + "','" + p.order_staff_discontinue + "','" +
                    p.order_staff_dispense + "','" + p.order_staff_execute + "','" + p.order_staff_order + "','" +
                    p.order_staff_report + "','" + p.order_staff_verify + "','" + p.order_start_time + "','" +
                    p.order_status_doctor + "','" + p.order_status_physical + "','" + p.order_time_check + "','" +
                    p.order_verify_date_time + "','" + p.result_lab_approve_staff + "','" + p.status_no_close_day_import + "','" +
                    p.status_print_report_item + "','" + p.status_rate + "','" + p.t_order_id + "','" +
                    p.t_patient_id + "','" + p.t_visit_id  + "') ";
                chk = conn.ExecuteNonQueryAutoIncrement(sql, "orc_ma");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }
            return chk;
        }
    }
}
