using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemBillingSubGroupDB
    {
        BItemBillingSubGroup bibs;
        ConnectDB conn;
        public BItemBillingSubGroupDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bibs = new BItemBillingSubGroup();
            bibs.item_billing_subgroup_number = "item_billing_subgroup_number";
            bibs.item_billing_subgroup_description = "item_billing_subgroup_description";
            bibs.f_item_billing_group_id = "f_item_billing_group_id";
            bibs.item_billing_subgroup_active = "item_billing_subgroup_active";
            bibs.item_billing_subgroup_descriptione = "item_billing_subgroup_descriptione";
            bibs.b_item_billing_subgroup_id = "b_item_billing_subgroup_id";
        }
        private BItemBillingSubGroup setData(BItemBillingSubGroup p, DataTable dt)
        {
            p.item_billing_subgroup_number = dt.Rows[0][bibs.item_billing_subgroup_number].ToString();
            p.item_billing_subgroup_description = dt.Rows[0][bibs.item_billing_subgroup_description].ToString();
            p.f_item_billing_group_id = dt.Rows[0][bibs.f_item_billing_group_id].ToString();
            p.item_billing_subgroup_active = dt.Rows[0][bibs.item_billing_subgroup_active].ToString();
            p.item_billing_subgroup_descriptione = dt.Rows[0][bibs.item_billing_subgroup_descriptione].ToString();
            p.b_item_billing_subgroup_id = dt.Rows[0][bibs.b_item_billing_subgroup_id].ToString();

            return p;
        }
        private String insert(BItemBillingSubGroup p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.item_billing_subgroup_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                //p.Active = "1";
                sql = "Insert Into " + bibs.table + "(" + bibs.item_billing_subgroup_number + "," + bibs.item_billing_subgroup_description + "," +
                    bibs.f_item_billing_group_id + "," + bibs.item_billing_subgroup_descriptione + "," + bibs.item_billing_subgroup_active + ") " +
                    "Values('" + p.item_billing_subgroup_number + "','" + p.item_billing_subgroup_description + "','" +
                    p.f_item_billing_group_id + "','" + p.item_billing_subgroup_descriptione + "','1') ";
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
