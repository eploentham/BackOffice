using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BVisitClinicDB
    {
        BVisitClinic bvc;
        ConnectDB conn;
        public BVisitClinicDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bvc = new BVisitClinic();
            bvc.b_visit_clinic_id = "b_visit_clinic_id";
            bvc.f_service_group_id = "f_service_group_id";
            bvc.visit_clinic_active = "visit_clinic_active";
            bvc.visit_clinic_description = "visit_clinic_description";
            bvc.visit_clinic_number = "visit_clinic_number";

            bvc.pkField = "b_visit_clinic_id";
            bvc.table = "b_visit_clinic"; ;
        }
    }
}
