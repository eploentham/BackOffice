using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class DfTDoctorDetailDB
    {
        ConnectDB connORCBA, connORCBIT;
        public DoctorRate dtrR;
        public DfTDoctor dfDtr;
        public DfTDoctorDetail dfDtrD;
        public DfTDoctorDetailDB(ConnectDB orc_bit, ConnectDB connorc_ba)
        {
            connORCBIT = orc_bit;
            connORCBA = connorc_ba;
            initConfig();
        }
        private void initConfig()
        {
            dtrR = new DoctorRate();
            dfDtrD = new DfTDoctorDetail();
            dfDtrD.Active = "active";
            dfDtrD.DfDId = "df_detail_id";
            dfDtrD.DfId = "df_id";
            dfDtrD.DrfBilNum = "DrfBilNum";
            dfDtrD.DrfCalNum = "DrfCalNum";
            dfDtrD.DrfCtrCodv = "DrfCtrCod";
            dfDtrD.DrfCtrSeq = "DrfCtrSeq";
            dfDtrD.DrfCurStt = "DrfCurStt";
            dfDtrD.DrfDivYon = "DrfDivYon";
            dfDtrD.DrfGrpSeq = "DrfGrpSeq";
            dfDtrD.DrfIncCod = "DrfIncCod";
            dfDtrD.DrfOcmNum = "DrfOcmNum";
            dfDtrD.DrfOdrAmt = "DrfOdrAmt";
            dfDtrD.drfodrcod = "drfodrcod";
            dfDtrD.DrfOdrDtm = "DrfOdrDtm";
            dfDtrD.DrfOdrSeq = "DrfOdrSeq";
            dfDtrD.DrfOspTyp = "DrfOspTyp";
            dfDtrD.DrfPatTyp = "DrfPatTyp";
            dfDtrD.DrfRcpNum = "DrfRcpNum";
            dfDtrD.DrfRcpSeq = "DrfRcpSeq";
            dfDtrD.DrfSeqNum = "DrfSeqNum";
            dfDtrD.DrfUidCod = "DrfUidCod";
            dfDtrD.DrfUpdDtm = "DrfUpdDtm";
            dfDtrD.DtrCode = "dtr_code";
            dfDtrD.MonthId = "month_id";
            dfDtrD.StatusApprove = "status_approve";
            dfDtrD.StatusDoc = "status_doc";
            dfDtrD.YearId = "year_id";
            dfDtrD.OdrQty = "odrqty";
            dfDtrD.OdrPrc = "odrprc";
            dfDtrD.OrpChtNum = "OrpChtNum";
            dfDtrD.InsCodNam = "InsCodNam";
            dfDtrD.orptotamt = "orptotamt";
            dfDtrD.ItmKorNam = "ItmKorNam";
            dfDtrD.ItmCod = "ItmCod";
            dfDtrD.ItmAstCod = "ItmAstCod";
            dfDtrD.ItmSrvOpd = "ItmSrvOpd";
            dfDtrD.df = "df";
            dfDtrD.DtrName = "dtr_name";

            dfDtrD.table = "df_t_doctor_detail";
            dfDtrD.pkField = "df_id";

        }
        public DataTable selectByDfId(String dfId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            int cnt = 0;
            sql = "Select * From " + dfDtrD.table + " Where active = '1'  and df_id =" + dfId + " Order By df_detail_id";

            dt = connORCBA.selectData(sql, "orc_ba");
            

            return dt;
        }
        public String insert(DfTDoctorDetail p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.DfId == "")
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + dfDtrD.table + "(" + dfDtrD.Active + "," + dfDtrD.DrfBilNum + "," +
                    dfDtrD.DrfOcmNum + "," + dfDtrD.DrfOdrAmt + "," + dfDtrD.DrfOdrDtm + "," +
                    dfDtrD.DrfOdrSeq + "," + dfDtrD.DrfRcpNum + "," + dfDtrD.DtrCode + "," +
                    dfDtrD.ItmAstCod + "," + dfDtrD.ItmCod + "," + dfDtrD.ItmKorNam + "," +
                    dfDtrD.OdrQty + "," + dfDtrD.OdrPrc + "," +
                    dfDtrD.StatusApprove + "," + dfDtrD.StatusDoc + "," + dfDtrD.YearId + "," + dfDtrD.MonthId + "," + dfDtrD.DfId + ") " +
                    "Values('" + p.Active + "','" + p.DrfBilNum + "','" +
                    p.DrfOcmNum + "','" + p.DrfOdrAmt + "','" + p.DrfOdrDtm + "','" +
                    p.DrfOdrSeq + "','" + p.DrfRcpNum + "','" + p.DtrCode + "','" +
                    p.ItmAstCod + "','" + p.ItmCod + "','" + p.ItmKorNam + "'," +
                    p.OdrQty + "," + p.OdrPrc + ",'"  +
                    p.StatusApprove + "','" + p.StatusDoc + "','" + p.YearId + "','" + p.MonthId + "'," + p.DfId + ") ";
                chk = connORCBA.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }

            return chk;
        }
        public String update(DfTDoctorDetail p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + dfDtrD.table + " Set " + dfDtrD.DrfBilNum + "='" + p.DrfBilNum + "'," +
                    dfDtrD.DrfOcmNum + "='" + p.DrfOcmNum + "'," +
                    dfDtrD.DrfOdrAmt + "='" + p.DrfOdrAmt + "'," +
                    dfDtrD.DrfOdrDtm + "='" + p.DrfOdrDtm + "'," +
                    dfDtrD.DrfOdrSeq + "='" + p.DrfOdrSeq + "'," +
                    dfDtrD.DrfRcpNum + "='" + p.DrfRcpNum + "'," +
                    dfDtrD.DtrCode + "='" + p.DtrCode + "'," +
                    dfDtrD.ItmAstCod + "='" + p.ItmAstCod + "'," +
                    dfDtrD.ItmCod + "='" + p.ItmCod + "'," +
                    dfDtrD.ItmKorNam + "='" + p.ItmKorNam + "'," +
                    dfDtrD.OdrQty + "='" + p.OdrQty + "', " +
                    dfDtrD.OdrPrc + "='" + p.OdrPrc + "', " +
                    //dfDtrD.DtrName + "='" + p.DtrName + "', " +                    
                    dfDtrD.StatusApprove + "='" + p.StatusApprove + "', " +
                    dfDtrD.StatusDoc + "='" + p.StatusDoc + "', " +
                    dfDtrD.YearId + "='" + p.YearId + "', " +
                    dfDtrD.MonthId + "='" + p.MonthId + "', " +
                    dfDtrD.DfId + "=" + p.DfId + " " +

                    "Where " + dfDtrD.pkField + "=" + p.DfDId;
                chk = connORCBA.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update Doctor");
            }
            return chk;
        }
    }
}
