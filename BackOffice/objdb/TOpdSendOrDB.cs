using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TOpdSendOrDB
    {
        TOpdSendOR toso;
        ConnectDB conn;
        public TOpdSendOrDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            toso = new TOpdSendOR();
            toso.opd_send_or_appiontment_date_time = "opd_send_or_appiontment_date_time";
            toso.opd_send_or_comment = "opd_send_or_comment";
            toso.opd_send_or_date_time = "opd_send_or_date_time";
            toso.opd_send_or_doctor = "opd_send_or_doctor";
            toso.opd_send_or_doctor_immediately = "opd_send_or_doctor_immediately";
            toso.opd_send_or_height = "opd_send_or_height";
            toso.opd_send_or_method = "opd_send_or_method";
            toso.opd_send_or_no = "opd_send_or_no";
            toso.opd_send_or_npo_date_time = "opd_send_or_npo_date_time";
            toso.opd_send_or_room = "opd_send_or_room";
            toso.opd_send_or_run_time = "opd_send_or_run_time";
            toso.opd_send_or_sender = "opd_send_or_sender";
            toso.opd_send_or_set_staff = "opd_send_or_set_staff";
            toso.opd_send_or_weight = "opd_send_or_weight";
            toso.t_opd_send_or_id = "t_opd_send_or_id";
            toso.t_visit_id = "t_visit_id";

            toso.pkField = "t_opd_send_or_id";
            toso.table = "t_opd_send_or";

        }
    }
}
