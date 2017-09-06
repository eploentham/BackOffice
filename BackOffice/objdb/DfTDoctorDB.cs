using BackOffice.object1;
using MySql.Data.MySqlClient;
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
        ConnectDB connORCBA, connORCBIT;
        public DoctorRate dtrR;
        public DfTDoctor dfDtr;
        public DfTDoctorDetailDB dfDtrDDB;
        private DoctorRateDB dtrRDB;
        public DfTDoctorDB(ConnectDB orc_bit, ConnectDB connorc_ba)
        {
            connORCBIT = orc_bit;
            connORCBA = connorc_ba;
            initConfig();
        }
        private void initConfig()
        {
            dtrR = new DoctorRate();
            dfDtr = new DfTDoctor();
            dfDtrDDB = new DfTDoctorDetailDB(connORCBIT, connORCBA);
            dtrRDB = new DoctorRateDB(connORCBA);
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
            dfDtr.InsCod = "inscod";
            dfDtr.ItmAstCod = "ItmAstCod";
            dfDtr.ItmSrvOpd = "ItmSrvOpd";
            dfDtr.df = "df";
            dfDtr.DtrName = "dtr_name";

            dfDtr.table = "df_t_doctor";
            dfDtr.pkField = "df_id";

        }
        public DataTable selectByDoctor(String dtrCode, String YearId, String MonthId)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dfDtr.table + " Where active = '1' and " + dfDtr.DtrCode + " = '" + dtrCode + "' Order By row1";

            dt = connORCBA.selectData(sql, "orc_ba");
            //item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return dt;
        }
        public DataTable selectDfMonthly()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "SELECT dtr_code, dtr_name  " +
                "FROM df_t_doctor " +
                "where status_doc = '0' and status_approve = '0' and active = '1' " +
                "Group By dtr_code; ";
            dt = connORCBA.selectData(sql, "orc_ba");
            return dt;
        }
        public int selectCntByDoctor(String dtrCode, String curDate)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            int cnt = 0;
            sql = "Select count(1) as cnt From " + dfDtr.table + " Where active = '1' and " + dfDtr.DtrCode + " = '" + dtrCode + "' and drfodrdtm >='" + curDate + "0000' and drfodrdtm <='" + curDate + "2359' Order By row1";

            dt = connORCBA.selectData(sql, "orc_ba");
            cnt = dt.Rows.Count > 0 ? cnt = dt.Rows.Count : 0;

            return cnt;
        }
        public DataTable selectDtrImport(String dailyDate)
        {
            //String sql = "select psp.PspPatNam, psp.PspSurNam, orp.OrpChtNum   " +
            //                " , uidm.UidNam as UidNam, uidd.UidNam as dtrNam, odr.odritmcod, odr.odrastcod, odr.odrseq, odr.odrocmnum  " +
            //                ", insm.inscodnam, orp.orptotamt, itmm.Itmkornam, odr.odritmcod, odr.odrastcod, itmm.itmsrvopd, drf.*  "
            //                + "From drfrcp1 drf "
            //                + "left join OrpInf1 orp on drf.DrfRcpNum = orp.OrpRcpNum  and orp.Orpocmnum = drf.drfocmnum   "
            //                + "left join OdrInf1 odr on odr.OdrOcmNum = orp.OrpOcmNum  "
            //                + "left join UidMst1 uidm on uidm.UidCod = drf.drfuidcod   "
            //                + "left join UidMst1 uidd on uidd.UidCod = drf.drfdtrcod  "
            //                + "left join pspinf1 psp on orp.OrpChtNum = psp.PspChtNum    "
            //                + "left join InsMst1 insm on insm.InsCod = orp.OrpInsCod  "
            //                + "inner join ItmMst1 itmm on itmm.ItmCod = odr.OdrItmCod and itmm.ItmAstCod = odr.OdrAstCod "
            //                + "Where  orp.OrpCtrCod = 'TOTAL' and drfodrdtm >='" + dailyDate + "0000' and drfodrdtm <='" + dailyDate + "2359' and itmm.ItmSrvOpd = '11' " +
            //                "order by drf.drfodrdtm, drf.drfodrseq ";
            String sql = "select psp.PspPatNam, psp.PspSurNam, orp.OrpChtNum    , uidm.UidNam as UidNam, uidd.UidNam as dtrNam  , orp.orptotamt,orp.OrpInsCod,insm.inscodnam, drf.*  "
                            + "From drfrcp1 drf "
                            + "left join OrpInf1 orp on drf.DrfRcpNum = orp.OrpRcpNum  and orp.Orpocmnum = drf.drfocmnum  "
                            + "left join UidMst1 uidm on uidm.UidCod = drf.drfuidcod   "
                            + "left join UidMst1 uidd on uidd.UidCod = drf.drfdtrcod  "
                            + "left join pspinf1 psp on orp.OrpChtNum = psp.PspChtNum    "
                            + "left join InsMst1 insm on insm.InsCod = orp.OrpInsCod  "
                            + "Where  orp.OrpCtrCod = 'TOTAL' and drfodrdtm >='" + dailyDate + "0000' and drfodrdtm <='" + dailyDate + "2359' and drf.drfosptyp = 'I' " +
                            "order by drf.drfodrdtm, drf.drfodrseq ";

            DataTable dt = new DataTable();
            dt = connORCBIT.selectData(sql, "orc_bit");
            return dt;
        }
        public DataTable selectDtrDImport(String drfrcpnum)
        {
            String sql = "select odr.odritmcod, odr.odrastcod, odr.odrseq, odr.odrocmnum  " +
                            ", insm.inscodnam, orp.orptotamt, itmm.Itmkornam, odr.odritmcod, odr.odrastcod, itmm.itmsrvopd, odr.odramt, odr.odrqty, odr.odrprc, drf.*  "
                            + "From drfrcp1 drf "
                            + "left join OrpInf1 orp on drf.DrfRcpNum = orp.OrpRcpNum  and orp.Orpocmnum = drf.drfocmnum   "
                            + "left join OdrInf1 odr on odr.OdrOcmNum = orp.OrpOcmNum  "                                                    
                            + "left join InsMst1 insm on insm.InsCod = orp.OrpInsCod  "
                            + "inner join ItmMst1 itmm on itmm.ItmCod = odr.OdrItmCod and itmm.ItmAstCod = odr.OdrAstCod "
                            + "Where  orp.OrpCtrCod = 'TOTAL' and drf.DrfRcpNum ='" + drfrcpnum + "' and itmm.ItmSrvOpd = '11' " +
                            "order by drf.drfodrdtm, drf.drfodrseq ";


            DataTable dt = new DataTable();
            dt = connORCBIT.selectData(sql, "orc_bit");
            return dt;
        }
        public int selectCntDate(String curDate)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            int cnt = 0;
            sql = "Select count(1) as cnt From " + dfDtr.table + " Where active = '1'  and drfodrdtm >='" + curDate + "0000' and drfodrdtm <='" + curDate + "2359' Order By df_id";

            dt = connORCBA.selectData(sql, "orc_ba");
            cnt = dt.Rows.Count > 0 ? cnt = int.Parse(dt.Rows[0]["cnt"].ToString()) : 0;

            return cnt;
        }
        public DataTable selectByDate(String curDate)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dfDtr.table + " Where active = '1'  and drfodrdtm >='" + curDate + "0000' and drfodrdtm <='" + curDate + "2359' Order By df_id";

            dt = connORCBA.selectData(sql, "orc_ba");
            //item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return dt;
        }
        public DataTable selectDfToImport(String dailyDate)
        {
            int cnt = 0;
            String id = "";
            DataTable dt = new DataTable();
            DataTable dtD = new DataTable();

            cnt = selectCntDate(dailyDate);
            if (cnt <= 0)
            {
                int chk = 0;
                dt = selectDtrImport(dailyDate);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    DfTDoctor df = new DfTDoctor();
                    df.Active = "1";
                    df.DfId = "0";
                    df.DrfBilNum = dt.Rows[i]["DrfBilNum"].ToString().Trim();
                    df.DrfCalNum = "";
                    df.DrfCtrCodv = "";
                    df.DrfCtrSeq = "";
                    df.DrfCurStt = "";
                    df.DrfDivYon = "";
                    df.DrfGrpSeq = "";
                    df.DrfIncCod = "";
                    df.DrfOcmNum = "";
                    df.DrfOdrAmt = dt.Rows[i]["DrfOdrAmt"].ToString().Trim();
                    df.drfodrcod = "";
                    df.DrfOdrDtm = dt.Rows[i]["DrfOdrDtm"].ToString().Trim();
                    df.DrfOdrSeq = "";
                    df.DrfOspTyp = "";
                    df.DrfPatTyp = dt.Rows[i]["DrfPatTyp"].ToString().Trim();
                    df.DrfRcpNum = dt.Rows[i]["DrfRcpNum"].ToString().Trim();
                    df.DrfRcpSeq = dt.Rows[i]["DrfRcpSeq"].ToString().Trim();
                    df.DrfUidCod = dt.Rows[i]["DrfUidCod"].ToString().Trim();
                    df.DrfUpdDtm = "";
                    df.DtrCode = dt.Rows[i]["DrfDtrCod"].ToString().Trim();
                    df.InsCodNam = dt.Rows[i]["inscodnam"].ToString().Trim();
                    df.DrfSeqNum = dt.Rows[i]["DrfSeqNum"].ToString().Trim();
                    df.ItmAstCod = "";
                    df.InsCod = dt.Rows[i]["OrpInsCod"].ToString().Trim();
                    df.ItmKorNam = "";
                    df.ItmSrvOpd = "";
                    df.MonthId = "";
                    df.OrpChtNum = dt.Rows[i]["OrpChtNum"].ToString().Trim();
                    df.orptotamt = dt.Rows[i]["orptotamt"].ToString().Trim();
                    df.PspPatNam = dt.Rows[i]["PspPatNam"].ToString().Trim();
                    df.PspSurNam = dt.Rows[i]["PspSurNam"].ToString().Trim();
                    df.StatusApprove = "0";
                    df.StatusDoc = "0";
                    df.YearId = "";
                    df.df = "0";
                    df.DtrName = dt.Rows[i]["dtrNam"].ToString().Trim();
                    id = insert(df);

                    dtD = selectDtrDImport(df.DrfRcpNum);
                    for(int j = 0; j < dtD.Rows.Count; j++)
                    {
                        DoctorRate dtrR = new DoctorRate();
                        String df1 = dtrRDB.calDf(dtD.Rows[j]["DrfDtrCod"].ToString().Trim(), dtD.Rows[j]["odritmcod"].ToString().Trim(), dtD.Rows[j]["odrastcod"].ToString().Trim(), Decimal.Parse(dtD.Rows[j]["odramt"].ToString().Trim()));
                        DfTDoctorDetail dfD = new DfTDoctorDetail();
                        dfD.Active = "1";
                        dfD.DfId = id;
                        dfD.DfDId = "";
                        dfD.DrfBilNum = dt.Rows[i]["DrfBilNum"].ToString().Trim();
                        dfD.DrfCalNum = "";
                        dfD.DrfCtrCodv = "";
                        dfD.DrfCtrSeq = "";
                        dfD.DrfCurStt = "";
                        dfD.DrfDivYon = "";
                        dfD.DrfGrpSeq = "";
                        dfD.DrfIncCod = "";
                        dfD.DrfOcmNum = dtD.Rows[j]["drfocmnum"].ToString().Trim();
                        dfD.DrfOdrAmt = dtD.Rows[j]["odramt"].ToString().Trim();
                        dfD.drfodrcod = "";
                        dfD.DrfOdrDtm = dt.Rows[i]["DrfOdrDtm"].ToString().Trim();
                        dfD.DrfOdrSeq = dtD.Rows[j]["Drfodrseq"].ToString().Trim();
                        dfD.DrfOspTyp = "";
                        dfD.DrfPatTyp = "";
                        dfD.DrfRcpNum = dtD.Rows[j]["DrfRcpNum"].ToString().Trim();
                        dfD.DrfRcpSeq = "";
                        df.DrfUidCod = "";
                        dfD.DrfUpdDtm = "";
                        dfD.DtrCode = dtD.Rows[j]["DrfDtrCod"].ToString().Trim();
                        dfD.InsCodNam = "";
                        dfD.DrfSeqNum = "";
                        dfD.ItmAstCod = dtD.Rows[j]["odrastcod"].ToString().Trim();
                        dfD.ItmCod = dtD.Rows[j]["odritmcod"].ToString().Trim();
                        dfD.ItmKorNam = dtD.Rows[j]["itmkornam"].ToString().Trim();
                        dfD.ItmSrvOpd = "";
                        dfD.MonthId = "";
                        dfD.OrpChtNum = "";
                        dfD.orptotamt = "";
                        dfD.OdrQty = dtD.Rows[j]["odrqty"].ToString().Trim();
                        dfD.OdrPrc = dtD.Rows[j]["odrprc"].ToString().Trim();
                        dfD.StatusApprove = "0";
                        dfD.StatusDoc = "0";
                        dfD.YearId = "";
                        dfD.df = df1;
                        dfD.DtrName = dt.Rows[i]["dtrNam"].ToString().Trim();
                        dfDtrDDB.insert(dfD);
                    }
                    
                    chk++;
                }
            }
            dt.Clear();
            dt = selectByDate(dailyDate);
            return dt;
        }
        private String insert(DfTDoctor p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.OrpChtNum == "")
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + dfDtr.table + "(" + dfDtr.Active + "," + dfDtr.DrfBilNum + "," +
                    dfDtr.DrfOdrAmt + "," + dfDtr.DrfOdrDtm + "," + dfDtr.DrfPatTyp + "," +
                    dfDtr.DrfRcpNum + "," + dfDtr.DrfRcpSeq + "," + dfDtr.DrfUidCod + "," +
                    dfDtr.DtrCode + "," + dfDtr.DrfSeqNum + "," + dfDtr.OrpChtNum + "," +
                    dfDtr.orptotamt + "," + dfDtr.PspPatNam + "," + dfDtr.PspSurNam + "," +
                    dfDtr.StatusApprove + "," + dfDtr.StatusDoc + "," + dfDtr.YearId + "," + 
                    dfDtr.MonthId + "," + dfDtr.DtrName + "," + dfDtr.InsCod + "," + dfDtr.InsCodNam + ") " +
                    "Values('" + p.Active + "','" + p.DrfBilNum + "','" +
                    p.DrfOdrAmt + "','" + p.DrfOdrDtm + "','" + p.DrfPatTyp + "','" +
                    p.DrfRcpNum + "','" + p.DrfRcpSeq + "','" + p.DrfUidCod + "','" +
                    p.DtrCode + "','" + p.DrfSeqNum + "','" + p.OrpChtNum + "','" +
                    p.orptotamt + "','" + p.PspPatNam + "','" + p.PspSurNam + "','" +
                    p.StatusApprove + "','" + p.StatusDoc + "','" + p.YearId + "','" + 
                    p.MonthId + "','" + p.DtrName + "','" + p.InsCod + "','" + p.InsCodNam + "') ";
                chk = connORCBA.ExecuteNonQueryAutoIncrement(sql, "orc_ba");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }

            return chk;
        }
        public String update(DfTDoctor p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + dfDtr.table + " Set " + dfDtr.DrfBilNum + "='" + p.DrfBilNum + "'," +
                    dfDtr.DrfOdrAmt + "='" + p.DrfOdrAmt + "'," +
                    dfDtr.DrfOdrDtm + "='" + p.DrfOdrDtm + "'," +
                    dfDtr.DrfPatTyp + "='" + p.DrfPatTyp + "'," +
                    dfDtr.DtrCode + "='" + p.DtrCode + "'," +
                    dfDtr.DrfRcpNum + "='" + p.DrfRcpNum + "'," +
                    dfDtr.DrfRcpSeq + "='" + p.DrfRcpSeq + "'," +
                    dfDtr.DrfUidCod + "='" + p.DrfUidCod + "'," +
                    dfDtr.DtrCode + "='" + p.DtrCode + "'," +
                    dfDtr.DrfSeqNum + "='" + p.DrfSeqNum + "'," +
                    dfDtr.OrpChtNum + "='" + p.OrpChtNum + "', " +
                    dfDtr.orptotamt + "='" + p.orptotamt + "', " +
                    dfDtr.PspPatNam + "='" + p.PspPatNam + "', " +
                    dfDtr.PspSurNam + "='" + p.PspSurNam + "', " +
                    dfDtr.StatusApprove + "='" + p.StatusApprove + "', " +
                    dfDtr.StatusDoc + "='" + p.StatusDoc + "', " +
                    dfDtr.YearId + "='" + p.YearId + "', " +
                    dfDtr.MonthId + "='" + p.MonthId + "' " +

                    "Where " + dfDtr.pkField + "=" + p.DfId ;
                chk = connORCBA.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update Doctor");
            }
            return chk;
        }
        public String updateDf(String DfId, String df)
        {
            String sql = "", chk = "";
            sql = "Update " + dfDtr.table + " Set " + dfDtr.df + " = "+df+" " +
                "Where " + dfDtr.pkField + "='" + DfId + "'";
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
