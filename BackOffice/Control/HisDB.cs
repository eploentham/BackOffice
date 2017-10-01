using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{ 
    public class HisDB
    {
        ConnectDB conn;

        BContractDB bcDB;
        BContractPayerDB bcpaDB;
        BContractPlansDB bcplDB;
        BDeductConditionDB bdcDB;
        BDeductDB bdDB;
        BEmplyeeDB beDB;
        BGroupChronicDB bgcDB;
        BIcd10DB bicd10DB;
        BIcd9DB bicd9DB;
        BItem16GroupDB bi16gDB;
        BItemBillingSubGroupDB bibsgDB;
        BItemDB biDB;
        BItemGroupDB bigDB;
        BItemPriceDB bipDB;
        BItemSetDB bisdb;
        BItemSubGroupDB bisgDB;
        BServicePointDB bspDB;
        BSiteDB bsDB;
        BVisitBedDB bvbDB;
        BVisitClinicDB bvcDB;
        BVisitOfficeDB bvoDB;
        BVisitRoomDB bvrDB;
        BVisitWardDB bvwDB;
        FBloodGroupDB fbgDB;
        FDischargeStatusDB fdsDB;
        FEducationTypeDB fetDB;
        FEmergencyStatusDB fesDB;
        FForeignerDB ffDB;
        FItemBillingGroupDB fibgDB;
        FItemGroupDB figDB;
        FItemLabTypeDB filtDB;
        FMarriageDB fmDB;
        FNationDB fnDB;
        FOccupationDB foDB;
        FOrderStatusDB fosDB;
        FPrefixDB fpDB;
        FReferCauseDB frcDB;
        FRelationDB frDB;

        public TBillingDB tbDB;
        public TBillingInvoiceDB tbiDB;
        public TBillingReceiptDB tbrDB;
        public TBillingReceiptDetailDB tbrdDB;
        public TBillingReceiptItemDB tbriDB;
        public TBillingReceiptSubGroupDB tbrsgDB;
        public HisDB(ConnectDB connorc_ma)
        {
            conn = connorc_ma;
            initConfig();
        }
        private void initConfig()
        {
            tbDB = new TBillingDB(conn);
            tbiDB = new TBillingInvoiceDB(conn);
            tbrDB = new TBillingReceiptDB(conn);
            tbrdDB = new TBillingReceiptDetailDB(conn);
            tbriDB = new TBillingReceiptItemDB(conn);
            tbrsgDB = new TBillingReceiptSubGroupDB(conn);

        }
    }
}
