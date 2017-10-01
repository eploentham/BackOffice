using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public class TBillingReceiptDB
    {
        TBillingReceipt tbr;
        ConnectDB conn;
        public TBillingReceiptDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbr = new TBillingReceipt();
            tbr.billing_receipt_active = "billing_receipt_active";
            tbr.billing_receipt_date_time = "billing_receipt_date_time";
            tbr.billing_receipt_number = "billing_receipt_number";
            tbr.billing_receipt_paid = "billing_receipt_paid";
            tbr.billing_receipt_staff_record = "billing_receipt_staff_record";
            tbr.f_billing_receipt_model_id = "f_billing_receipt_model_id";
            tbr.receipt_number = "receipt_number";
            tbr.t_billing_id = "t_billing_id";
            tbr.t_billing_receipt_id = "t_billing_receipt_id";
            tbr.t_patient_id = "t_patient_id";
            tbr.t_visit_id = "t_visit_id";

            tbr.pkField = "t_billing_receipt_id";
            tbr.table = "t_billing_receipt";
        }
        private TBillingReceipt setData(TBillingReceipt p, DataTable dt)
        {
            p.billing_receipt_active = dt.Rows[0][tbr.billing_receipt_active].ToString();
            p.billing_receipt_date_time = dt.Rows[0][tbr.billing_receipt_date_time].ToString();
            p.billing_receipt_number = dt.Rows[0][tbr.billing_receipt_number].ToString();
            p.billing_receipt_paid = dt.Rows[0][tbr.billing_receipt_paid].ToString();
            p.billing_receipt_staff_record = dt.Rows[0][tbr.billing_receipt_staff_record].ToString();
            p.f_billing_receipt_model_id = dt.Rows[0][tbr.f_billing_receipt_model_id].ToString();
            p.receipt_number = dt.Rows[0][tbr.receipt_number].ToString();
            p.t_billing_id = dt.Rows[0][tbr.t_billing_id].ToString();
            p.t_billing_receipt_id = dt.Rows[0][tbr.t_billing_receipt_id].ToString();
            p.t_patient_id = dt.Rows[0][tbr.t_patient_id].ToString();
            p.t_visit_id = dt.Rows[0][tbr.t_visit_id].ToString();

            return p;
        }
        public String insert(TBillingReceipt p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.billing_receipt_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.billing_receipt_active = "1";
                sql = "Insert Into " + tbr.table + "(" + tbr.billing_receipt_active + "," + tbr.billing_receipt_date_time + "," + tbr.billing_receipt_number + "," +
                    tbr.billing_receipt_paid + "," + tbr.billing_receipt_staff_record + "," + tbr.f_billing_receipt_model_id + "," +
                    tbr.receipt_number + "," + tbr.t_billing_id + "," +
                    tbr.t_patient_id + "," + tbr.t_visit_id + ") " +
                    "Values('" + p.billing_receipt_active + "','" + p.billing_receipt_date_time + "','" + p.billing_receipt_number + "','" +
                    p.billing_receipt_paid + "','" + p.billing_receipt_staff_record + "','" + p.f_billing_receipt_model_id + "','" +
                    p.receipt_number + "','" + p.t_billing_id + "','" +
                    p.t_patient_id + "','" + p.t_visit_id + "') ";
                chk = conn.ExecuteNonQueryAutoIncrement(sql, "orc_ma");
                //chk = p.RowNumber;
                //chk = p.Code;
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert TBillingReceipt");
            }
            return chk;
        }

    }
}
