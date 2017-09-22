using System;
using System.Collections.Generic;
using System.Data;
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
        private BItem setData(BItem p, DataTable dt)
        {
            p.item_number = dt.Rows[0][bi.item_number].ToString();
            p.item_common_name = dt.Rows[0][bi.item_common_name].ToString();
            p.item_trade_name = dt.Rows[0][bi.item_trade_name].ToString();
            p.item_nick_name = dt.Rows[0][bi.item_nick_name].ToString();
            p.item_active = dt.Rows[0][bi.item_active].ToString();
            p.b_item_subgroup_id = dt.Rows[0][bi.b_item_subgroup_id].ToString();
            p.b_item_billing_subgroup_id = dt.Rows[0][bi.b_item_billing_subgroup_id].ToString();
            p.item_printable = dt.Rows[0][bi.item_printable].ToString();
            p.item_secret = dt.Rows[0][bi.item_secret].ToString();
            p.b_item_16_group_id = dt.Rows[0][bi.b_item_16_group_id].ToString();

            p.item_mcode = dt.Rows[0][bi.item_mcode].ToString();
            p.item_descriptione = dt.Rows[0][bi.item_descriptione].ToString();
            p.item_status_doctor = dt.Rows[0][bi.item_status_doctor].ToString();
            p.r_rp1253_adpcode_id = dt.Rows[0][bi.r_rp1253_adpcode_id].ToString();
            p.item_unit_packing_qty = dt.Rows[0][bi.item_unit_packing_qty].ToString();
            p.f_item_lab_type_id = dt.Rows[0][bi.f_item_lab_type_id].ToString();
            p.r_rp1253_charitem_id = dt.Rows[0][bi.r_rp1253_charitem_id].ToString();
            p.item_specified = dt.Rows[0][bi.item_specified].ToString();
            p.cscode = dt.Rows[0][bi.cscode].ToString();
            p.row_color = dt.Rows[0][bi.row_color].ToString();

            p.item_alert = dt.Rows[0][bi.item_alert].ToString();
            p.sort_lab = dt.Rows[0][bi.sort_lab].ToString();
            p.b_item_id = dt.Rows[0][bi.b_item_id].ToString();

            return p;
        }
        private String insert(BItem p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.item_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.item_active = "1";
                sql = "Insert Into " + bi.table + "(" + bi.item_active + "," + bi.item_number + "," + bi.item_common_name + "," +
                    bi.item_trade_name + "," + bi.item_nick_name + "," + bi.b_item_subgroup_id + "," +
                    bi.b_item_billing_subgroup_id + "," + bi.item_printable + "," + bi.item_secret + "," +
                    bi.b_item_16_group_id + "," + bi.item_mcode + "," + bi.item_descriptione + "," +
                    bi.item_status_doctor + "," + bi.r_rp1253_adpcode_id + "," + bi.item_unit_packing_qty + "," +
                    bi.f_item_lab_type_id + "," + bi.r_rp1253_charitem_id + "," + bi.item_specified + "," +
                    bi.cscode + "," + bi.row_color + "," + bi.item_alert + "," +
                    bi.sort_lab  + ") " +
                    "Values('" + p.item_active + "','" + p.item_number + "','" + p.item_common_name + "','" +
                    p.item_trade_name + "','" + p.item_nick_name + "','" + p.b_item_subgroup_id + "','" +
                    p.b_item_billing_subgroup_id + "','" + p.item_printable + "','" + p.item_secret + "','" +
                    p.b_item_16_group_id + "','" + p.item_mcode + "','" + p.item_descriptione + "','" +
                    p.item_status_doctor + "','" + p.r_rp1253_adpcode_id + "','" + p.item_unit_packing_qty + "','" +
                    p.f_item_lab_type_id + "','" + p.r_rp1253_charitem_id + "','" + p.item_specified + "','" +
                    p.cscode + "','" + p.row_color + "','" + p.item_alert + "','" +
                    p.sort_lab + "') ";
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
