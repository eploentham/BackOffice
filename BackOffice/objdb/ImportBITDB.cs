using BackOffice;
using BackOffice.objdb;
using BackOffice.object1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public class ImportBITDB
    {
        private ConnectDB conn, connBIT, connBA, connBITDemo;
        private ControlMaster cm;
        public ImportBITDB()
        {
            cm = new ControlMaster();

            conn = new ConnectDB("orc_bit", cm.initC);
            connBIT = new ConnectDB("bit", cm.initC);
            connBA = new ConnectDB("orc_ba", cm.initC);            
        }
        public void ImportOrpInf(String curDate)
        {
            String sql = "", col="", sql1="";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From orpinf1 Where orpupddtm >= '"+ curDate+ "0000' and orpupddtm <= '"+curDate+"2359'";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * From orpinf Where orpupddtm >= '" + curDate + "0000' and orpupddtm <= '" + curDate + "2359'";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName+",";
            }
            col = col.Length>0 ? col.Substring(0,col.Length-1):"";
            
            sql1 = "Insert Into orpinf1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1+" Values("+ dat1.ToString()+")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportPbsInf(String curDate)
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From pbsinf1 Where pbsnewdte = '" + curDate + "' ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * From pbsinf Where pbsnewdte = '" + curDate + "' ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into pbsinf1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim().Replace("'", "''")).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportOdlInf(String curDate)
        {
            String sql = "", col = "", sql1 = "",txt="";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            int i = 0;
            sql = "Delete " +
                "From odlinf1 " +
                "Where odlrcpnum in (select orprcpnum from orpinf1 where orpinf1.orpupddtm >= '" + curDate + "0000' and orpinf1.orpupddtm <= '" + curDate + "2359')";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select odli.* " +
                "From odlinf as odli " 
                +"left join OrpInf orpi on odli.odlRcpNum = orpi.OrpRcpNum  "
                + "Where orpi.orpupddtm >= '" + curDate + "0000' and orpi.orpupddtm <= '" + curDate + "2359'";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into odlinf1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";        กายภาพบำบัด 201706291617
                    
                    dat.Append("'").Append(row[dc].ToString().Trim().Replace("'","''")).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
                i++;
            }
        }
        public void ImportUidMst()
        {
            String sql = "", col = "", sql1 = "", txt = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            //DataTable dtTit = new DataTable();
            DoctorDB dtrdb = new DoctorDB(connBA);
            int i = 0;

            //dtTit = cm.selectTitle();

            sql = "Delete From uidmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From uidmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into uidmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    if (row[dc].ToString().Trim().Equals("กายภาพบำบัด"))
                    {
                        txt = "";
                    }
                    if (row[dc].ToString().Trim().Equals("201706291617"))
                    {
                        txt = "";
                    }
                    if (i == 87)
                    {
                        txt = "";
                    }
                    dat.Append("'").Append(row[dc].ToString().Trim().Replace("'", "''")).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");

                if (row["uidprtcod"].ToString().Trim().Equals("DTR"))
                {
                    String[] aa = row["uidnam"].ToString().Split(' ');
                    Doctor dtr = new Doctor();
                    dtr.Code = row["uidcod"].ToString().Trim();
                    dtr.Address = "";
                    dtr.AppointmnetCnt = "10";
                    dtr.BankNO = "";
                    if (aa.Length == 2)
                    {
                        dtr.DtrFnameT = aa[0].Trim();
                        dtr.DtrSnameT = aa[1].Trim();
                    }else if (aa.Length == 3)
                    {
                        dtr.DtrTitCode = cm.getTitCod(aa[0].Trim());
                        dtr.DtrFnameT = aa[1].Trim();
                        dtr.DtrSnameT = aa[2].Trim();
                    }
                        //dtr.DtrFname = (aa.Length > 1) ? aa[0].Trim() : "";
                        //dtr.DtrSname = (aa.Length > 2) ? aa[2].Trim() : "";

                    dtr.DtrMedicalField = "";
                    dtr.DtrTitCode = "";
                    dtr.DtrTypCode = "";
                    dtr.Phone = "";
                    dtr.Remark = "";
                    dtr.SalaryMin = "";
                    dtr.TaxID = "";

                    dtrdb.insertFormImport(dtr);
                }
            }
        }
        public void ImportInsMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From insmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From insmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into insmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportDrfRcp(String curDate)
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From drfrcp1 Where drfupddtm >= '" + curDate + "0000' and drfupddtm <= '" + curDate + "2359'";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * From drfrcp Where drfupddtm >= '" + curDate + "0000' and drfupddtm <= '" + curDate + "2359'";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into drfrcp1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportDtlMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From dtlmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From dtlmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into dtlmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(MySql.Data.MySqlClient.MySqlHelper.EscapeString(row[dc].ToString().Trim().Replace("'", "''"))).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportPspInf(String curDate)
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From pspinf1 Where pspupddtm >= '" + curDate + "0000' and pspupddtm <= '" + curDate + "2359'";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * From pspinf Where pspupddtm >= '" + curDate + "0000' and pspupddtm <= '" + curDate + "2359'";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into pspinf1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim().Replace("'", "''")).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportDepMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From depmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From depmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into depmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportItmMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From itmmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From itmmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into itmmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportOdrInf(String curDate)
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From odrinf1 Where odrdtm >= '" + curDate + "0000' and odrdtm <= '" + curDate + "2359'";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * From odrinf Where odrdtm >= '" + curDate + "0000' and odrdtm <= '" + curDate + "2359'";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into odrinf1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportGrpMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From grpmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From grpmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into grpmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportGrdMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From grdmst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From grdmst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into grdmst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void ImportFeeMst()
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            sql = "Delete From feemst1 ";
            conn.ExecuteNonQuery(sql, "orc_bit");

            sql = "Select * " +
                "From feemst ";
            dt = connBIT.selectData(sql, "bit");

            foreach (DataColumn column in dt.Columns)
            {
                col += column.ColumnName + ",";
            }
            col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";

            sql1 = "Insert Into feemst1(" + col + ") ";
            //for(int i = 0; i < dt.Rows.Count; i++)
            foreach (DataRow row in dt.Rows)
            {
                dat.Clear();
                dat1.Clear();
                foreach (DataColumn dc in dt.Columns)
                {
                    //dat += "'"+row[dc].ToString().Trim()+"',";
                    dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                }
                dat1.Append(dat.ToString(0, dat.Length - 1));
                sql = sql1 + " Values(" + dat1.ToString() + ")";
                conn.ExecuteNonQuery(sql, "orc_bit");
            }
        }
        public void DeleteDatabase(String dbName, Label lb, Form aa)
        {
            string[] stringarrayNoHave = { "BCK_CSR_20160304_zDyd", "BCK_CSR_20160304_zEdt", "Bck_DOC_20160409", "Bck_DocMst_20160405", "Bck_DrfRcp_20160408", "Bck_Xitdinf_20160401", "Bck_XiteInf_20160401", "Datachk", "Datachk2", "Datachk3", "CkgInf", "CkgMst", "CksInf", "CksMst", "CkvInf", "CutCprTyp", "Datachk1", "DTLRPT", "EmrInf", "StkOnHnd", "sysdiagrams", "StkOnHnd", "Table1", "TpgMst", "TpmMst", "Mig_UidMst_20160408", "Mig_TTDOC", "Mig_DocMst_20160408", "Mig_CSR20160303", "MedicalPerformance_MedicalPerformance_update_S", "MedicalPerformance_MedicalPerformance_update_Q", "MedicalPerformance_MedicalPerformance_update_O", "MedicalPerformance_MedicalPerformance_update_M", "MedicalPerformance_MedicalPerformance_T", "MedicalPerformance_MedicalPerformance_S", "MedicalPerformance_MedicalPerformance_R", "MedicalPerformance_MedicalPerformance_Q", "MedicalPerformance_MedicalPerformance_O", "MedicalPerformance_MedicalPerformance_M", "MafInf", "IngMst", "IitMst", "IddInf", "'XItzInf", "XRisInf", "ZBudInf", "PhyInf", "PbaInf", "RcsMst", "RemEnd", "RemEnd2", "RemEnd3", "RrdInf", "RrpInf", "RrqInf", "RsbTmp", "UidMst_20160409_repeat", "ZStfInf", "ZSdfInf" };
            string[] stringarraySetOn = { "CkgInf", "CkgMst", "CksInf", "CksMst", "CkvInf", "CmrInf", "DB_CubMst", "DB_OlpLog", "CstInf", "DB_DteMst", "DrfRcp", "FrmMst", "ImgInf", "LogInf", "OjnMst", "ImgMst", "IthInf", "MalInf", "SEQ_OCMNUM", "SEQ_RCPNUM", "SEQ_LBQACP", "SEQ_IRCNUM", "SbsInf", "RsbInf", "RPT_RptMst", "RctMst", "RcmMst", "ZOjnMst", "WskInf", "OpsInf", "OrpMan", "RltInf", "SEQ_FAKEBILL", "WskInf" };
            //string[] stringarrayInsert = { "feemst", "grdmst", "grpmst", "odrinf", "itmmst", "depmst", "pspinf", "drfrcp", "insmst", "uidmst", "odlinf", "orpinf" }
            string[] stringarrayInsert = { "uidmst", "depmst" };
            string[] stringarrayNoDelete = { "HspMst" };
            String reverse = "";

            String sql = "", col = "", sql1 = "", sqlOn="", sqlOff="",err="";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();
            DataTable toReverse = new DataTable();

            String databaseDBBITDemo1 = "bithis_demo";             //bit demo
            String hostDBBITDemo1 = "localhost";
            String userDBBITDemo1 = "sa";
            String passDBBITDemo1 = "Ekartc2c5";
            String portDBBITDemo1 = "3306";

            SqlConnection connBITDemo1;

            connBITDemo1 = new SqlConnection();
            connBITDemo1.ConnectionString = "Server=" + hostDBBITDemo1 + ";Database=" + databaseDBBITDemo1 + ";Uid=" + userDBBITDemo1 + ";Pwd=" + passDBBITDemo1 + ";Connection Timeout=300;";

            connBITDemo = new ConnectDB("bithis", cm.initC);
            sql = "SELECT TABLE_NAME "+
                "FROM INFORMATION_SCHEMA.TABLES "+
                "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '"+ dbName + "' "+
                "Order by TABLE_NAME";
            dt = connBITDemo.selectDataForConvert(sql, "bit_demo");
            
            foreach (DataRow row in dt.Rows)
            {
                bool bol = Array.Exists(stringarrayNoHave, E => E == row["TABLE_NAME"].ToString());
                if (bol)
                {
                    continue;
                }
                bool bolSetOn = Array.Exists(stringarraySetOn, E => E == row["TABLE_NAME"].ToString());
                if (bolSetOn)
                {
                    sqlOn = "SET IDENTITY_INSERT dbo." + row["TABLE_NAME"].ToString() + " ON;";
                    sqlOff = "SET IDENTITY_INSERT dbo." + row["TABLE_NAME"].ToString() + " OFF;";
                    connBITDemo.ExecuteNonQueryForConvert(sql, "bit_demo");
                }
                if (row["TABLE_NAME"].ToString().Trim().Equals("OdrInf"))
                {
                    err = "";
                }
                else
                {
                    //continue;
                }
                if (row["TABLE_NAME"].ToString().Trim().ToLower().Equals(reverse.ToLower()))
                {
                    toReverse.Clear();
                    sql = "Select * From " + row["TABLE_NAME"].ToString().Trim();
                    SqlCommand comMainhis = new SqlCommand();
                    comMainhis.CommandText = sql;
                    comMainhis.CommandType = CommandType.Text;
                    comMainhis.Connection = connBITDemo1;
                    SqlDataAdapter adapMainhis = new SqlDataAdapter(comMainhis);
                    try
                    {
                        connBITDemo1.Open();
                        adapMainhis.Fill(toReverse);
                        //return toReturn;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                    finally
                    {
                        connBITDemo1.Close();
                        comMainhis.Dispose();
                        adapMainhis.Dispose();
                    }
                    //continue;
                }

                //sql = "Delete From "+ row["TABLE_NAME"].ToString().Trim();   //     HspMst                

                bool bolarrayNoDelete = Array.Exists(stringarrayNoDelete, E => E == row["TABLE_NAME"].ToString());
                if (!bolarrayNoDelete)
                {
                    sql = "Truncate Table " + row["TABLE_NAME"].ToString().Trim();
                    connBITDemo.ExecuteNonQueryForConvert(sql, "bit_demo");
                }
                //continue;
                //bool bolarrayNoDelete = Array.Exists(stringarrayNoDelete, E => E == row["TABLE_NAME"].ToString());
                //if (!bolarrayNoDelete)
                //{
                //    continue;
                //}

                bool bolarrayInsert = Array.Exists(stringarrayInsert, E => E == row["TABLE_NAME"].ToString().ToLower());
                if (!bolarrayInsert)
                {
                    continue;
                }

                sql = "Truncate Table " + row["TABLE_NAME"].ToString().Trim();
                connBITDemo.ExecuteNonQueryForConvert(sql, "bit_demo");

                DataTable dt1 = new DataTable();
                sql = "Select * From "+ row["TABLE_NAME"].ToString().Trim();
                dt1 = connBIT.selectDataForConvert(sql, "bit");
                col = "";
                lb.Text = row["TABLE_NAME"].ToString().Trim()+" " + dt1.Rows.Count;
                aa.Refresh();
                foreach (DataColumn column in dt1.Columns)
                {
                    col += column.ColumnName + ",";
                }
                col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";
                sql1 = "Insert Into "+ row["TABLE_NAME"].ToString().Trim() + "(" + col + ") ";
                if (row["TABLE_NAME"].ToString().Trim().ToLower().Equals(reverse.ToLower()))
                {
                    foreach (DataRow row1 in toReverse.Rows)
                    {
                        dat.Clear();
                        dat1.Clear();
                        foreach (DataColumn dc in toReverse.Columns)
                        {
                            //dat += "'"+row[dc].ToString().Trim()+"',";
                            if (dc.DataType.ToString().Equals("System.DateTime"))
                            {
                                DateTime dt2 = new DateTime();
                                if (!row1[dc].ToString().Trim().Equals(""))
                                {
                                    dt2 = DateTime.Parse(row1[dc].ToString().Trim());
                                    String year = dt2.Year.ToString();
                                    String month = dt2.Month.ToString("00");
                                    String date = dt2.Day.ToString("00");
                                    String time = dt2.Hour.ToString("00") + ":" + dt2.Minute.ToString("00") + ":" + dt2.Second.ToString("00");
                                    String date1 = year + "-" + month + "-" + date + " " + time;
                                    dat.Append("'").Append(date1).Append("'").Append(",");
                                }
                                else
                                {
                                    dat.Append("'").Append("1900-01-10 0:00:00").Append("'").Append(",");
                                }
                            }
                            else if (dc.DataType.ToString().Equals("System.binary"))
                            {

                            }
                            else
                            {
                                dat.Append("'").Append(row1[dc].ToString().Trim().Replace("'", "''")).Append("'").Append(",");
                            }
                        }
                        dat1.Append(dat.ToString(0, dat.Length - 1));
                        sql = sql1 + " Values(" + dat1.ToString() + ");";
                        try
                        {
                            if (bolSetOn)
                            {
                                connBITDemo.ExecuteNonQueryForConvert(sqlOn + sql + sqlOff, "bit_demo");
                            }
                            else
                            {
                                connBITDemo.ExecuteNonQueryForConvert(sql, "bit_demo");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                        }
                    }
                }
                else
                {
                    foreach (DataRow row1 in dt1.Rows)
                    {
                        dat.Clear();
                        dat1.Clear();
                        foreach (DataColumn dc in dt1.Columns)
                        {
                            //dat += "'"+row[dc].ToString().Trim()+"',";
                            if (dc.DataType.ToString().Equals("System.DateTime"))
                            {
                                DateTime dt2 = new DateTime();
                                if (!row1[dc].ToString().Trim().Equals(""))
                                {
                                    dt2 = DateTime.Parse(row1[dc].ToString().Trim());
                                    String year = dt2.Year.ToString();
                                    String month = dt2.Month.ToString("00");
                                    String date = dt2.Day.ToString("00");
                                    String time = dt2.Hour.ToString("00") + ":" + dt2.Minute.ToString("00") + ":" + dt2.Second.ToString("00");
                                    String date1 = year + "-" + month + "-" + date + " " + time;
                                    dat.Append("'").Append(date1).Append("'").Append(",");
                                }
                                else
                                {
                                    dat.Append("'").Append("1900-01-10 0:00:00").Append("'").Append(",");
                                }

                            }
                            else if (dc.DataType.ToString().Equals("System.binary"))
                            {

                            }
                            else
                            {
                                dat.Append("'").Append(row1[dc].ToString().Trim().Replace("'", "''")).Append("'").Append(",");
                            }
                        }
                        dat1.Append(dat.ToString(0, dat.Length - 1));
                        sql = sql1 + " Values(" + dat1.ToString() + ");";
                        try
                        {
                            if (bolSetOn)
                            {
                                connBITDemo.ExecuteNonQueryForConvert(sqlOn + sql + sqlOff, "bit_demo");
                            }
                            else
                            {
                                connBITDemo.ExecuteNonQueryForConvert(sql, "bit_demo");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                        }
                    }
                }
                
                if (bolSetOn)
                {
                    sql = "SET IDENTITY_INSERT dbo." + row["TABLE_NAME"].ToString() + " OFF;";
                }
            }
        }
    }
}
