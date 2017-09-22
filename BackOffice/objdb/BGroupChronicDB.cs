using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.objdb
{
    class BGroupChronicDB
    {
        BGroupChronic bgc;
        ConnectDB conn;

        public BGroupChronicDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bgc = new BGroupChronic();
            bgc.b_group_chronic_id = "b_group_chronic_id";
            bgc.group_chronic_active = "group_chronic_active"; ;
            bgc.group_chronic_description_en = "group_chronic_description_en";
            bgc.group_chronic_description_th = "group_chronic_description_th"; ;
            bgc.group_chronic_number = "group_chronic_number";

            bgc.pkField = "b_group_chronic_id";
            bgc.table = "b_group_chronic";
        }
        private BGroupChronic setData(BGroupChronic p, DataTable dt)
        {
            p.b_group_chronic_id = dt.Rows[0][bgc.b_group_chronic_id].ToString();
            p.group_chronic_active = dt.Rows[0][bgc.group_chronic_active].ToString();
            p.group_chronic_description_en = dt.Rows[0][bgc.group_chronic_description_en].ToString();
            p.group_chronic_description_th = dt.Rows[0][bgc.group_chronic_description_th].ToString();
            p.group_chronic_number = dt.Rows[0][bgc.group_chronic_number].ToString();            

            return p;
        }
        private String insert(BGroupChronic p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.group_chronic_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bgc.table + "(" + bgc.group_chronic_description_en + "," + bgc.group_chronic_description_th + "," +
                    bgc.group_chronic_number + bgc.group_chronic_active + ") " +
                    "Values('" + p.group_chronic_description_en + "','" + p.group_chronic_description_th + "','" +
                    p.group_chronic_number + "','1') ";
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
