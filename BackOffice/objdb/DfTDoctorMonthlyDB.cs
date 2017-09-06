using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.objdb
{
    public class DfTDoctorMonthlyDB
    {
        ConnectDB connORCBA, connORCBIT;
        public DoctorRate dtrR;
        public DfTDoctor dfDtr;
        public DfTDoctorDetail dfDtrD;
        public DfTDoctorMonthly dfDtrM;
        public DfTDoctorMonthlyDB(ConnectDB orc_bit, ConnectDB connorc_ba)
        {
            connORCBIT = orc_bit;
            connORCBA = connorc_ba;
            initConfig();
        }
        private void initConfig()
        {
            dtrR = new DoctorRate();
            dfDtrD = new DfTDoctorDetail();
            dfDtrM = new DfTDoctorMonthly();
            dfDtrM.Active = "active";
            dfDtrM.DateMonthly = "date_monthly";
            dfDtrM.Df = "df";
            dfDtrM.DtrCode = "dtr_code";
            dfDtrM.DtrName = "dtr_name";
            dfDtrM.Id = "mon_id";
            dfDtrM.MonthId = "month_id";
            dfDtrM.Onhand = "onhand";
            dfDtrM.Owe = "owe";
            dfDtrM.Pay = "pay";
            dfDtrM.YearId = "year_id";

            dfDtrM.table = "df_t_doctor_monthly";
            dfDtrM.pkField = "mon_id";
        }
        public DataTable selectByYearMonth(String monthId, String yearid)
        {
            String sql = "";
            DataTable dt = new DataTable();
            int cnt = 0;
            sql = "Select * From " + dfDtrM.table + " Where active = '1'  and "+ dfDtrM .MonthId+ " = '" + monthId + "' and "+ dfDtrM .YearId+ " = '"+ yearid + "' Order By "+dfDtrM.pkField;

            dt = connORCBA.selectData(sql, "orc_ba");
            
            return dt;
        }
        public String insert(DfTDoctorMonthly p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.DtrCode == "")
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + dfDtrM.table + "(" + dfDtrM.Active + "," + dfDtrM.DateMonthly + "," +
                    dfDtrM.Df + "," + dfDtrM.DtrCode + "," + dfDtrM.DtrName + "," +
                    dfDtrM.MonthId + "," + dfDtrM.Onhand + "," + dfDtrM.Owe + "," +
                    dfDtrM.Pay + "," + dfDtrM.YearId + ") " +
                    "Values('" + p.Active + "','" + p.DateMonthly + "','" +
                    p.Df + "','" + p.DtrCode + "','" + p.DtrName + "','" +
                    p.MonthId + "','" + p.Onhand + "','" + p.Owe + "','" +
                    p.Pay + "','" + p.YearId + ") ";
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
        public String update(DfTDoctorMonthly p)
        {
            String sql = "", chk = "";
            try
            {
                //p.dateModi = " CAST(year(GETDATE()) AS NVARCHAR)+'-'+ RIGHT('00' + CAST(month(GETDATE()) AS NVARCHAR), 2)+'-'+ RIGHT('00' + CAST(day(GETDATE()) AS NVARCHAR), 2)";
                sql = "Update " + dfDtrM.table + " Set " + dfDtrM.DateMonthly + "='" + p.DateMonthly + "'," +
                    dfDtrM.Df + "='" + p.Df + "'," +
                    dfDtrM.DtrCode + "='" + p.DtrCode + "'," +
                    dfDtrM.DtrName + "='" + p.DtrName + "'," +
                    dfDtrM.MonthId + "='" + p.MonthId + "'," +
                    dfDtrM.Onhand + "='" + p.Onhand + "'," +
                    dfDtrM.Owe + "='" + p.Owe + "'," +
                    dfDtrM.Pay + "='" + p.Pay + "'," +
                    dfDtrM.YearId + "='" + p.YearId + "' " +

                    "Where " + dfDtrD.pkField + "=" + p.Id;
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
