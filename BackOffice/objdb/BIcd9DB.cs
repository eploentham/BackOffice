using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BIcd9DB
    {
        BIcd9 icd9;
        ConnectDB conn;
        public BIcd9DB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            icd9 = new BIcd9();
            icd9.active = "active";
            icd9.b_icd9_id = "b_icd9_id";
            icd9.cost = "cost";
            icd9.icd9_description = "icd9_description";
            icd9.icd9_number = "icd9_number";
            icd9.icd9_other_description = "icd9_other_description";
            icd9.icd_10_tm = "icd_10_tm";

            icd9.pkField = "b_icd9_id";
            icd9.table = "b_icd9";
        }
        private BIcd9 setData(BIcd9 p, DataTable dt)
        {
            p.active = dt.Rows[0][icd9.active].ToString();
            p.b_icd9_id = dt.Rows[0][icd9.b_icd9_id].ToString();
            p.cost = dt.Rows[0][icd9.cost].ToString();
            p.icd9_description = dt.Rows[0][icd9.icd9_description].ToString();
            p.icd9_number = dt.Rows[0][icd9.icd9_number].ToString();
            p.icd9_other_description = dt.Rows[0][icd9.icd9_other_description].ToString();
            p.icd_10_tm = dt.Rows[0][icd9.icd_10_tm].ToString();

            return p;
        }
        private String insert(BIcd9 p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.icd9_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + icd9.table + "(" + icd9.cost + "," + icd9.icd9_description + "," +
                    icd9.icd9_number + "," + icd9.icd9_other_description + "," + icd9.icd_10_tm + icd9.active + ") " +
                    "Values('" + p.cost + "','" + p.icd9_description + "','" +
                    p.icd9_number + "','" + p.icd9_other_description + "','" + p.icd_10_tm + "','1') ";
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
