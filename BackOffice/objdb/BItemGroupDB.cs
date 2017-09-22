using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemGroupDB
    {
        BItemGroup big;
        ConnectDB conn;
        public BItemGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            big = new BItemGroup();
            big.item_group_number = "item_group_number";
            big.item_group_description = "item_group_description";
            big.item_group_staff_owner = "item_group_staff_owner";
            big.item_group_status = "item_group_status";
            big.item_group = "item_group";
            big.b_item_group_id = "b_item_group_id";
            big.item_price = "item_price";
            big.Active = "active";
        }
        private BItemGroup setData(BItemGroup p, DataTable dt)
        {
            p.item_group_number = dt.Rows[0][big.item_group_number].ToString();
            p.item_group_description = dt.Rows[0][big.item_group_description].ToString();
            p.item_group_staff_owner = dt.Rows[0][big.item_group_staff_owner].ToString();
            p.item_group_status = dt.Rows[0][big.item_group_status].ToString();
            p.item_group = dt.Rows[0][big.item_group].ToString();
            p.b_item_group_id = dt.Rows[0][big.b_item_group_id].ToString();
            p.item_price = dt.Rows[0][big.item_price].ToString();
            p.Active = dt.Rows[0][big.Active].ToString();

            return p;
        }
        private String insert(BItemGroup p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.item_group_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + big.table + "(" + big.item_group_number + "," + big.item_group_description + "," +
                    big.item_group_staff_owner + "," + big.item_group_status + "," + big.item_group + "," + 
                    big.b_item_group_id + "," + big.item_price + big.Active + ") " +
                    "Values('" + p.item_group_number + "','" + p.item_group_description + "','" +
                    p.item_group_staff_owner + "','" + p.item_group_status + "','" + p.item_group + "','" + 
                    p.b_item_group_id + "','" + p.item_price + "','" + "','1') ";
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
