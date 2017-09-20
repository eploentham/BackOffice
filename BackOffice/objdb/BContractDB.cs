using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BContractDB
    {
        BContract bc;
        ConnectDB conn;
        public BContractDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bc = new BContract();
            bc.contract_number = "contract_number";
            bc.contract_description = "contract_description";
            bc.contract_method = "contract_method";
            bc.b_contract_id = "b_contract_id";
            bc.Active = "active";
        }
        private BContract setData(BContract p, DataTable dt)
        {
            p.Active = dt.Rows[0][bc.Active].ToString();
            p.b_contract_id = dt.Rows[0][bc.b_contract_id].ToString();
            p.contract_description = dt.Rows[0][bc.contract_description].ToString();
            p.contract_method = dt.Rows[0][bc.contract_method].ToString();
            p.contract_number = dt.Rows[0][bc.contract_number].ToString();

            return p;
        }
        private String insert(BContract p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.t_visit_id.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + bc.table + "(" + bc.Active + "," + bc.b_contract_id + "," + bc.contract_description + "," +
                    bc.contract_method + "," + bc.contract_number + ") " +
                    "Values('" + p.Active + "','" + p.billing_billing_date_time + "','" + p.billing_billing_number + "','" +
                    p.billing_cancle_date_time + "','" + p.billing_deduct + "','" + p.billing_financial_date + "','" +
                    p.billing_paid + "','" + p.billing_patient_share + "','" + p.billing_payback + "','" +
                    p.billing_payer_share + "','" + p.billing_remain + "','" + p.billing_staff_cancle + "','" +
                    p.billing_staff_record + "','" + p.billing_total + "','" + p.t_billing_id + "','" +
                    p.t_patient_id + "','" + p.t_visit_id + "') ";
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
