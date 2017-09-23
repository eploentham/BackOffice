using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BVisitBed:Persistent
    {
        public String b_visit_room_id { get; set; }
        public String b_visit_ward_id { get; set; }
        public String visit_bed_number { get; set; }
        public String visit_bed_active { get; set; }
        public String b_item_id { get; set; }
        public String visit_bed_book { get; set; }
        public String visit_bed_caption { get; set; }
        public String b_visit_bed_id { get; set; }
    }
}
