using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BVisitBedDB
    {
        BVisitBed bvb;
        ConnectDB conn;
        public BVisitBedDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bvb = new BVisitBed();
            bvb.b_item_id = "b_item_id";
            bvb.b_visit_bed_id = "b_visit_bed_id";
            bvb.b_visit_room_id = "b_visit_room_id";
            bvb.b_visit_ward_id = "b_visit_ward_id";
            bvb.visit_bed_active = "visit_bed_active"; ;
            bvb.visit_bed_book = "visit_bed_book";
            bvb.visit_bed_caption = "visit_bed_caption";
            bvb.visit_bed_number = "visit_bed_number";

            bvb.pkField = "b_visit_bed_id";
            bvb.table = "b_visit_bed";
        }
    }
}
