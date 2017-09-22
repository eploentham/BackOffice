using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemPriceDB
    {
        BItemPrice bip;
        ConnectDB conn;
        public BItemPriceDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bip = new BItemPrice();
            bip.item_price_number = "item_price_number";
            bip.b_item_id = "b_item_id";
            bip.item_price_active_date = "item_price_active_date";
            bip.item_price_cost = "item_price_cost";
            bip.b_item_price_id = "b_item_price_id";
            bip.item_price = "item_price";
            bip.item_price_opd = "item_price_opd";
            bip.item_price_ipd = "item_price_ipd";
            bip.date_end = "date_end";
            bip.date_start = "date_start";
            bip.Active = "active";
        }
        private BItemPrice setData(BItemPrice p, DataTable dt)
        {
            p.Active = dt.Rows[0][bip.Active].ToString();
            p.item_price_number = dt.Rows[0][bip.item_price_number].ToString();
            p.b_item_id = dt.Rows[0][bip.b_item_id].ToString();
            p.item_price_active_date = dt.Rows[0][bip.item_price_active_date].ToString();
            p.item_price_cost = dt.Rows[0][bip.item_price_cost].ToString();
            p.b_item_price_id = dt.Rows[0][bip.b_item_price_id].ToString();
            p.item_price = dt.Rows[0][bip.item_price].ToString();
            p.item_price_opd = dt.Rows[0][bip.item_price_opd].ToString();
            p.item_price_ipd = dt.Rows[0][bip.item_price_ipd].ToString();
            p.date_end = dt.Rows[0][bip.date_end].ToString();
            p.date_start = dt.Rows[0][bip.date_start].ToString();

            return p;
        }
        private String insert(BItemPrice p)
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
                sql = "Insert Into " + bip.table + "(" + bip.item_price_number + "," + bip.b_item_id + "," +
                    bip.item_price_active_date + "," + bip.item_price_cost + "," + bip.item_price + "," + 
                    bip.item_price_opd + "," + bip.item_price_ipd + "," + bip.date_end + "," + 
                    bip.date_start + bip.Active + ") " +
                    "Values('" + p.item_price_number + "','" + p.b_item_id + "','" +
                    p.item_price_active_date + "','" + p.item_price_cost + "','" + p.item_price + "','" + 
                    p.item_price_opd + "','" + p.item_price_ipd + "','" + p.date_end + "','" + 
                    p.date_start + "','1') ";
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
