using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItem16GroupDB
    {
        BItem16Group bi16g; 
        ConnectDB conn;
        public BItem16GroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bi16g = new BItem16Group();
            bi16g.item_16_group_number = "item_16_group_number";
            bi16g.item_16_group_description = "item_16_group_description";
            bi16g.item_16_group_active = "item_16_group_active";
            bi16g.billgroup_id = "billgroup_id";
            bi16g.b_item_16_group_id = "b_item_16_group_id";
        }
        private BItem16Group setData(BItem16Group p, DataTable dt)
        {
            p.item_16_group_number = dt.Rows[0][bi16g.item_16_group_number].ToString();
            p.item_16_group_description = dt.Rows[0][bi16g.item_16_group_description].ToString();
            p.item_16_group_active = dt.Rows[0][bi16g.item_16_group_active].ToString();
            p.billgroup_id = dt.Rows[0][bi16g.billgroup_id].ToString();
            p.b_item_16_group_id = dt.Rows[0][bi16g.b_item_16_group_id].ToString();

            return p;
        }
        private String insert(BItem16Group p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.item_16_group_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bi16g.table + "(" + bi16g.item_16_group_number + "," + bi16g.item_16_group_description + "," +
                    bi16g.billgroup_id + "," + bi16g.b_item_16_group_id + bi16g.item_16_group_active + ") " +
                    "Values('" + p.item_16_group_number + "','" + p.item_16_group_description + "','" +
                    p.billgroup_id + "','" + p.b_item_16_group_id + "','1') ";
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
