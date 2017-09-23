using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class TBillingInvoice:Persistent
    {
        public String t_patient_id { get; set; }
        public String t_visit_id { get; set; }
        public String billing_invoice_number { get; set; }
        public String t_billing_invoice_date_time { get; set; }
        public String billing_invoice_deposit { get; set; }
        public String t_payment_id { get; set; }
        public String billing_invoice_active { get; set; }
        public String billing_invoice_quantity { get; set; }
        public String t_billing_id { get; set; }
        public String billing_invoice_complete { get; set; }
        public String billing_invoice_staff_record { get; set; }
        public String billing_invoice_patient_share_ceil { get; set; }
        public String billing_invoice_payer_share_ceil { get; set; }
        public String close_day_id { get; set; }
        public String status_export { get; set; }
        public String receipt_number { get; set; }
        public String symtom { get; set; }
        public String b_contract_id { get; set; }
        public String member_card_id { get; set; }
        public String company_responsibility { get; set; }
        public String b_company_original_affiliation_id { get; set; }
        public String discharge_date_time { get; set; }
        public String company_original_affiliation { get; set; }
        public String primary_symptom { get; set; }
        public String t_billing_invoice_id { get; set; }
        public String billing_invoice_patient_share { get; set; }
        public String billing_invoice_payer_share { get; set; }
        public String billing_invoice_total { get; set; }
    }
}
