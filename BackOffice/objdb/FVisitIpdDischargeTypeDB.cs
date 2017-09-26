using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FVisitIpdDischargeTypeDB
    {
        FVisitIpdDischargeType fvidt;
        ConnectDB conn;
        public FVisitIpdDischargeTypeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fvidt = new FVisitIpdDischargeType();
            fvidt.f_visit_ipd_discharge_type_id = "f_visit_ipd_discharge_type_id";
            fvidt.visit_ipd_discharge_type_description = "visit_ipd_discharge_type_description";

            fvidt.pkField = "f_visit_ipd_discharge_type_id";
            fvidt.table = "f_visit_ipd_discharge_type";
        }
    }
}
