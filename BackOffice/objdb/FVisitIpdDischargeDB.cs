using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FVisitIpdDischargeDB
    {
        FVisitIpdDischarge fvid;
        ConnectDB conn;
        public FVisitIpdDischargeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fvid = new FVisitIpdDischarge();
            fvid.f_visit_ipd_discharge_id = "f_visit_ipd_discharge_id";
            fvid.visit_ipd_discharge_description = "visit_ipd_discharge_description";

            fvid.pkField = "f_visit_ipd_discharge_id";
            fvid.table = "f_visit_ipd_discharge";
        }
    }
}
