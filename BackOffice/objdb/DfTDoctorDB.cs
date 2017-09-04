using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class DfTDoctorDB
    {
        ConnectDB conn;
        public DoctorRate dtrR;
        public DfTDoctor dfDtr;
        public DfTDoctorDB(ConnectDB connorc_ba)
        {
            conn = connorc_ba;
            initConfig();
        }
        private void initConfig()
        {
            dtrR = new DoctorRate();
            dfDtr = new DfTDoctor();
            dfDtr.Active = "active";
            dfDtr.DfId = "df_id";
            dfDtr.DrfBilNum = "DrfBilNum";
            dfDtr.DrfCalNum = "DrfCalNum";
            dfDtr.DrfCtrCodv = "DrfCtrCod";
            dfDtr.DrfCtrSeq = "DrfCtrSeq";
            dfDtr.DrfCurStt = "DrfCurStt";
            dfDtr.DrfDivYon = "DrfDivYon";
            dfDtr.DrfGrpSeq = "DrfGrpSeq";
            dfDtr.DrfIncCod = "DrfIncCod";
            dfDtr.DrfOcmNum = "DrfOcmNum";
            dfDtr.DrfOdrAmt = "DrfOdrAmt";
            dfDtr.drfodrcod = "drfodrcod";
            dfDtr.DrfOdrDtm = "DrfOdrDtm";
            dfDtr.DrfOdrSeq = "DrfOdrSeq";
            dfDtr.DrfOspTyp = "DrfOspTyp";
            dfDtr.DrfPatTyp = "DrfPatTyp";
            dfDtr.DrfRcpNum = "DrfRcpNum";
            dfDtr.DrfRcpSeq = "DrfRcpSeq";
            dfDtr.DrfSeqNum = "DrfSeqNum";
            dfDtr.DrfUidCod = "DrfUidCod";
            dfDtr.DrfUpdDtm = "DrfUpdDtm";
            dfDtr.DtrCode = "dtr_code";
            dfDtr.MonthId = "month_id";
            dfDtr.StatusApprove = "status_approve";
            dfDtr.StatusDoc = "status_doc";
            dfDtr.YearId = "year_id";
            dfDtr.PspPatNam = "PspPatNam";
            dfDtr.PspSurNam = "PspSurNam";
            dfDtr.OrpChtNum = "OrpChtNum";
            dfDtr.InsCodNam = "InsCodNam";
            dfDtr.orptotamt = "orptotamt";
            dfDtr.ItmKorNam = "ItmKorNam";
            dfDtr.ItmCod = "ItmCod";
            dfDtr.ItmAstCod = "ItmAstCod";
            dfDtr.ItmSrvOpd = "ItmSrvOpd";
            dfDtr.df = "df";

            dfDtr.table = "df_t_doctor";
            dfDtr.pkField = "df_id";

        }
        public DataTable selectByDoctor(String dtrCode, String YearId, String MonthId)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dtrR.table + " Where active = '1' and " + dtrR.DtrCode + " = '" + dtrCode + "' Order By row1";

            dt = conn.selectData(sql, "orc_ba");
            //item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return dt;
        }
    }
}
