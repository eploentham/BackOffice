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
            dtr.DtrFname = "dtr_fname";
            dtr.DtrMedicalField = "dtr_medical_field";
            dtr.DtrSname = "dtr_sname";
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
            p.DtrFname = dt.Rows[0][dtr.DtrFname].ToString();
            p.DtrMedicalField = dt.Rows[0][dtr.DtrMedicalField].ToString();
            p.DtrSname = dt.Rows[0][dtr.DtrSname].ToString();
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

            sql = "Select * From " + dtr.table + " Where " + dtr.pkField + "='" + Code + "'";

            dt = conn.selectData(sql, "orc_ba");
            item = dt.Rows.Count > 0 ? setData(new Doctor(), dt) : new Doctor();

            return item;
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
                    dtr.DtrCode + "," + dtr.DtrFname + "," + dtr.DtrMedicalField + "," +
                    dtr.DtrSname + "," + dtr.DtrTitCode + "," + dtr.DtrTypCode + "," +
                    dtr.Phone + "," + dtr.Remark + "," + dtr.SalaryMin + "," +
                    dtr.Sort1 + "," + dtr.TaxID + ") " +
                    "Values('" + p.Code + "','" + p.Active + "','" + p.Address + "','" +
                    p.AppointmnetCnt + "','" + p.BankNO + "','" + p.DtrCatCode + "','" +
                    p.DtrCode + "','" + p.DtrFname + "','" + p.DtrMedicalField + "','" +
                    p.DtrSname + "','" + p.DtrTitCode + "','" + p.DtrTypCode + "','" +
                    p.Phone + "','" + p.Remark + "','" + p.SalaryMin + "','" +
                    p.Sort1 + "','" + p.TaxID + "') ";
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
                    dtr.DtrFname + "='" + p.DtrFname + "'," +
                    dtr.DtrMedicalField + "='" + p.DtrMedicalField + "'," +
                    dtr.DtrSname + "='" + p.DtrSname + "'," +
                    dtr.DtrTitCode + "='" + p.DtrTitCode + "'," +
                    dtr.DtrTypCode + "='" + p.DtrTypCode + "'," +
                    dtr.Phone + "='" + p.Phone + "', " +
                    dtr.Remark + "='" + p.Remark + "', " +
                    dtr.SalaryMin + "='" + p.SalaryMin + "', " +
                    dtr.Sort1 + "='" + p.Sort1 + "', " +
                    dtr.TaxID + "='" + p.TaxID + "' " +

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
