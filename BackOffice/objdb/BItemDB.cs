using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemDB
    {
        BItem bi;
        ConnectDB conn;

        public BItemDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bi = new BItem();
            bi.item_number = "item_number";
            bi.item_common_name = "item_common_name";
            bi.item_trade_name = "item_trade_name";
            bi.item_nick_name = "item_nick_name";
            bi.item_active = "item_active";
            bi.b_item_subgroup_id = "b_item_subgroup_id";
            bi.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
            bi.item_printable = "item_printable";
            bi.item_secret = "item_secret";
            bi.b_item_16_group_id = "b_item_16_group_id";
            bi.item_mcode = "item_mcode";
            bi.item_descriptione = "item_descriptione";
            bi.item_status_doctor = "item_status_doctor";
            bi.r_rp1253_adpcode_id = "r_rp1253_adpcode_id";
            bi.item_unit_packing_qty = "item_unit_packing_qty";
            bi.f_item_lab_type_id = "f_item_lab_type_id";
            bi.r_rp1253_charitem_id = "r_rp1253_charitem_id";
            bi.item_specified = "item_specified";
            bi.cscode = "cscode";
            bi.row_color = "row_color";
            bi.item_alert = "item_alert";
            bi.sort_lab = "sort_lab";
            bi.b_item_id = "b_item_id";
        }
    }
}
