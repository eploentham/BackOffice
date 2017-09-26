using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FVisitTypeDB
    {
        FVisitType fvt;
        ConnectDB conn;
        public FVisitTypeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fvt = new FVisitType();
            fvt.f_visit_type_id = "f_visit_type_id";
            fvt.visit_type_description = "visit_type_description";

            fvt.pkField = "f_visit_type_id";
            fvt.table = "f_visit_type";
        }
    }
}
