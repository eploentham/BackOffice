using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class FDoctorBranchDB
    {
        FDoctorBranch fdb;
        ConnectDB conn;
        public FDoctorBranchDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            fdb = new FDoctorBranch();
            fdb.doctor_branch_description = "doctor_branch_description";
            fdb.f_doctor_branch_id = "f_doctor_branch_id";

            fdb.pkField = "f_doctor_branch_id";
            fdb.table = "f_doctor_branch";
        }
    }
}
