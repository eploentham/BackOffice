using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemSetDB
    {
        BItemSet bis;
        ConnectDB conn;
        public BItemSetDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bis = new BItemSet();
            bis.b_item_group_id = "b_item_group_id";
            bis.b_item_id = "b_item_id";
            bis.item_set_status = "item_set_status";
            bis.b_item_set_id = "b_item_set_id";
            bis.item_price = "item_price";
            bis.Active = "active";
        }
        private BItemSet setData(BItemSet p, DataTable dt)
        {
            p.b_item_group_id = dt.Rows[0][bis.b_item_group_id].ToString();
            p.b_item_id = dt.Rows[0][bis.b_item_id].ToString();
            p.item_set_status = dt.Rows[0][bis.item_set_status].ToString();
            p.b_item_set_id = dt.Rows[0][bis.b_item_set_id].ToString();
            p.item_price = dt.Rows[0][bis.item_price].ToString();
            p.Active = dt.Rows[0][bis.Active].ToString();

            return p;
        }
        private String insert(BItemSet p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.b_item_id.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bis.table + "(" + bis.b_item_group_id + "," + bis.b_item_id + "," +
                    bis.item_set_status + "," + bis.item_price  + bis.Active + ") " +
                    "Values('" + p.b_item_group_id + "','" + p.b_item_id + "','" +
                    p.item_set_status + "','" + p.item_price  + "','1') ";
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
