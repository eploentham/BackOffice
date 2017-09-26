using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBorrowOpdCardDB
    {
        TBorrowOpdCard tboc;
        ConnectDB conn;
        public TBorrowOpdCardDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tboc = new TBorrowOpdCard();
            tboc.amount_date_opd = "amount_date_opd";
            tboc.borrower_opd_lastname = "borrower_opd_lastname";
            tboc.borrower_opd_name = "borrower_opd_name";
            tboc.borrower_opd_prefix = "borrower_opd_prefix";
            tboc.borrow_opdcard_active = "borrow_opdcard_active";
            tboc.borrow_opdcard_cancel_date_time = "borrow_opdcard_cancel_date_time";
            tboc.borrow_opdcard_record_date_time = "borrow_opdcard_record_date_time";
            tboc.borrow_opdcard_staff_cancel = "borrow_opdcard_staff_cancel";
            tboc.borrow_opdcard_staff_record = "borrow_opdcard_staff_record";
            tboc.borrow_opdcard_staff_update = "borrow_opdcard_staff_update";
            tboc.borrow_opdcard_update_date_time = "borrow_opdcard_update_date_time";
            tboc.borrow_opd_cause = "borrow_opd_cause";
            tboc.borrow_opd_date = "borrow_opd_date";
            tboc.borrow_opd_status = "borrow_opd_status";
            tboc.borrow_opd_to = "borrow_opd_to";
            tboc.borrow_opd_to_other = "borrow_opd_to_other";
            tboc.date_serv_opd = "date_serv_opd";
            tboc.patient_hn = "patient_hn";
            tboc.permissibly_borrow_opd = "permissibly_borrow_opd";
            tboc.return_opd_date = "return_opd_date";
            tboc.t_borrow_opdcard_id = "t_borrow_opdcard_id";

            tboc.pkField = "t_borrow_opdcard_id";
            tboc.table = "t_borrow_opdcard";
        }
    }
}
