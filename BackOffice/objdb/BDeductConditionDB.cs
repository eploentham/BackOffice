using System;
using System.Collections.Generic;
using System.Data;
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
            bdc.b_deduct_id = "b_deduct_id";
            bdc.b_item_subgroup_id = "b_item_subgroup_id";
            bdc.deduct_condition_adjustment = "deduct_condition_adjustment";
            bdc.deduct_condition_draw = "deduct_condition_draw";
            bdc.b_deduct_condition_id = "b_deduct_condition_id";
            bdc.Active = "active";
        }
        private BDeductCondition setData(BDeductCondition p, DataTable dt)
        {
            p.b_deduct_id = dt.Rows[0][bdc.b_deduct_id].ToString();
            p.b_item_subgroup_id = dt.Rows[0][bdc.b_item_subgroup_id].ToString();
            p.deduct_condition_adjustment = dt.Rows[0][bdc.deduct_condition_adjustment].ToString();
            p.deduct_condition_draw = dt.Rows[0][bdc.deduct_condition_draw].ToString();
            p.b_deduct_condition_id = dt.Rows[0][bdc.b_deduct_condition_id].ToString();
            p.Active = dt.Rows[0][bdc.Active].ToString();

            return p;
        }
        private String insert(BDeductCondition p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.b_item_subgroup_id.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bdc.table + "(" + bdc.b_deduct_id + "," + bdc.b_item_subgroup_id + "," +
                    bdc.deduct_condition_adjustment + "," + bdc.deduct_condition_draw + "," + bdc.b_deduct_condition_id + "," + bdc.Active + ") " +
                    "Values('" + p.b_deduct_id + "','" + p.b_item_subgroup_id + "','" +
                    p.deduct_condition_adjustment + "','" + p.deduct_condition_draw + "','" + p.b_deduct_condition_id + "','1') ";
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
