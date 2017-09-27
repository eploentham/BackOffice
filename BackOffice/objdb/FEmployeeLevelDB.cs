using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FEmployeeLevelDB
    {
        FEmployeeLevel fel;
        ConnectDB conn;
        public FEmployeeLevelDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fel = new FEmployeeLevel();
            fel.employee_level_description = "employee_level_description";
            fel.f_employee_level_id = "f_employee_level_id";

            fel.pkField = "f_employee_level_id";
            fel.table = "f_employee_level";
        }
    }
}
