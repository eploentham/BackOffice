using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class BEmplyeeDB
    {
        BEmployee be;
        ConnectDB conn;

        public BEmplyeeDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            be = new BEmployee();
            be.employee_login = "employee_login";
            be.employee_password = "employee_password";
            be.employee_firstname = "employee_firstname";
            be.employee_lastname = "employee_lastname";
            be.employee_number = "employee_number";
            be.employee_last_login = "employee_last_login";
            be.employee_last_logout = "employee_last_logout";
            be.Active = "active";
            be.b_service_point_id = "b_service_point_id";
            be.f_employee_level_id = "f_employee_level_id";

            be.f_employee_rule_id = "f_employee_rule_id";
            be.f_employee_authentication_id = "f_employee_authentication_id";
            be.b_employee_default_tab = "b_employee_default_tab";
            be.employee_warning_dx = "employee_warning_dx";
            be.b_bank_id = "b_bank_id";
            be.b_bank_namet = "b_bank_namet";
            be.book_bank_id = "book_bank_id";
            be.book_bank_namet = "book_bank_namet";
            be.payment_status_id = "payment_status_id";
            be.payment_status_namet = "payment_status_namet";

            be.employee_firstnamee = "employee_firstnamee";
            be.employee_lastnamee = "employee_lastnamee";
            be.position_id = "position_id";
            be.position_namet = "position_namet";
            be.status_employee = "status_employee";
            be.send_service_id = "send_service_id";
            be.employee_lab_master = "employee_lab_master";
            be.employee_status_approve_control_item = "employee_status_approve_control_item";
            be.security_pin = "security_pin";
            be.limit_appointment = "limit_appointment";

            be.doctor_lying = "doctor_lying";
            be.status_funds = "status_funds";
            be.status_contact = "status_contact";
            be.status_admission = "status_admission";
            be.status_physical = "status_physical";
            be.f_doctor_branch_id = "f_doctor_branch_id";
            be.b_employee_id = "b_employee_id";
            be.charge = "charge";
        }
        private BEmployee setData(BEmployee p, DataTable dt)
        {
            p.Active = dt.Rows[0][be.Active].ToString();
            p.b_contract_id = dt.Rows[0][be.b_contract_id].ToString();
            p.contract_description = dt.Rows[0][be.contract_description].ToString();
            p.contract_method = dt.Rows[0][be.contract_method].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();
            p.contract_number = dt.Rows[0][be.contract_number].ToString();



            return p;
        }
    }
}
