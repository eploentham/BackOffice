using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBorrowFilmXray:Persistent
    {
        public String patient_hn { get; set; }
        public String patient_xn { get; set; }
        public String borrower_prefix { get; set; }
        public String borrower_name { get; set; }
        public String borrower_lastname { get; set; }
        public String borrow_film_date { get; set; }
        public String amount_date { get; set; }
        public String return_film_date { get; set; }
        public String borrow_status { get; set; }
        public String permissibly_borrow { get; set; }
        public String borrow_cause { get; set; }
        public String borrow_to { get; set; }
        public String borrow_to_other { get; set; }
        public String date_serv { get; set; }
        public String borrow_staff_record { get; set; }
        public String borrow_record_date_time { get; set; }
        public String borrow_staff_update { get; set; }
        public String borrow_update_date_time { get; set; }
        public String borrow_staff_cancel { get; set; }
        public String borrow_cancel_date_time { get; set; }
        public String borrow_active { get; set; }
        public String t_borrow_film_xray_id { get; set; }
    }
}
