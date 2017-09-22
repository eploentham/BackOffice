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
            p.employee_login = dt.Rows[0][be.employee_login].ToString();
            p.employee_password = dt.Rows[0][be.employee_password].ToString();
            p.employee_firstname = dt.Rows[0][be.employee_firstname].ToString();
            p.employee_lastname = dt.Rows[0][be.employee_lastname].ToString();
            p.employee_number = dt.Rows[0][be.employee_number].ToString();
            p.employee_last_login = dt.Rows[0][be.employee_last_login].ToString();
            p.employee_last_logout = dt.Rows[0][be.employee_last_logout].ToString();
            p.b_service_point_id = dt.Rows[0][be.b_service_point_id].ToString();
            p.f_employee_level_id = dt.Rows[0][be.f_employee_level_id].ToString();

            p.f_employee_rule_id = dt.Rows[0][be.f_employee_rule_id].ToString();
            p.f_employee_authentication_id = dt.Rows[0][be.f_employee_authentication_id].ToString();
            p.b_employee_default_tab = dt.Rows[0][be.b_employee_default_tab].ToString();
            p.employee_warning_dx = dt.Rows[0][be.employee_warning_dx].ToString();
            p.b_bank_id = dt.Rows[0][be.b_bank_id].ToString();
            p.b_bank_namet = dt.Rows[0][be.b_bank_namet].ToString();
            p.book_bank_id = dt.Rows[0][be.book_bank_id].ToString();
            p.book_bank_namet = dt.Rows[0][be.book_bank_namet].ToString();
            p.payment_status_id = dt.Rows[0][be.payment_status_id].ToString();
            p.payment_status_namet = dt.Rows[0][be.payment_status_namet].ToString();

            p.employee_firstnamee = dt.Rows[0][be.employee_firstnamee].ToString();
            p.employee_lastnamee = dt.Rows[0][be.employee_lastnamee].ToString();
            p.position_id = dt.Rows[0][be.position_id].ToString();
            p.position_namet = dt.Rows[0][be.position_namet].ToString();
            p.status_employee = dt.Rows[0][be.status_employee].ToString();
            p.send_service_id = dt.Rows[0][be.send_service_id].ToString();
            p.employee_lab_master = dt.Rows[0][be.employee_lab_master].ToString();
            p.employee_status_approve_control_item = dt.Rows[0][be.employee_status_approve_control_item].ToString();
            p.security_pin = dt.Rows[0][be.security_pin].ToString();
            p.limit_appointment = dt.Rows[0][be.limit_appointment].ToString();

            p.doctor_lying = dt.Rows[0][be.doctor_lying].ToString();
            p.status_funds = dt.Rows[0][be.status_funds].ToString();
            p.status_contact = dt.Rows[0][be.status_contact].ToString();
            p.status_admission = dt.Rows[0][be.status_admission].ToString();
            p.status_physical = dt.Rows[0][be.status_physical].ToString();
            p.f_doctor_branch_id = dt.Rows[0][be.f_doctor_branch_id].ToString();
            p.b_employee_id = dt.Rows[0][be.b_employee_id].ToString();
            p.charge = dt.Rows[0][be.charge].ToString();
                        
            return p;
        }
        private String insert(BEmployee p)
        {
            String sql = "", chk = "";
            try
            {
                if (p.employee_login.Equals(""))
                {
                    return "";
                }
                //p.RowNumber = selectMaxRowNumber(p.YearId);
                p.Active = "1";
                sql = "Insert Into " + be.table + "(" + be.Active + "," + be.employee_login + "," + be.employee_password + "," +
                    be.employee_firstname + "," + be.employee_lastname + "," + be.employee_number + "," +
                    be.employee_last_login + "," + be.employee_last_logout + "," + be.b_service_point_id + "," +
                    be.f_employee_level_id + "," + be.f_employee_rule_id + "," + be.f_employee_authentication_id + "," +
                    be.b_employee_default_tab + "," + be.employee_warning_dx + "," + be.b_bank_id + "," +
                    be.b_bank_namet + "," + be.book_bank_id + "," + be.book_bank_namet + "," +
                    be.payment_status_id + "," + be.payment_status_namet + "," + be.employee_firstnamee + "," +
                    be.employee_lastnamee + "," + be.position_id + "," + be.position_namet + "," +
                    be.status_employee + "," + be.send_service_id + "," + be.employee_lab_master + "," +
                    be.employee_status_approve_control_item + "," + be.security_pin + "," + be.limit_appointment + "," +
                    be.doctor_lying + "," + be.status_funds + "," + be.status_contact + "," +
                    p.status_admission + "','" + p.status_physical + "','" + p.f_doctor_branch_id + "','" +
                    be.b_employee_id + "," + be.charge + ") " +
                    "Values('" + p.Active + "','" + p.employee_login + "','" + p.employee_password + "','" +
                    p.employee_firstname + "','" + p.employee_lastname + "','" + p.employee_number + "','" +
                    p.employee_last_login + "','" + p.employee_last_logout + "','" + p.b_service_point_id + "','" +
                    p.f_employee_level_id + "','" + p.f_employee_rule_id + "','" + p.f_employee_authentication_id + "','" +
                    p.b_employee_default_tab + "','" + p.employee_warning_dx + "','" + p.b_bank_id + "','" +
                    p.b_bank_namet + "','" + p.book_bank_id + "','" + p.book_bank_namet + "','" +
                    p.payment_status_id + "','" + p.payment_status_namet + "','" + p.employee_firstnamee + "','" +
                    p.employee_lastnamee + "','" + p.position_id + "','" + p.position_namet + "','" +
                    p.status_employee + "','" + p.send_service_id + "','" + p.employee_lab_master + "','" +
                    p.employee_status_approve_control_item + "','" + p.security_pin + "','" + p.limit_appointment + "','" +
                    p.doctor_lying + "','" + p.status_funds + "','" + p.status_contact + "','" +
                    p.status_admission + "','" + p.status_physical + "','" + p.f_doctor_branch_id + "','" +
                    p.b_employee_id + "','" + p.charge + "') ";
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
