using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BVisitRoom:Persistent
    {
        public String b_visit_ward_id { get; set; }
        public String visit_room_number { get; set; }
        public String visit_room_active { get; set; }
        public String b_item_id { get; set; }
        public String visit_room_public { get; set; }
        public String visit_room_book { get; set; }
        public String b_visit_room_id { get; set; }
    }
}
