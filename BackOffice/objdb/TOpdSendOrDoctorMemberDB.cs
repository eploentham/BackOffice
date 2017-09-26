using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TOpdSendOrDoctorMemberDB
    {
        TOpdSendORDoctorMember tosodm;
        ConnectDB conn;
        public TOpdSendOrDoctorMemberDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tosodm = new TOpdSendORDoctorMember();
            tosodm.opd_send_or_doctor_member = "opd_send_or_doctor_member";
            tosodm.t_opd_send_or_doctor_member_id = "t_opd_send_or_doctor_member_id";
            tosodm.t_opd_send_or_id = "t_opd_send_or_id";

            tosodm.pkField = "t_opd_send_or_doctor_member_id";
            tosodm.table = "t_opd_send_or_doctor_member";
        }
    }
}
