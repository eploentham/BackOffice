using System;
using System.Collections.Generic;
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
            bcpa.contract_payer_number = "";
            bcpa.contract_payer_description = "";
            bcpa.contract_payer_active = "";
            bcpa.b_contract_payer_id = "";
        }
    }
}
