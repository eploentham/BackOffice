using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BVisitOfficeDB
    {
        BVisitOffice bvo;
        ConnectDB conn;
        public BVisitOfficeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bvo = new BVisitOffice();
            bvo.b_visit_office_id = "";
            bvo.visit_office_amphur = "";
            bvo.visit_office_bed = "";
            bvo.visit_office_changwat = "";
            bvo.visit_office_dep = "";
            bvo.visit_office_minis = "";
            bvo.visit_office_moo = "";
            bvo.visit_office_name = "";
            bvo.visit_office_name1 = "";
            bvo.visit_office_name2 = "";
            bvo.visit_office_specific = "";
            bvo.visit_office_tambon = "";
            bvo.visit_office_type = "";
        }
    }
}
