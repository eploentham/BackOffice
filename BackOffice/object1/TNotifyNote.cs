using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TNotifyNote:Persistent
    {
        public String t_patient_hn { get; set; }
        public String t_visit_id_rec { get; set; }
        public String f_notify_type_id { get; set; }
        public String note_subject { get; set; }
        public String note_detail { get; set; }
        public String active { get; set; }
        public String rec_staff { get; set; }
        public String rec_datetime { get; set; }
        public String mod_datetime { get; set; }
        public String del_datetime { get; set; }
        public String t_visit_id_last_view { get; set; }
        public String notify_to { get; set; }
        public String notify_to_des { get; set; }
        public String t_notify_note_id { get; set; }
        public String notify_count { get; set; }
    }
}
