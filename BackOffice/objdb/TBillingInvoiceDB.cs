using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public class TBillingInvoiceDB
    {
        TBillingInvoice tbi;
        ConnectDB conn;
        public TBillingInvoiceDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbi = new TBillingInvoice();
            tbi.billing_invoice_active = "billing_invoice_active";
            tbi.billing_invoice_complete = "billing_invoice_complete";
            tbi.billing_invoice_deposit = "billing_invoice_deposit";
            tbi.billing_invoice_number = "billing_invoice_number";
            tbi.billing_invoice_patient_share = "billing_invoice_patient_share";
            tbi.billing_invoice_patient_share_ceil = "billing_invoice_patient_share_ceil";
            tbi.billing_invoice_payer_share = "billing_invoice_payer_share";
            tbi.billing_invoice_payer_share_ceil = "billing_invoice_payer_share_ceil";
            tbi.billing_invoice_quantity = "billing_invoice_quantity";
            tbi.billing_invoice_staff_record = "billing_invoice_staff_record";
            tbi.billing_invoice_total = "billing_invoice_total";
            tbi.b_company_original_affiliation_id = "b_company_original_affiliation_id";
            tbi.b_contract_id = "b_contract_id";
            tbi.close_day_id = "close_day_id";
            tbi.company_original_affiliation = "company_original_affiliation";
            tbi.company_responsibility = "company_responsibility";
            tbi.discharge_date_time = "discharge_date_time";
            tbi.member_card_id = "member_card_id";
            tbi.primary_symptom = "primary_symptom";
            tbi.receipt_number = "receipt_number";
            tbi.status_export = "status_export";
            tbi.symtom = "symtom";
            tbi.t_billing_id = "t_billing_id";
            tbi.t_billing_invoice_date_time = "t_billing_invoice_date_time";
            tbi.t_billing_invoice_id = "t_billing_invoice_id";
            tbi.t_patient_id = "t_patient_id";
            tbi.t_payment_id = "t_payment_id";
            tbi.t_visit_id = "t_visit_id";

            tbi.table = "t_billing_invoice";
            tbi.pkField = "t_billing_invoice_id";
        }
        private TBillingInvoice setData(TBillingInvoice p, DataTable dt)
        {
            p.billing_invoice_active = dt.Rows[0][tbi.billing_invoice_active].ToString();
            p.billing_invoice_complete = dt.Rows[0][tbi.billing_invoice_complete].ToString();
            p.billing_invoice_deposit = dt.Rows[0][tbi.billing_invoice_deposit].ToString();
            p.billing_invoice_number = dt.Rows[0][tbi.billing_invoice_number].ToString();
            p.billing_invoice_patient_share = dt.Rows[0][tbi.billing_invoice_patient_share].ToString();
            p.billing_invoice_patient_share_ceil = dt.Rows[0][tbi.billing_invoice_patient_share_ceil].ToString();
            p.billing_invoice_payer_share = dt.Rows[0][tbi.billing_invoice_payer_share].ToString();
            p.billing_invoice_payer_share_ceil = dt.Rows[0][tbi.billing_invoice_payer_share_ceil].ToString();
            p.billing_invoice_quantity = dt.Rows[0][tbi.billing_invoice_quantity].ToString();
            p.billing_invoice_staff_record = dt.Rows[0][tbi.billing_invoice_staff_record].ToString();
            p.billing_invoice_total = dt.Rows[0][tbi.billing_invoice_total].ToString();
            p.b_company_original_affiliation_id = dt.Rows[0][tbi.b_company_original_affiliation_id].ToString();
            p.b_contract_id = dt.Rows[0][tbi.b_contract_id].ToString();
            p.close_day_id = dt.Rows[0][tbi.close_day_id].ToString();
            p.company_original_affiliation = dt.Rows[0][tbi.company_original_affiliation].ToString();
            p.company_responsibility = dt.Rows[0][tbi.company_responsibility].ToString();
            p.discharge_date_time = dt.Rows[0][tbi.discharge_date_time].ToString();
            p.member_card_id = dt.Rows[0][tbi.member_card_id].ToString();
            p.primary_symptom = dt.Rows[0][tbi.primary_symptom].ToString();
            p.receipt_number = dt.Rows[0][tbi.receipt_number].ToString();
            p.status_export = dt.Rows[0][tbi.status_export].ToString();
            p.symtom = dt.Rows[0][tbi.symtom].ToString();
            p.t_billing_id = dt.Rows[0][tbi.t_billing_id].ToString();
            p.t_billing_invoice_date_time = dt.Rows[0][tbi.t_billing_invoice_date_time].ToString();
            p.t_billing_invoice_id = dt.Rows[0][tbi.t_billing_invoice_id].ToString();
            p.t_patient_id = dt.Rows[0][tbi.t_patient_id].ToString();
            p.t_payment_id = dt.Rows[0][tbi.t_payment_id].ToString();
            p.t_visit_id = dt.Rows[0][tbi.t_visit_id].ToString();

            return p;
        }
        public String insert(TBillingInvoice p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.billing_invoice_number.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.billing_invoice_active = "1";
                sql = "Insert Into " + tbi.table + "(" + tbi.billing_invoice_active + "," + tbi.billing_invoice_complete + "," + tbi.billing_invoice_deposit + "," +
                    tbi.billing_invoice_number + "," + tbi.billing_invoice_patient_share + "," + tbi.billing_invoice_patient_share_ceil + "," +
                    tbi.billing_invoice_payer_share + "," + tbi.billing_invoice_payer_share_ceil + "," + tbi.billing_invoice_quantity + "," +
                    tbi.billing_invoice_staff_record + "," + tbi.billing_invoice_total + "," +
                    tbi.b_company_original_affiliation_id + "," + tbi.b_contract_id + "," + tbi.close_day_id + "," +
                    tbi.company_original_affiliation + "," + tbi.company_responsibility + "," + tbi.discharge_date_time + "," +
                    tbi.member_card_id + "," + tbi.primary_symptom + "," + tbi.receipt_number + "," +
                    tbi.status_export + "," + tbi.symtom + "," + tbi.t_billing_id + "," +
                    tbi.t_billing_invoice_date_time + ","  + tbi.t_patient_id + "," +
                    tbi.t_payment_id + "," + tbi.t_visit_id + ") " +
                    "Values('" + p.billing_invoice_active + "','" + p.billing_invoice_complete + "','" + p.billing_invoice_deposit + "','" +
                    p.billing_invoice_number + "'," + p.billing_invoice_patient_share + ",'" + p.billing_invoice_patient_share_ceil + "'," +
                    p.billing_invoice_payer_share + ",'" + p.billing_invoice_payer_share_ceil + "','" + p.billing_invoice_quantity + "','" +
                    p.billing_invoice_staff_record + "'," + p.billing_invoice_total + ",'" +
                    p.b_company_original_affiliation_id + "','" + p.b_contract_id + "','" + p.close_day_id + "','" +
                    p.company_original_affiliation + "','" + p.company_responsibility + "','" + p.discharge_date_time + "','" +
                    p.member_card_id + "','" + p.primary_symptom + "','" + p.receipt_number + "','" +
                    p.status_export + "','" + p.symtom + "','" + p.t_billing_id + "','" +
                    p.t_billing_invoice_date_time + "','" + p.t_patient_id + "','" +
                    p.t_payment_id + "','" + p.t_visit_id + "') ";
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
