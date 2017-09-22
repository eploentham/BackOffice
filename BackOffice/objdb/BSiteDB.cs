using System;
using System.Collections.Generic;
using System.Data;
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
        private BSite setData(BSite p, DataTable dt)
        {
            p.BVisitOfficeId = dt.Rows[0][bs.BVisitOfficeId].ToString();
            p.site_name = dt.Rows[0][bs.site_name].ToString();
            p.site_full_name = dt.Rows[0][bs.site_full_name].ToString();
            p.site_house = dt.Rows[0][bs.site_house].ToString();
            p.site_moo = dt.Rows[0][bs.site_moo].ToString();
            p.site_tambon = dt.Rows[0][bs.site_tambon].ToString();
            p.site_amphur = dt.Rows[0][bs.site_amphur].ToString();
            p.site_changwat = dt.Rows[0][bs.site_changwat].ToString();
            p.site_postcode = dt.Rows[0][bs.site_postcode].ToString();
            p.site_admin_name = dt.Rows[0][bs.site_admin_name].ToString();

            p.site_phone_number = dt.Rows[0][bs.site_phone_number].ToString();
            p.f_opd_type_id = dt.Rows[0][bs.f_opd_type_id].ToString();
            p.site_receipt_type = dt.Rows[0][bs.site_receipt_type].ToString();
            p.site_drug_fund_id = dt.Rows[0][bs.site_drug_fund_id].ToString();
            p.address_english = dt.Rows[0][bs.address_english].ToString();
            p.site_full_namee = dt.Rows[0][bs.site_full_namee].ToString();
            p.date_current = dt.Rows[0][bs.date_current].ToString();
            p.status_vn_day = dt.Rows[0][bs.status_vn_day].ToString();
            p.status_dialog_cal = dt.Rows[0][bs.status_dialog_cal].ToString();
            p.b_site_id = dt.Rows[0][bs.b_site_id].ToString();

            return p;
        }
    }
}
