using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BContractPlansDB
    {
        BCcontractPlans bcp;
        ConnectDB conn;
        public BContractPlansDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bcp = new BCcontractPlans();
            bcp.contract_plans_number = "contract_plans_number";
            bcp.contract_plans_description = "contract_plans_description";
            bcp.contract_plans_active_from = "contract_plans_active_from";
            bcp.contract_plans_active_to = "contract_plans_active_to";
            bcp.contract_plans_active = "contract_plans_active";
            bcp.contract_plans_pttype = "contract_plans_pttype";
            bcp.b_contract_payer_id = "b_contract_payer_id";
            bcp.b_contract_id = "b_contract_id";
            bcp.contract_plans_money_limit = "contract_plans_money_limit";
            bcp.contract_plans_sort_index = "contract_plans_sort_index";

            bcp.r_rp1853_instype_id = "r_rp1853_instype_id";
            bcp.contract_plans_hide_company = "contract_plans_hide_company";
            bcp.contract_plans_color = "contract_plans_color";
            bcp.b_contract_plans_id = "b_contract_plans_id";
            bcp.Active = "active";
        }
        private BCcontractPlans setData(BCcontractPlans p, DataTable dt)
        {
            p.contract_plans_number = dt.Rows[0][bcp.contract_plans_number].ToString();
            p.contract_plans_description = dt.Rows[0][bcp.contract_plans_description].ToString();
            p.contract_plans_active_from = dt.Rows[0][bcp.contract_plans_active_from].ToString();
            p.contract_plans_active_to = dt.Rows[0][bcp.contract_plans_active_to].ToString();
            p.contract_plans_active = dt.Rows[0][bcp.contract_plans_active].ToString();
            p.contract_plans_pttype = dt.Rows[0][bcp.contract_plans_pttype].ToString();
            p.b_contract_payer_id = dt.Rows[0][bcp.b_contract_payer_id].ToString();
            p.b_contract_id = dt.Rows[0][bcp.b_contract_id].ToString();
            p.contract_plans_money_limit = dt.Rows[0][bcp.contract_plans_money_limit].ToString();
            p.contract_plans_sort_index = dt.Rows[0][bcp.contract_plans_sort_index].ToString();

            p.r_rp1853_instype_id = dt.Rows[0][bcp.r_rp1853_instype_id].ToString();
            p.contract_plans_hide_company = dt.Rows[0][bcp.contract_plans_hide_company].ToString();
            p.contract_plans_color = dt.Rows[0][bcp.contract_plans_color].ToString();
            p.b_contract_plans_id = dt.Rows[0][bcp.b_contract_plans_id].ToString();
            p.Active = dt.Rows[0][bcp.Active].ToString();

            return p;
        }
        private String insert(BCcontractPlans p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.contract_plans_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.contract_plans_active = "1";
                sql = "Insert Into " + bcp.table + "(" + bcp.contract_plans_active + "," + bcp.contract_plans_number + "," + bcp.contract_plans_description + "," +
                    bcp.contract_plans_active_from + "," + bcp.contract_plans_active_to + "," + bcp.contract_plans_pttype + "," +
                    bcp.b_contract_payer_id + "," + bcp.b_contract_id + "," + bcp.contract_plans_money_limit + "," +
                    bcp.contract_plans_sort_index + "," + bcp.contract_plans_hide_company + "," + bcp.b_contract_id + "," + bcp.Active + ") " +
                    "Values('" + p.contract_plans_active + "','" + p.contract_plans_number + "','" + p.contract_plans_color + "','" +
                    p.contract_plans_active_from + "','" + p.contract_plans_active_to + "','" + p.contract_plans_pttype + "','" +
                    p.b_contract_payer_id + "','" + p.b_contract_id + "','" + p.contract_plans_money_limit + "','" +
                    p.contract_plans_sort_index + "','" + p.contract_plans_hide_company + "','" + p.contract_plans_color + "','1') ";
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
