using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.object1
{
    public class DfTDoctor:Persistent
    {
        public String DfId="", DtrCode = "", DrfSeqNum = "", drfodrcod = "", DrfOcmNum = "", DrfRcpNum, DrfCalNum = "", DrfPatTyp = "", DrfOdrSeq = "", DrfGrpSeq = "", DrfOspTyp = "";
        public String DrfOdrAmt = "", DrfOdrDtm = "", DrfIncCod = "", DrfRcpSeq = "", DrfDivYon = "", DrfBilNum = "", DrfCtrCodv, DrfCtrSeq = "", DrfCurStt = "", DrfUpdDtm, DrfUidCod = "";
        public String Active = "", MonthId = "", YearId = "", StatusApprove="", StatusDoc="", PspPatNam="", PspSurNam="", OrpChtNum="", InsCodNam="", orptotamt="", ItmKorNam="", ItmCod="", ItmAstCod="", ItmSrvOpd="";
        public String df = "";
    }
}
