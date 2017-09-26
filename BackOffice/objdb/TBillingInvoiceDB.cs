using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TBillingInvoiceDB
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
    }
}
