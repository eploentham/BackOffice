using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BDeductDB
    {
        BDeduct bd;
        ConnectDB conn;
        public BDeductDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bd = new BDeduct();
            bd.deduct_number = "deduct_number";
            bd.deduct_description = "deduct_description";
            bd.deduct_method = "deduct_method";
            bd.b_deduct_id = "b_deduct_id";
        }
    }
}
