using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FVisitStatusDB
    {
        FVisitStatus fvs;
        ConnectDB conn;
        public FVisitStatusDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fvs = new FVisitStatus();
            fvs.f_visit_status_id = "f_visit_status_id";
            fvs.visit_status_description = "visit_status_description";

            fvs.pkField = "f_visit_status_id";
            fvs.table = "f_visit_status";
        }
    }
}
