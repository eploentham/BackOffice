using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BSiteDB
    {
        BSite bs;
        ConnectDB conn;
        public BSiteDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bs = new BSite();
            bs.BVisitOfficeId = "b_visit_office_id";
            bs.site_name = "site_name";
            bs.site_full_name = "site_full_name";
            bs.site_house = "site_house";
            bs.site_moo = "site_moo";
            bs.site_tambon = "site_tambon";
            bs.site_amphur = "site_amphur";
            bs.site_changwat = "site_changwat";
            bs.site_postcode = "site_postcode";
            bs.site_admin_name = "site_admin_name";
            bs.site_phone_number = "site_phone_number";
            bs.f_opd_type_id = "f_opd_type_id";
            bs.site_receipt_type = "site_receipt_type";
            bs.site_drug_fund_id = "site_drug_fund_id";
            bs.address_english = "address_english";
            bs.site_full_namee = "site_full_namee";
            bs.date_current = "date_current";
            bs.status_vn_day = "status_vn_day";
            bs.status_dialog_cal = "status_dialog_cal";
            bs.b_site_id = "b_site_id";
        }
    }
}
