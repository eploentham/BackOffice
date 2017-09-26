using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TOperationDoctorMemberDB
    {
        TOpdSendORDoctorMember tosodm;
        ConnectDB conn;
        public TOperationDoctorMemberDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {

        }
    }
}
