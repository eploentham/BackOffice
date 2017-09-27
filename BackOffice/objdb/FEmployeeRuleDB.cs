using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FEmployeeRuleDB
    {
        FEmployeeRule fer;
        ConnectDB conn;
        public FEmployeeRuleDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fer = new FEmployeeRule();
            fer.employee_rule_description = "employee_rule_description";
            fer.f_employee_rule_id = "f_employee_rule_id";

            fer.pkField = "f_employee_rule_id";
            fer.table = "f_employee_rule";
        }
    }
}
