using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BDeductConditionDB
    {
        BDeductCondition bdc;
        ConnectDB conn;
        public BDeductConditionDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bdc = new BDeductCondition();
            bdc.b_deduct_id = "";
            bdc.b_item_subgroup_id = "";
            bdc.deduct_condition_adjustment = "";
            bdc.deduct_condition_draw = "";
            bdc.b_deduct_condition_id = "";
        }
    }
}
