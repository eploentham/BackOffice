using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TNotifyNoteDB
    {
        TNotifyNote tnn;
        ConnectDB conn;
        public TNotifyNoteDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tnn = new TNotifyNote();
            tnn.active = "active";
            tnn.del_datetime = "del_datetime";
            tnn.f_notify_type_id = "f_notify_type_id";
            tnn.mod_datetime = "mod_datetime";
            tnn.note_detail = "note_detail";
            tnn.note_subject = "note_subject";
            tnn.notify_count = "notify_count";
            tnn.notify_to = "notify_to";
            tnn.notify_to_des = "notify_to_des";
            tnn.rec_datetime = "rec_datetime";
            tnn.rec_staff = "rec_staff";
            tnn.t_notify_note_id = "t_notify_note_id";
            tnn.t_patient_hn = "t_patient_hn";
            tnn.t_visit_id_last_view = "t_visit_id_last_view";
            tnn.t_visit_id_rec = "t_visit_id_rec";

            tnn.pkField = "t_notify_note_id";
            tnn.table = "t_notify_note";
        }
    }
}
