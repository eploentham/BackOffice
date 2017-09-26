using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FEducationTypeDB
    {
        FEducationType fet;
        ConnectDB conn;
        public FEducationTypeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fet = new FEducationType();
            fet.education_type_description = "education_type_description";
            fet.education_type_sort_index = "education_type_sort_index"; ;
            fet.f_education_type_id = "f_education_type_id";

            fet.pkField = "f_education_type_id";
            fet.table = "f_education_type";
        }
    }
}
