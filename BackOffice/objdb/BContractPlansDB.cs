using System;
using System.Collections.Generic;
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
        }
    }
}
