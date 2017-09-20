using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BContract:Persistent
    {
        public String contract_number { get; set; }
        public String contract_description { get; set; }
        public String contract_method { get; set; }
        public String b_contract_id { get; set; }
        public String Active { get; set; }
    }
}
