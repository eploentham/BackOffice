using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.objdb
{
    public class DoctorDB
    {
        ConnectDB conn;
        Doctor dtr;
        public DoctorDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            dtr = new Doctor();
            dtr.Active = "active";
            dtr.Address = "address";
            dtr.AppointmnetCnt = "appointment_cnt";
            dtr.BankNO = "bank_no";
            dtr.Code = "code";
            dtr.DtrCatCode = "dtr_cat_code";
            dtr.DtrCode = "dtr_code";
            dtr.DtrFnameT = "dtr_fname_t";
            dtr.DtrFnameE = "dtr_fname_e";
            dtr.DtrMedicalField = "dtr_medical_field";
            dtr.DtrSnameE = "dtr_sname_e";
            dtr.DtrSnameT = "dtr_sname_t";
            dtr.DtrTitCode = "dtr_tit_code";
            dtr.DtrTypCode = "dtr_typ_code";
            dtr.Phone = "phone";
            dtr.Remark = "remark";
            dtr.SalaryMin = "salary_min";
            dtr.Sort1 = "sort1";
            dtr.TaxID = "tax_id";

            dtr.table = "df_b_doctor";
            dtr.pkField = "code";
        }
        private Doctor setData(Doctor p, DataTable dt)
        {
            //p = new Doctor();
            p.Active = dt.Rows[0][dtr.Active].ToString();
            p.Address = dt.Rows[0][dtr.Address].ToString();
            p.AppointmnetCnt = dt.Rows[0][dtr.AppointmnetCnt].ToString();
            p.BankNO = dt.Rows[0][dtr.BankNO].ToString();
            p.Code = dt.Rows[0][dtr.Code].ToString();
            p.DtrCatCode = dt.Rows[0][dtr.DtrCatCode].ToString();
            p.DtrCode = dt.Rows[0][dtr.DtrCode].ToString();
            p.DtrFnameE = dt.Rows[0][dtr.DtrFnameE].ToString();
            p.DtrFnameT = dt.Rows[0][dtr.DtrFnameT].ToString();
            p.DtrMedicalField = dt.Rows[0][dtr.DtrMedicalField].ToString();
            p.DtrSnameT = dt.Rows[0][dtr.DtrSnameT].ToString();
            p.DtrSnameE = dt.Rows[0][dtr.DtrSnameE].ToString();
            p.DtrTitCode = dt.Rows[0][dtr.DtrTitCode].ToString();
            p.DtrTypCode = dt.Rows[0][dtr.DtrTypCode].ToString();
            p.Phone = dt.Rows[0][dtr.Phone].ToString();
            p.Remark = dt.Rows[0][dtr.Remark].ToString();
            p.SalaryMin = dt.Rows[0][dtr.SalaryMin].ToString();
            p.Sort1 = dt.Rows[0][dtr.Sort1].ToString();
            p.TaxID = dt.Rows[0][dtr.TaxID].ToString();

            return p;
        }
        public Doctor selectByPk(String Code)
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select dtr.* " +
                "From " + dtr.table + " dtr " +
                "Where dtr." + dtr.pkField + "='" + Code + "'";

            dt = conn.selectData(sql, "orc_ba");
            item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return item;
        }
        public DataTable selectAll()
        {
            Doctor item;
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dtr.table + " Where active = '1'";

            dt = conn.selectData(sql, "orc_ba");
            //item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return dt;
        }
        private String insert(Doctor p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.Code == "")
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + dtr.table + "(" + dtr.pkField + "," + dtr.Active + "," + dtr.Address + "," +
                    dtr.AppointmnetCnt + "," + dtr.BankNO + "," + dtr.DtrCatCode + "," +
                    dtr.DtrCode + "," + dtr.DtrFnameT + "," + dtr.DtrMedicalField + "," +
                    dtr.DtrSnameT + "," + dtr.DtrTitCode + "," + dtr.DtrTypCode + "," +
                    dtr.Phone + "," + dtr.Remark + "," + dtr.SalaryMin + "," +
                    dtr.Sort1 + "," + dtr.TaxID + "," + dtr.DtrFnameE + "," + dtr.DtrSnameE + ") " +
                    "Values('" + p.Code + "','" + p.Active + "','" + p.Address + "','" +
                    p.AppointmnetCnt + "','" + p.BankNO + "','" + p.DtrCatCode + "','" +
                    p.DtrCode + "','" + p.DtrFnameT + "','" + p.DtrMedicalField + "','" +
                    p.DtrSnameT + "','" + p.DtrTitCode + "','" + p.DtrTypCode + "','" +
                    p.Phone + "','" + p.Remark + "','" + p.SalaryMin + "','" +
                    p.Sort1 + "','" + p.TaxID + "','" + p.DtrFnameE + "','" + p.DtrSnameE + "') ";
                chk = conn.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
                chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }

            return chk;
        }
        public String update(Doctor p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + dtr.table + " Set " + dtr.Address + "='" + p.Address + "'," +
                    dtr.AppointmnetCnt + "='" + p.AppointmnetCnt + "'," +
                    dtr.BankNO + "='" + p.BankNO + "'," +
                    dtr.DtrCatCode + "='" + p.DtrCatCode + "'," +
                    dtr.DtrCode + "='" + p.DtrCode + "'," +
                    dtr.DtrFnameT + "='" + p.DtrFnameT + "'," +
                    dtr.DtrMedicalField + "='" + p.DtrMedicalField + "'," +
                    dtr.DtrSnameT + "='" + p.DtrSnameT + "'," +
                    dtr.DtrTitCode + "='" + p.DtrTitCode + "'," +
                    dtr.DtrTypCode + "='" + p.DtrTypCode + "'," +
                    dtr.Phone + "='" + p.Phone + "', " +
                    dtr.Remark + "='" + p.Remark + "', " +
                    dtr.SalaryMin + "='" + p.SalaryMin + "', " +
                    dtr.Sort1 + "='" + p.Sort1 + "', " +
                    dtr.TaxID + "='" + p.TaxID + "', " +
                    dtr.DtrFnameE + "='" + p.DtrFnameE + "', " +
                    dtr.DtrSnameE + "='" + p.DtrSnameE + "' " +

                    "Where " + dtr.pkField + "='" + p.Code + "'";
                chk = conn.ExecuteNonQuery(sql, "orc_ba");
                //chk = p.RowNumber;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update Doctor");
            }
            return chk;
        }
        public String insertDoctor(Doctor p)
        {
            Doctor item = new Doctor();
            String chk = "";
            item = selectByPk(p.Code);
            if (item.Code == "")
            {
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String insertFormImport(Doctor p)
        {
            Doctor item = new Doctor();
            String chk = "";
            item = selectByPk(p.Code);
            if (item.Code == "")
            {
                chk = insert(p);
            }
            else
            {
                //chk = update(p);
            }
            return chk;
        }
        public String VoidDoctor(String Code)
        {
            String sql = "", chk = "";
            sql = "Update " + dtr.table + " Set " + dtr.Active + " = '3' " +
                "Where " + dtr.pkField + "='" + Code + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql, "orc_ba");
            }
            catch (Exception ex)
            {
            }

            return chk;
        }
    }
}
