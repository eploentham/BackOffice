using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FRelationDB
    {
        FRelation fr;
        ConnectDB conn;
        public FRelationDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fr = new FRelation();
            fr.f_relation_id = "f_relation_id";
            fr.relation_description = "relation_description";

            fr.pkField = "f_relation_id";
            fr.table = "f_relation";
        }
    }
}
