using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBorrowFilmXrayDB
    {
        TBorrowFilmXray tbfx;
        ConnectDB conn;
        public TBorrowFilmXrayDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbfx = new TBorrowFilmXray();
            tbfx.amount_date = "amount_date";
            tbfx.borrower_lastname = "borrower_lastname";
            tbfx.borrower_name = "borrower_name";
            tbfx.borrower_prefix = "borrower_prefix";
            tbfx.borrow_active = "borrow_active";
            tbfx.borrow_cancel_date_time = "borrow_cancel_date_time";
            tbfx.borrow_cause = "borrow_cause";
            tbfx.borrow_film_date = "borrow_film_date";
            tbfx.borrow_record_date_time = "borrow_record_date_time";
            tbfx.borrow_staff_cancel = "borrow_staff_cancel";
            tbfx.borrow_staff_record = "borrow_staff_record";
            tbfx.borrow_staff_update = "borrow_staff_update";
            tbfx.borrow_status = "borrow_status";
            tbfx.borrow_to = "borrow_to";
            tbfx.borrow_to_other = "borrow_to_other";
            tbfx.borrow_update_date_time = "borrow_update_date_time";
            tbfx.patient_hn = "patient_hn";
            tbfx.patient_xn = "patient_xn";
            tbfx.permissibly_borrow = "permissibly_borrow";
            tbfx.return_film_date = "return_film_date";
            tbfx.t_borrow_film_xray_id = "t_borrow_film_xray_id";

            tbfx.pkField = "t_borrow_film_xray_id";
            tbfx.table = "t_borrow_film_xray";
        }
    }
}
