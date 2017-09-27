using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FEmployeeAuthenticationDB
    {
        FEmployeeAuthentication fea;
        ConnectDB conn;
        public FEmployeeAuthenticationDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fea = new FEmployeeAuthentication();
            fea.employee_authentication_description = "employee_authentication_description";
            fea.f_employee_authentication_id = "f_employee_authentication_id";

            fea.pkField = "f_employee_authentication_id";
            fea.table = "f_employee_authentication";
        }
    }
}
