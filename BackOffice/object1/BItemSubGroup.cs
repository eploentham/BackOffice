﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BItemSubGroup:Persistent
    {
        public String item_subgroup_number { get; set; }
        public String item_subgroup_description { get; set; }
        public String f_item_group_id { get; set; }
        public String item_subgroup_active { get; set; }
        public String b_item_subgroup_id { get; set; }
    }
}
