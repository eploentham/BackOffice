using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TResultXraySize:Persistent
    {
        public String t_result_xray_id { get; set; }
        public String f_xray_film_size_id { get; set; }
        public String xray_film_amount { get; set; }
        public String result_xray_size_staff_record { get; set; }
        public String result_xray_size_active { get; set; }
        public String result_xray_size_add_order { get; set; }
        public String t_visit_id { get; set; }
        public String t_order_id { get; set; }
        public String result_xray_size_damaging_xray_film_amount { get; set; }
        public String t_result_xray_size_id { get; set; }
        public String result_xray_size_price { get; set; }
    }
}
