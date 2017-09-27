using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TResultXrayDB
    {
        TResultXray trx;
        ConnectDB conn;
        public TResultXrayDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            trx = new TResultXray();
            trx.date_doctor_result = "date_doctor_result";
            trx.doctor_id = "doctor_id";
            trx.record_date_time = "record_date_time";
            trx.result_xray = "result_xray";
            trx.result_xray_active = "result_xray_active";
            trx.result_xray_complete = "result_xray_complete";
            trx.result_xray_description = "result_xray_description";
            trx.result_xray_film_size = "result_xray_film_size";
            trx.result_xray_notice = "result_xray_notice";
            trx.result_xray_staff_execute = "result_xray_staff_execute";
            trx.result_xray_staff_record = "result_xray_staff_record";
            trx.result_xray_time = "result_xray_time";
            trx.result_xray_xn = "result_xray_xn";
            trx.t_order_id = "t_order_id";
            trx.t_patient_id = "t_patient_id";
            trx.t_patient_xn_id = "t_patient_xn_id";
            trx.t_result_xray_id = "t_result_xray_id";
            trx.t_visit_id = "t_visit_id";

            trx.pkField = "t_result_xray_id";
            trx.table = "t_result_xray";
        }
    }
}
