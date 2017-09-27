using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TResultXraySizeDB
    {
        TResultXraySize trxs;
        ConnectDB conn;
        public TResultXraySizeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            trxs = new TResultXraySize();
            trxs.f_xray_film_size_id = "f_xray_film_size_id";
            trxs.result_xray_size_active = "result_xray_size_active";
            trxs.result_xray_size_add_order = "result_xray_size_add_order";
            trxs.result_xray_size_damaging_xray_film_amount = "result_xray_size_damaging_xray_film_amount";
            trxs.result_xray_size_price = "result_xray_size_price";
            trxs.result_xray_size_staff_record = "result_xray_size_staff_record";
            trxs.t_order_id = "t_order_id";
            trxs.t_result_xray_id = "t_result_xray_id";
            trxs.t_result_xray_size_id = "t_result_xray_size_id";
            trxs.t_visit_id = "t_visit_id";
            trxs.xray_film_amount = "xray_film_amount";

            trxs.pkField = "t_result_xray_size_id";
            trxs.table = "t_result_xray_size";
        }
    }
}
