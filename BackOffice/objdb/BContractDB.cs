using System;
using System.Collections.Generic;
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
            bc.contract_number = "";
            bc.contract_description = "";
            bc.contract_method = "";
            bc.b_contract_id = "";
        }
    }
}
