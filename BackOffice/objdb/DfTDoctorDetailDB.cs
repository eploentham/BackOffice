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
        private void setData(DfTDoctorDetail p, DataTable dt)
        {
            //p = new Doctor();
            p.Active = dt.Rows[0][dfDtrD.Active].ToString();
            p.DfDId = dt.Rows[0][dfDtrD.DfDId].ToString();
            p.DfId = dt.Rows[0][dfDtrD.DfId].ToString();
            p.DrfBilNum = dt.Rows[0][dfDtrD.DrfBilNum].ToString();
            p.DrfCalNum = dt.Rows[0][dfDtrD.DrfCalNum].ToString();
            p.DrfCtrCodv = dt.Rows[0][dfDtrD.DrfCtrCodv].ToString();
            p.DrfCtrSeq = dt.Rows[0][dfDtrD.DrfCtrSeq].ToString();
            p.DrfCurStt = dt.Rows[0][dfDtrD.DrfCurStt].ToString();
            p.DrfDivYon = dt.Rows[0][dfDtrD.DrfDivYon].ToString();
            p.DrfGrpSeq = dt.Rows[0][dfDtrD.DrfGrpSeq].ToString();
            p.DrfIncCod = dt.Rows[0][dfDtrD.DrfIncCod].ToString();
            p.DrfOcmNum = dt.Rows[0][dfDtrD.DrfOcmNum].ToString();
            p.DrfOdrAmt = dt.Rows[0][dfDtrD.DrfOdrAmt].ToString();
            p.drfodrcod = dt.Rows[0][dfDtrD.drfodrcod].ToString();
            p.DrfOdrDtm = dt.Rows[0][dfDtrD.DrfOdrDtm].ToString();
            p.DrfOdrSeq = dt.Rows[0][dfDtrD.DrfOdrSeq].ToString();
            p.DrfOspTyp = dt.Rows[0][dfDtrD.DrfOspTyp].ToString();
            p.DrfPatTyp = dt.Rows[0][dfDtrD.DrfPatTyp].ToString();
            p.DrfRcpNum = dt.Rows[0][dfDtrD.DrfRcpNum].ToString();
            p.DrfRcpSeq = dt.Rows[0][dfDtrD.DrfRcpSeq].ToString();
            p.DrfSeqNum = dt.Rows[0][dfDtrD.DrfSeqNum].ToString();
            p.DrfUidCod = dt.Rows[0][dfDtrD.DrfUidCod].ToString();
            p.DrfUpdDtm = dt.Rows[0][dfDtrD.DrfUpdDtm].ToString();
            p.DtrCode = dt.Rows[0][dfDtrD.DtrCode].ToString();
            p.MonthId = dt.Rows[0][dfDtrD.MonthId].ToString();
            p.StatusApprove = dt.Rows[0][dfDtrD.StatusApprove].ToString();
            p.StatusDoc = dt.Rows[0][dfDtrD.StatusDoc].ToString();
            p.YearId = dt.Rows[0][dfDtrD.YearId].ToString();
            p.OdrQty = dt.Rows[0][dfDtrD.OdrQty].ToString();
            p.OdrPrc = dt.Rows[0][dfDtrD.OdrPrc].ToString();
            p.OrpChtNum = dt.Rows[0][dfDtrD.OrpChtNum].ToString();
            p.InsCodNam = dt.Rows[0][dfDtrD.InsCodNam].ToString();
            p.orptotamt = dt.Rows[0][dfDtrD.orptotamt].ToString();
            p.ItmKorNam = dt.Rows[0][dfDtrD.ItmKorNam].ToString();
            p.ItmCod = dt.Rows[0][dfDtrD.ItmCod].ToString();
            p.ItmAstCod = dt.Rows[0][dfDtrD.ItmAstCod].ToString();
            p.ItmSrvOpd = dt.Rows[0][dfDtrD.ItmSrvOpd].ToString();
            p.df = dt.Rows[0][dfDtrD.df].ToString();
            p.DtrName = dt.Rows[0][dfDtrD.DtrName].ToString();

            //return p;
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
        public String selectDfDtrCodeMonthly(String dtrCode)
        {
            String sql = "", df="";
            DataTable dt = new DataTable();
            int cnt = 0;
            sql = "Select sum(df) as df From " + dfDtrD.table + " Where active = '1'  and "+ dfDtrD .DtrCode+ " ='" + dtrCode + "' and "+dfDtrD.StatusDoc+"='0' and "+dfDtrD.StatusApprove+"='0'";

            dt = connORCBA.selectData(sql, "orc_ba");

            if (dt.Rows.Count > 0)
            {
                df = dt.Rows[0]["df"].ToString();
            }
            return df;
        }
        public DfTDoctorDetail selectByDtrCodeItmCod(String dtrCode, String itmcod)
        {
            String sql = "";
            DataTable dt = new DataTable();
            DfTDoctorDetail dfdtrd = new DfTDoctorDetail();
            int cnt = 0;
            sql = "Select * From " + dfDtrD.table + " Where active = '1'  and " + dfDtrD.DtrCode + " ='" + dtrCode + "' and " + dfDtrD.ItmAstCod + "='" + itmcod + "'";

            dt = connORCBA.selectData(sql, "orc_ba");
            setData(dfdtrd, dt);

            return dfdtrd;
        }
        public String insert(DfTDoctorDetail p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.DfId.Equals(""))
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
                    dfDtrD.StatusApprove + "," + dfDtrD.StatusDoc + "," + dfDtrD.YearId + "," + dfDtrD.MonthId + "," + dfDtrD.DfId + "," + dfDtrD.df + ") " +
                    "Values('" + p.Active + "','" + p.DrfBilNum + "','" +
                    p.DrfOcmNum + "','" + p.DrfOdrAmt + "','" + p.DrfOdrDtm + "','" +
                    p.DrfOdrSeq + "','" + p.DrfRcpNum + "','" + p.DtrCode + "','" +
                    p.ItmAstCod + "','" + p.ItmCod + "','" + p.ItmKorNam + "'," +
                    p.OdrQty + "," + p.OdrPrc + ",'"  +
                    p.StatusApprove + "','" + p.StatusDoc + "','" + p.YearId + "','" + p.MonthId + "'," + p.DfId + "," + p.df + ") ";
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
        public String updateDf(String DfDId, String df)
        {
            String sql = "", chk = "";
            sql = "Update " + dfDtrD.table + " Set " + dfDtrD.df + " = " + df + " " +
                "Where " + dfDtrD.pkField + "='" + DfDId + "'";
            try
            {
                chk = connORCBA.ExecuteNonQuery(sql, "orc_ba");
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
    }
}
