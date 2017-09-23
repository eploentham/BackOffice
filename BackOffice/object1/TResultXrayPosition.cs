using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TResultXrayPosition:Persistent
    {
        public String b_xray_side_id { get; set; }
        public String b_xray_position_id { get; set; }
        public String t_result_xray_id { get; set; }
        public String t_visit_id { get; set; }
        public String t_order_id { get; set; }
        public String result_xray_position_active { get; set; }
        public String t_result_xray_size_id { get; set; }
        public String result_xray_position_kv { get; set; }
        public String result_xray_position_ma { get; set; }
        public String result_xray_position_second { get; set; }
        public String result_xray_position_mas { get; set; }
        public String result_xray_position_ffd { get; set; }
        public String t_result_xray_position_id { get; set; }
    }
}
