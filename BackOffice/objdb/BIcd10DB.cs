using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BIcd10DB
    {
        BIcd10 icd10;
        ConnectDB conn;
        public BIcd10DB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            icd10 = new BIcd10();
            icd10.active = "active";
            icd10.icd10_number = "icd10_number";
            icd10.icd10_description = "icd10_description";
            icd10.icd10_other_description = "icd10_other_description";
            icd10.icd10_generate_code = "icd10_generate_code";
            icd10.active53 = "active53";
            icd10.active = "active";
            icd10.b_icd10_id = "b_icd10_id";

            icd10.pkField = "b_icd10_id";
            icd10.table = "b_icd10";
        }
        private BIcd10 setData(BIcd10 p, DataTable dt)
        {
            p.active = dt.Rows[0][icd10.active].ToString();
            p.icd10_number = dt.Rows[0][icd10.icd10_number].ToString();
            p.icd10_description = dt.Rows[0][icd10.icd10_description].ToString();
            p.icd10_other_description = dt.Rows[0][icd10.icd10_other_description].ToString();
            p.icd10_generate_code = dt.Rows[0][icd10.icd10_generate_code].ToString();
            p.active53 = dt.Rows[0][icd10.active53].ToString();
            p.active = dt.Rows[0][icd10.active].ToString();
            p.b_icd10_id = dt.Rows[0][icd10.b_icd10_id].ToString();

            return p;
        }
        private String insert(BIcd10 p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.icd10_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + icd10.table + "(" + icd10.icd10_number + "," + icd10.icd10_description + "," +
                    icd10.icd10_other_description + "," + icd10.icd10_generate_code + "," + icd10.active53  + icd10.active + ") " +
                    "Values('" + p.icd10_number + "','" + p.icd10_description + "','" +
                    p.icd10_other_description + "','" + p.icd10_generate_code + "','" + p.active53 + "','1') ";
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
