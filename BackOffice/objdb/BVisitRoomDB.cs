using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BVisitRoomDB
    {
        BVisitRoom bvr;
        ConnectDB conn;
        public BVisitRoomDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bvr = new BVisitRoom();
            bvr.b_item_id = "b_item_id";
            bvr.b_visit_room_id = "b_visit_room_id";
            bvr.b_visit_ward_id = "b_visit_ward_id";
            bvr.visit_room_active = "visit_room_active";
            bvr.visit_room_book = "visit_room_book";
            bvr.visit_room_number = "visit_room_number";
            bvr.visit_room_public = "visit_room_public";

            bvr.pkField = "b_visit_room_id";
            bvr.table = "b_visit_room";
        }
    }
}
