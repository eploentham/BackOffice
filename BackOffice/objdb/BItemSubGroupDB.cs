using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemSubGroupDB
    {
        BItemSubGroup bisg;
        ConnectDB conn;
        public BItemSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bisg = new BItemSubGroup();
            bisg.item_subgroup_number = "item_subgroup_number";
            bisg.item_subgroup_description = "item_subgroup_description";
            bisg.f_item_group_id = "f_item_group_id";
            bisg.item_subgroup_active = "item_subgroup_active";
            bisg.b_item_subgroup_id = "b_item_subgroup_id";
        }
        private BItemSubGroup setData(BItemSubGroup p, DataTable dt)
        {
            p.item_subgroup_number = dt.Rows[0][bisg.item_subgroup_number].ToString();
            p.item_subgroup_description = dt.Rows[0][bisg.item_subgroup_description].ToString();
            p.f_item_group_id = dt.Rows[0][bisg.f_item_group_id].ToString();
            p.item_subgroup_active = dt.Rows[0][bisg.item_subgroup_active].ToString();
            p.b_item_subgroup_id = dt.Rows[0][bisg.b_item_subgroup_id].ToString();

            return p;
        }
        private String insert(BItemSubGroup p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.item_subgroup_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bisg.table + "(" + bisg.item_subgroup_number + "," + bisg.item_subgroup_description + "," +
                    bisg.f_item_group_id + bisg.item_subgroup_active + ") " +
                    "Values('" + p.item_subgroup_number + "','" + p.item_subgroup_description + "','" +
                    p.f_item_group_id + "','1') ";
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
