using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FVisitOpdDischargeDB
    {
        FVisitOpdDischarge fvod;
        ConnectDB conn;
        public FVisitOpdDischargeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fvod = new FVisitOpdDischarge();
            fvod.f_visit_opd_discharge_id = "f_visit_opd_discharge_id";
            fvod.visit_opd_discharge_description = "visit_opd_discharge_description";

            fvod.pkField = "f_visit_opd_discharge_id";
            fvod.table = "f_visit_opd_discharge";
        }
    }
}
