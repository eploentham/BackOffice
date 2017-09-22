using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BContractPayerDB
    {
        BContractPayer bcpa;
        ConnectDB conn;
        public BContractPayerDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bcpa = new BContractPayer();
            bcpa.contract_payer_number = "contract_payer_number";
            bcpa.contract_payer_description = "contract_payer_description";
            bcpa.contract_payer_active = "contract_payer_active";
            bcpa.b_contract_payer_id = "b_contract_payer_id";
            bcpa.Active = "active";
        }
        private BContractPayer setData(BContractPayer p, DataTable dt)
        {
            p.contract_payer_number = dt.Rows[0][bcpa.contract_payer_number].ToString();
            p.contract_payer_description = dt.Rows[0][bcpa.contract_payer_description].ToString();
            p.contract_payer_active = dt.Rows[0][bcpa.contract_payer_active].ToString();
            p.b_contract_payer_id = dt.Rows[0][bcpa.b_contract_payer_id].ToString();
            p.Active = dt.Rows[0][bcpa.Active].ToString();

            return p;
        }
        private String insert(BContractPayer p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.contract_payer_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.contract_payer_active = "1";
                sql = "Insert Into " + bcpa.table + "(" + bcpa.contract_payer_active + "," + bcpa.contract_payer_number + "," +
                    bcpa.contract_payer_description + "," + bcpa.b_contract_payer_id + "," + bcpa.Active + ") " +
                    "Values('" + p.contract_payer_active + "','" + p.contract_payer_number + "','" +
                    p.contract_payer_description + "','" + p.b_contract_payer_id + "','1') ";
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
