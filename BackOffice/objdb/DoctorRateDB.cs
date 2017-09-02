using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.objdb
{
    public class DoctorRateDB
    {
        ConnectDB conn;
        DoctorRate dtrR;
        public DoctorRateDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            dtrR = new DoctorRate();
            dtrR.Active = "active";
            dtrR.Desc = "description";
            dtrR.DtrCode = "dtr_code";
            dtrR.InsCode = "ins_code";
            dtrR.InsCodeName = "ins_code_name";
            dtrR.ItmAstCod = "itm_ast_cod";
            dtrR.ItmCod = "itm_cod";
            dtrR.ItmKorNam = "itm_kor_nam";
            dtrR.Rate = "rate";
            dtrR.RateCode = "rate_code";
            dtrR.RateId = "rate_id";
            dtrR.RateTyp = "rate_typ";
            dtrR.Remark = "remark";
            dtrR.TypTime = "typ_time";

            dtrR.table = "df_b_doctor_rate";
            dtrR.pkField = "rate_id";
        }
    }
}
