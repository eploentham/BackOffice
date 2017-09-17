using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BServicePointDB
    {
        BServicePoint bsp;
        ConnectDB conn;

        public BServicePointDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            bsp = new BServicePoint();
            bsp.service_point_number = "service_point_number";
            bsp.service_point_description = "service_point_description";
            bsp.f_service_group_id = "f_service_group_id";
            bsp.f_service_subgroup_id = "f_service_subgroup_id";
            bsp.service_point_active = "service_point_active";
            bsp.service_point_check = "service_point_check";
            bsp.service_point_operation_room = "service_point_operation_room";
            bsp.service_point_color = "service_point_color";
            bsp.b_service_point_id = "b_service_point_id";
        }
    }
}
