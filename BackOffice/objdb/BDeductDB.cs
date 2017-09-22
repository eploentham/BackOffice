using System;
using System.Collections.Generic;
using System.Data;
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
        private BDeduct setData(BDeduct p, DataTable dt)
        {
            p.deduct_number = dt.Rows[0][bd.deduct_number].ToString();
            p.deduct_description = dt.Rows[0][bd.deduct_description].ToString();
            p.deduct_method = dt.Rows[0][bd.deduct_method].ToString();
            p.b_deduct_id = dt.Rows[0][bd.b_deduct_id].ToString();
            p.Active = dt.Rows[0][bd.Active].ToString();

            return p;
        }
        private String insert(BDeduct p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.deduct_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bd.table + "(" + bd.deduct_number + "," + bd.deduct_description + "," +
                    bd.deduct_method + bd.Active + ") " +
                    "Values('" + p.deduct_number + "','" + p.deduct_description + "','" +
                    p.deduct_method + "','1') ";
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
