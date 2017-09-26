using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBorrowOpdCard:Persistent
    {
        public String patient_hn { get; set; }
        public String borrower_opd_prefix { get; set; }
        public String borrower_opd_name { get; set; }
        public String borrower_opd_lastname { get; set; }
        public String borrow_opd_date { get; set; }
        public String amount_date_opd { get; set; }
        public String return_opd_date { get; set; }
        public String borrow_opd_status { get; set; }
        public String permissibly_borrow_opd { get; set; }
        public String borrow_opd_cause { get; set; }
        public String borrow_opd_to { get; set; }
        public String borrow_opd_to_other { get; set; }
        public String date_serv_opd { get; set; }
        public String borrow_opdcard_staff_record { get; set; }
        public String borrow_opdcard_record_date_time { get; set; }
        public String borrow_opdcard_staff_update { get; set; }
        public String borrow_opdcard_update_date_time { get; set; }
        public String borrow_opdcard_staff_cancel { get; set; }
        public String borrow_opdcard_cancel_date_time { get; set; }
        public String borrow_opdcard_active { get; set; }
        public String t_borrow_opdcard_id { get; set; }
    }
}
