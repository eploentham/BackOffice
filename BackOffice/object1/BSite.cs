using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BSite:Persistent
    {
        public String BVisitOfficeId { get; set; }
        public String site_name { get; set; }
        public String site_full_name { get; set; }
        public String site_house { get; set; }
        public String site_moo { get; set; }
        public String site_tambon { get; set; }
        public String site_amphur { get; set; }
        public String site_changwat { get; set; }
        public String site_postcode { get; set; }
        public String site_admin_name { get; set; }
        public String site_phone_number { get; set; }
        public String f_opd_type_id { get; set; }
        public String site_receipt_type { get; set; }
        public String site_drug_fund_id { get; set; }
        public String address_english { get; set; }
        public String site_full_namee { get; set; }
        public String date_current { get; set; }
        public String status_vn_day { get; set; }
        public String status_dialog_cal { get; set; }
        public String b_site_id { get; set; }
    }
}
