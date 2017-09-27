using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class TVisitPhysicalExamDB
    {
        TVisitPhysicalExam tvpe;
        ConnectDB conn;
        public TVisitPhysicalExamDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tvpe = new TVisitPhysicalExam();
            tvpe.record_date_time = "record_date_time";
            tvpe.t_patient_id = "t_patient_id";
            tvpe.t_visit_id = "t_visit_id";
            tvpe.t_visit_physical_exam_id = "t_visit_physical_exam_id";
            tvpe.visit_physical_exam_body = "visit_physical_exam_body";
            tvpe.visit_physical_exam_detail = "visit_physical_exam_detail";
            tvpe.visit_physical_exam_staff_execute = "visit_physical_exam_staff_execute";

            tvpe.pkField = "t_visit_physical_exam_id";
            tvpe.table = "t_visit_physical_exam";
        }
    }
}
