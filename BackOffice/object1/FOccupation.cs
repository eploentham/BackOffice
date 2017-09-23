using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class FOccupation:Persistent
    {
        public String occupation_description { get; set; }
        public String active { get; set; }
        public String f_occupation_id { get; set; }
    }
}
