using System;
using System.Collections.Generic;
using System.Data;
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
        private BServicePoint setData(BServicePoint p, DataTable dt)
        {
            p.service_point_number = dt.Rows[0][bsp.service_point_number].ToString();
            p.service_point_description = dt.Rows[0][bsp.service_point_description].ToString();
            p.f_service_group_id = dt.Rows[0][bsp.f_service_group_id].ToString();
            p.f_service_subgroup_id = dt.Rows[0][bsp.f_service_subgroup_id].ToString();
            p.service_point_active = dt.Rows[0][bsp.service_point_active].ToString();
            p.service_point_check = dt.Rows[0][bsp.service_point_check].ToString();
            p.service_point_operation_room = dt.Rows[0][bsp.service_point_operation_room].ToString();
            p.service_point_color = dt.Rows[0][bsp.service_point_color].ToString();
            p.b_service_point_id = dt.Rows[0][bsp.b_service_point_id].ToString();

            return p;
        }
        private String insert(BServicePoint p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.service_point_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.service_point_active = "1";
                sql = "Insert Into " + bsp.table + "(" + bsp.service_point_active + "," + bsp.service_point_number + "," + bsp.service_point_description + "," +
                    bsp.f_service_group_id + "," + bsp.f_service_subgroup_id + "," + bsp.service_point_check + "," +
                    bsp.service_point_operation_room + "," + bsp.service_point_color + ") " +
                    "Values('" + p.service_point_active + "','" + p.service_point_number + "','" + p.service_point_description + "','" +
                    p.f_service_group_id + "','" + p.f_service_subgroup_id + "','" + p.service_point_check + "','" +
                    p.service_point_operation_room + "','" + p.service_point_color + "') ";
                chk = conn.ExecuteNonQueryAutoIncrement(sql, "orc_ma");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }
            return chk;
        }
    }
}
