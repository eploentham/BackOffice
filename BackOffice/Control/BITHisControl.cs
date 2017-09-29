using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class BITHisControl
    {
        ConnectDB connORCBIT, connBIT, connORCBA;

        public BITHisControl()
        {
            connBIT = new ConnectDB("bit");
        }
        public DataTable getPatientToday(String curDate)
        {
            DataTable dt = new DataTable();
            String sql = "";

            sql = "Select ocm.ocmnum, ocm.ocmchtnum, ocm.ocmpattyp, ocm.ocmdepcod, ocm.ocminscod, ocm.ocmtitcod, ocm.ocmrsvcmt, " +
                "pbs.pbspatnam, pbs.pbssurnam,pbs.pbstitcod, pbs.pbssextyp" +
                "From ocminf ocm " +
                "left join pbsinf pbs On pbs.pbschtnum = ocm.ocmchtnum" +
                "Where ocm.ocmorgdtm = '";

            return dt;
        }
    }
}
