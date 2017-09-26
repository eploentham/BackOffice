using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FOrderStatusDB
    {
        FOrderStatus fos;
        ConnectDB conn;
        public FOrderStatusDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fos = new FOrderStatus();
            fos.f_order_status_id = "f_order_status_id";
            fos.order_status_description = "order_status_description";

            fos.pkField = "f_order_status_id";
            fos.table = "f_order_status";
        }
    }
}
