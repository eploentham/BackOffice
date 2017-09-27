using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TResultXrayPositionDB
    {
        TResultXrayPosition trxp;
        ConnectDB conn;
        public TResultXrayPositionDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            trxp = new TResultXrayPosition();
            trxp.b_xray_position_id = "b_xray_position_id";
            trxp.b_xray_side_id = "b_xray_side_id";
            trxp.result_xray_position_active = "result_xray_position_active";
            trxp.result_xray_position_ffd = "result_xray_position_ffd";
            trxp.result_xray_position_kv = "result_xray_position_kv";
            trxp.result_xray_position_ma = "result_xray_position_ma";
            trxp.result_xray_position_mas = "result_xray_position_mas";
            trxp.result_xray_position_second = "result_xray_position_second";
            trxp.t_order_id = "t_order_id";
            trxp.t_result_xray_id = "t_result_xray_id";
            trxp.t_result_xray_position_id = "t_result_xray_position_id";
            trxp.t_result_xray_size_id = "t_result_xray_size_id";
            trxp.t_visit_id = "t_visit_id";

            trxp.pkField = "t_result_xray_position_id";
            trxp.table = "t_result_xray_position";
        }
    }
}
