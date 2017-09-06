using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class DoctorRateDB
    {
        ConnectDB conn;
        public DoctorRate dtrR;
        public DoctorRateDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            dtrR = new DoctorRate();
            dtrR.Active = "active";
            dtrR.Desc = "description";
            dtrR.DtrCode = "dtr_code";
            dtrR.InsCode = "ins_code";
            dtrR.InsCodeName = "ins_code_name";
            dtrR.ItmAstCod = "itm_ast_cod";
            dtrR.ItmCod = "itm_cod";
            dtrR.ItmKorNam = "itm_kor_nam";
            dtrR.Rate = "rate";
            dtrR.RateCode = "rate_code";
            dtrR.RateId = "rate_id";
            dtrR.RateTyp = "rate_typ";
            dtrR.Remark = "remark";
            dtrR.TypTime = "typ_time";
            dtrR.row1 = "row1";

            dtrR.table = "df_b_doctor_rate";
            dtrR.pkField = "rate_id";
        }
        private void setData(DoctorRate p, DataTable dt)
        {
            //p = new Doctor();
            p.Active = dt.Rows[0][dtrR.Active].ToString();
            p.Desc = dt.Rows[0][dtrR.Desc].ToString();
            p.Desc = dt.Rows[0][dtrR.Desc].ToString();
            p.DtrCode = dt.Rows[0][dtrR.DtrCode].ToString();
            p.InsCode = dt.Rows[0][dtrR.InsCode].ToString();
            p.InsCodeName = dt.Rows[0][dtrR.InsCodeName].ToString();
            p.ItmAstCod = dt.Rows[0][dtrR.ItmAstCod].ToString();
            p.ItmCod = dt.Rows[0][dtrR.ItmCod].ToString();
            p.ItmKorNam = dt.Rows[0][dtrR.ItmKorNam].ToString();
            p.Rate = dt.Rows[0][dtrR.Rate].ToString();
            p.RateCode = dt.Rows[0][dtrR.RateCode].ToString();
            p.RateId = dt.Rows[0][dtrR.RateId].ToString();
            p.RateTyp = dt.Rows[0][dtrR.RateTyp].ToString();
            p.Remark = dt.Rows[0][dtrR.Remark].ToString();
            p.TypTime = dt.Rows[0][dtrR.TypTime].ToString();
            p.row1 = dt.Rows[0][dtrR.row1].ToString();
            //return p;
        }
        public DataTable selectByDoctor(String dtrCode)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dtrR.table + " Where active = '1' and "+dtrR.DtrCode+" = '"+dtrCode+"' Order By row1";

            dt = conn.selectData(sql, "orc_ba");
            //item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return dt;
        }
        public DoctorRate selectRateByDoctorItmCodeFullTime(String dtrCode, String itmcod, String itmastcod)
        {
            DoctorRate item = new DoctorRate();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dtrR.table + " Where active = '1' and " + dtrR.DtrCode + " = '" + dtrCode + "' and "+dtrR.ItmCod+" ='"+itmcod+"' and "+dtrR.ItmAstCod+" = '"+itmastcod+"'";

            dt = conn.selectData(sql, "orc_ba");
            if (dt.Rows.Count > 0)
            {
                setData(item, dt);
            }

            return item;
        }
        public String calDf(String dtrCode, String itmcod, String itmastcod, Decimal df)
        {
            //String df = "";
            Decimal df1 = 0;
            DoctorRate item = new DoctorRate();
            item = selectRateByDoctorItmCodeFullTime(dtrCode, itmcod, itmastcod);
            if (item.RateTyp.Equals("%"))
            {
                df1 = df * (Decimal.Parse(item.Rate) / 100);
            }
            return df1.ToString();
        }
        private String insert(DoctorRate p)
        {
            String sql = "", chk = "";
            try
            {
                //if (p.Code == "")
                //{
                //    return "";
                //}
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + dtrR.table + "(" + dtrR.Active + "," + dtrR.Desc + "," +
                    dtrR.DtrCode + "," + dtrR.InsCode + "," + dtrR.InsCodeName + "," +
                    dtrR.ItmAstCod + "," + dtrR.ItmCod + "," + dtrR.ItmKorNam + "," +
                    dtrR.Rate + "," + dtrR.RateCode + "," + dtrR.RateTyp + "," +
                    dtrR.Remark + "," + dtrR.row1 + "," + dtrR.TypTime + ") " +
                    "Values('" + p.Active + "','" + p.Desc + "','" +
                    p.DtrCode + "','" + p.InsCode + "','" + p.InsCodeName + "','" +
                    p.ItmAstCod + "','" + p.ItmCod + "','" + p.ItmKorNam + "','" +
                    p.Rate + "','" + p.RateCode + "','" + p.RateTyp + "','" +
                    p.Remark + "','" + p.row1 + "','" + p.TypTime + "') ";
                chk = conn.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }

            return chk;
        }
        public String update(DoctorRate p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + dtrR.table + " Set " + dtrR.DtrCode + "='" + p.DtrCode + "'," +
                    dtrR.InsCode + "='" + p.InsCode + "'," +
                    dtrR.InsCodeName + "='" + p.InsCodeName + "'," +
                    dtrR.ItmAstCod + "='" + p.ItmAstCod + "'," +
                    dtrR.ItmCod + "='" + p.ItmCod + "'," +
                    dtrR.ItmKorNam + "='" + p.ItmKorNam + "'," +
                    dtrR.Rate + "='" + p.Rate + "'," +
                    dtrR.RateCode + "='" + p.RateCode + "'," +
                    dtrR.RateTyp + "='" + p.RateTyp + "'," +
                    dtrR.Remark + "='" + p.Remark + "'," +
                    dtrR.row1 + "='" + p.row1 + "', " +
                    dtrR.TypTime + "='" + p.TypTime + "' " +                                     

                    "Where " + dtrR.pkField + "='" + p.RateId + "'";
                chk = conn.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update Doctor");
            }
            return chk;
        }
        public String insertDoctorRate(DoctorRate p)
        {
            Doctor item = new Doctor();
            String chk = "";
            //item = selectByPk(p.Code);
            if (p.RateId == "0")
            {
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
    }
}
