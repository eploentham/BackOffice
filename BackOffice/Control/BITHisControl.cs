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

        public String HN = "", PatientFullName="",ocmNum="", insCodNam="", rsvCmt="";

        public BITHisControl()
        {
            connBIT = new ConnectDB("bit");
        }
        public DataTable getPatientToday(String curDate)
        {
            DataTable dt = new DataTable();
            String sql = "";

            sql = "Select ocm.ocmnum, ocm.ocmchtnum, ocm.ocmpattyp, ocm.ocmdepcod, ocm.ocminscod, pbs.pbstitcod, ocm.ocmrsvcmt, " +
                "pbs.pbspatnam, pbs.pbssurnam,pbs.pbstitcod, pbs.pbssextyp, ocm.ocmorgdtm, insm.InsCodNam " +
                "From ocminf ocm " +
                "left join pbsinf pbs On pbs.pbschtnum = ocm.ocmchtnum " +
                "left join InsMst insm on insm.InsCod = ocm.ocmInsCod " +
                "Where ocm.ocmorgdtm >= '" + curDate+ "0000' and ocm.ocmorgdtm <= '" + curDate + "2359'";
            dt = connBIT.selectData(sql, "bit");
            return dt;
        }
        public DataTable getPatientCal(String ocmNum)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select odr.*, itm.itmkornam, itmcodnam " +
                "From OdrInf odr " +
                "left join ItmMst itm On itm.itmcod = odr.odritmcod and itm.itmastcod = odr.odrastcod " +
                //"left join InsMst insm on insm.InsCod = ocm.ocmInsCod " +
                "Where odr.OdrOcmNum = " + ocmNum ;
            dt = connBIT.selectData(sql, "bit");
            return dt;
        }
    }
}
