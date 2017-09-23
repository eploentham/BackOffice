using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class FEducationType:Persistent
    {
        public String education_type_description { get; set; }
        public String education_type_sort_index { get; set; }
        public String f_education_type_id { get; set; }
    }
}
