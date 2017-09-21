using BackOffice;
using BackOffice.objdb;
using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class ImportBITDB
    {
        private ConnectDB conn, connBIT, connBA, connBITDemo;
        private ControlMaster cm;
        public ImportBITDB()
        {
            conn = new ConnectDB("orc_bit");
            connBIT = new ConnectDB("bit");
            connBA = new ConnectDB("orc_ba");
            cm = new ControlMaster(conn, connBIT);
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
        public void DeleteDatabase(String dbName)
        {
            String sql = "", col = "", sql1 = "";
            StringBuilder dat = new StringBuilder();
            StringBuilder dat1 = new StringBuilder();
            DataTable dt = new DataTable();

            connBITDemo = new ConnectDB("bithis");
            sql = "SELECT TABLE_NAME "+
                "FROM INFORMATION_SCHEMA.TABLES "+
                "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '"+ dbName + "' "+
                "Order by TABLE_NAME";
            dt = connBITDemo.selectData(sql, "bit_demo");
            
            foreach (DataRow row in dt.Rows)
            {

                sql = "Delete From "+ row["TABLE_NAME"].ToString().Trim();
                connBITDemo.ExecuteNonQuery(sql, "bit_demo");

                DataTable dt1 = new DataTable();
                sql = "Select * From "+ row["TABLE_NAME"].ToString().Trim();
                dt1 = connBIT.selectData(sql, "bit");
                foreach (DataColumn column in dt1.Columns)
                {
                    col += column.ColumnName + ",";
                }
                col = col.Length > 0 ? col.Substring(0, col.Length - 1) : "";
                sql1 = "Insert Into "+ row["TABLE_NAME"].ToString().Trim() + "(" + col + ") ";

                foreach (DataRow row1 in dt1.Rows)
                {
                    dat.Clear();
                    dat1.Clear();
                    foreach (DataColumn dc in dt1.Columns)
                    {
                        //dat += "'"+row[dc].ToString().Trim()+"',";
                        dat.Append("'").Append(row[dc].ToString().Trim()).Append("'").Append(",");
                    }
                    dat1.Append(dat.ToString(0, dat.Length - 1));
                    sql = sql1 + " Values(" + dat1.ToString() + ")";
                    conn.ExecuteNonQuery(sql, "bit_demo");
                }
            }
        }
    }
}
