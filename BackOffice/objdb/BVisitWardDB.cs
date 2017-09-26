using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BVisitWardDB
    {
        BVisitWard bvw;
        ConnectDB conn;
        public BVisitWardDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bvw = new BVisitWard();
            bvw.b_visit_ward_id = "b_visit_ward_id";
            bvw.visit_ward_active = "visit_ward_active";
            bvw.visit_ward_color = "visit_ward_color";
            bvw.visit_ward_description = "visit_ward_description";
            bvw.visit_ward_number = "visit_ward_number";

            bvw.pkField = "b_visit_ward_id";
            bvw.table = "b_visit_ward";
        }
    }
}
