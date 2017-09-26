using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FReferCauseDB
    {
        FReferCause frc;
        ConnectDB conn;
        public FReferCauseDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            frc = new FReferCause();
            frc.f_refer_cause_id = "f_refer_cause_id";
            frc.refer_cause_description = "refer_cause_description";

            frc.pkField = "f_refer_cause_id";
            frc.table = "f_refer_cause";
        }
    }
}
