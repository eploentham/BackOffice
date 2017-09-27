using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TPatientAppointmentOrderDB
    {
        TPatientAppointmentOrder tpao;
        ConnectDB conn;
        public TPatientAppointmentOrderDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tpao = new TPatientAppointmentOrder();
            tpao.b_item_id = "b_item_id";
            tpao.patient_appointment_order_common_name = "patient_appointment_order_common_name";
            tpao.t_patient_appointment_id = "t_patient_appointment_id";
            tpao.t_patient_appointment_order_id = "t_patient_appointment_order_id";
            tpao.t_patient_id = "t_patient_id";

            tpao.pkField = "t_patient_appointment_order_id";
            tpao.table = "t_patient_appointment_order";
        }
    }
}
