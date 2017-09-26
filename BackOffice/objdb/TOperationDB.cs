using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TOperationDB
    {
        TOperation to;
        ConnectDB conn;
        public TOperationDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            to = new TOperation();
            to.operation_appiontment_date_time = "operation_appiontment_date_time";
            to.operation_comment = "operation_comment";
            to.operation_date_time = "operation_date_time";
            to.operation_doctor = "operation_doctor";
            to.operation_doctor_immediately = "operation_doctor_immediately";
            to.operation_height = "operation_height";
            to.operation_method = "operation_method";
            to.operation_no = "operation_no";
            to.operation_npo_date_time = "operation_npo_date_time";
            to.operation_room = "operation_room";
            to.operation_run_time = "operation_run_time";
            to.operation_sender = "operation_sender";
            to.operation_set_staff = "operation_set_staff";
            to.operation_weight = "operation_weight";
            to.t_operation_id = "t_operation_id";
            to.t_visit_id = "t_visit_id";

            to.pkField = "t_operation_id";
            to.table = "t_operation";
        }
    }
}
