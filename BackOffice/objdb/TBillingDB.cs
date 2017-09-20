using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingDB
    {
        TBilling tb;
        ConnectDB conn;
        public TBillingDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tb = new TBilling();
            tb.Active = "active";
            tb.t_patient_id = "t_patient_id";
            tb.t_visit_id = "t_visit_id";
            tb.billing_billing_number = "billing_billing_number";
            tb.billing_billing_date_time = "billing_billing_date_time";
            tb.billing_financial_date = "billing_financial_date";
            tb.billing_staff_cancle = "billing_staff_cancle";
            tb.billing_cancle_date_time = "billing_cancle_date_time";
            tb.billing_staff_record = "billing_staff_record";
            tb.t_billing_id = "t_billing_id";
            tb.billing_patient_share = "billing_patient_share";
            tb.billing_payer_share = "billing_payer_share";
            tb.billing_total = "billing_total";
            tb.billing_paid = "billing_paid";
            tb.billing_remain = "billing_remain";
            tb.billing_deduct = "billing_deduct";
            tb.billing_payback = "billing_payback";

            tb.pkField = "t_billing_id";
            tb.table = "t_billing";
        }
        private TBilling setData(TBilling p, DataTable dt)
        {
            p.Active = dt.Rows[0][tb.Active].ToString();
            p.billing_billing_date_time = dt.Rows[0][tb.billing_billing_date_time].ToString();
            p.billing_billing_number = dt.Rows[0][tb.billing_billing_number].ToString();
            p.billing_cancle_date_time = dt.Rows[0][tb.billing_cancle_date_time].ToString();
            p.billing_deduct = dt.Rows[0][tb.billing_deduct].ToString();
            p.billing_financial_date = dt.Rows[0][tb.billing_financial_date].ToString();
            p.billing_paid = dt.Rows[0][tb.billing_paid].ToString();
            p.billing_patient_share = dt.Rows[0][tb.billing_patient_share].ToString();
            p.billing_payback = dt.Rows[0][tb.billing_payback].ToString();
            p.billing_payer_share = dt.Rows[0][tb.billing_payer_share].ToString();
            p.billing_remain = dt.Rows[0][tb.billing_remain].ToString();
            p.billing_staff_cancle = dt.Rows[0][tb.billing_staff_cancle].ToString();
            p.billing_staff_record = dt.Rows[0][tb.billing_staff_record].ToString();
            p.billing_total = dt.Rows[0][tb.billing_total].ToString();
            p.t_billing_id = dt.Rows[0][tb.t_billing_id].ToString();
            p.t_patient_id = dt.Rows[0][tb.t_patient_id].ToString();
            p.t_visit_id = dt.Rows[0][tb.t_visit_id].ToString();

            return p;
        }
        private String insert(TBilling p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.t_visit_id.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + tb.table + "(" + tb.Active + "," + tb.billing_billing_date_time + "," + tb.billing_billing_number + "," +
                    tb.billing_cancle_date_time + "," + tb.billing_deduct + "," + tb.billing_financial_date + "," +
                    tb.billing_paid + "," + tb.billing_patient_share + "," + tb.billing_payback + "," +
                    tb.billing_payer_share + "," + tb.billing_remain + "," + tb.billing_staff_cancle + "," +
                    tb.billing_staff_record + "," + tb.billing_total + "," + tb.t_billing_id + "," +
                    tb.t_patient_id + "," + tb.t_visit_id + ") " +
                    "Values('" + p.Active + "','" + p.billing_billing_date_time + "','" + p.billing_billing_number + "','" +
                    p.billing_cancle_date_time + "','" + p.billing_deduct + "','" + p.billing_financial_date + "','" +
                    p.billing_paid + "','" + p.billing_patient_share + "','" + p.billing_payback + "','" +
                    p.billing_payer_share + "','" + p.billing_remain + "','" + p.billing_staff_cancle + "','" +
                    p.billing_staff_record + "','" + p.billing_total + "','" + p.t_billing_id + "','" +
                    p.t_patient_id + "','" + p.t_visit_id + "') ";
                chk = conn.ExecuteNonQueryAutoIncrement(sql, "orc_ma");
                //chk = p.RowNumber;
                //chk = p.Code;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "insert Doctor");
            }
            return chk;
        }
    }
}
