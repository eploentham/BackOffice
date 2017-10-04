using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public class ControlMaster
    {
        ConnectDB conn, connBIT;
        DataTable dtTit = new DataTable();
        public InitC initC;
        public IniFile iniFile;
        public ControlMaster()
        {
            iniFile = new IniFile(Environment.CurrentDirectory + "\\" + Application.ProductName + ".ini");
            initC = new InitC();
            conn = new ConnectDB("orc_bit", initC);
            connBIT = new ConnectDB("bit", initC);
            initConfig();
        }
        //public ControlMaster(ConnectDB orc_bit, ConnectDB bit)
        //{
        //    iniFile = new IniFile(Environment.CurrentDirectory + "\\" + Application.ProductName + ".ini");
        //    initC = new InitC();
        //    conn = orc_bit;
        //    connBIT = bit;
        //    initConfig();
        //}
        public void GetConfig()
        {
            initC.databaseDBBIT = iniFile.Read("databaseDBBIT");    //bit
            initC.hostDBBIT = iniFile.Read("hostDBBIT");
            initC.userDBBIT = iniFile.Read("userDBBIT");
            initC.passDBBIT = iniFile.Read("passDBBIT");
            initC.portDBBIT = iniFile.Read("portDBBIT");

            initC.databaseDBBITDemo = iniFile.Read("databaseDBBITDemo");    //bit demo
            initC.hostDBBITDemo = iniFile.Read("hostDBBITDemo");
            initC.userDBBITDemo = iniFile.Read("userDBBITDemo");
            initC.passDBBITDemo = iniFile.Read("passDBBITDemo");
            initC.portDBBITDemo = iniFile.Read("portDBBITDemo");

            initC.databaseDBORCMA = iniFile.Read("databaseDBORCMA");      //orc master
            initC.hostDBORCMA = iniFile.Read("hostDBORCMA");
            initC.userDBORCMA = iniFile.Read("userDBORCMA");
            initC.passDBORCMA = iniFile.Read("passDBORCMA");
            initC.portDBORCMA = iniFile.Read("portDBORCMA");

            initC.databaseDBORCBA = iniFile.Read("databaseDBORCBA");        // orc backoffice
            initC.hostDBORCBA = iniFile.Read("hostDBORCBA");
            initC.userDBORCBA = iniFile.Read("userDBORCBA");
            initC.passDBORCBA = iniFile.Read("passDBORCBA");
            initC.portDBORCBA = iniFile.Read("portDBORCBA");

            initC.databaseDBORCBIT = iniFile.Read("databaseDBORCBIT");        // orc BIT
            initC.hostDBORCBIT = iniFile.Read("hostDBORCBIT");
            initC.userDBORCBIT = iniFile.Read("userDBORCBIT");
            initC.passDBORCBIT = iniFile.Read("passDBORCBIT");
            initC.portDBORCBIT = iniFile.Read("portDBORCBIT");
            //initC.quoLine6 = iniFile.Read("quotationline6");

            //initC.grdQuoColor = iniFile.Read("gridquotationcolor");

            //initC.HideCostQuotation = iniFile.Read("hidecostquotation");
            //if (initC.grdQuoColor.Equals(""))
            //{
            //    initC.grdQuoColor = "#b7e1cd";
            //}
            //initC.Password = regE.getPassword();
        }
        private void initConfig()
        {
            GetConfig();
            dtTit = selectTitle();
        }
        public ComboBox getCboTitle(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectTitle();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i]["dtlcod"].ToString();
                item.Text = dt.Rows[i]["dtlcodnam"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public DataTable selectTitle()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "SELECT *  " +
                "FROM DtlMst1  " +
                "Where DtlTblCod = 'TITCOD' Order By DtlCod";
            dt = conn.selectData(sql, "orc_bit");

            return dt;
        }
        public String getTitCod(String titNam)
        {
            String ret = "";
            for(int i = 0; i < dtTit.Rows.Count; i++)
            {
                if (titNam.Equals(dtTit.Rows[i]["dtlcodnam"].ToString()))
                {
                    ret = dtTit.Rows[i]["dtlcod"].ToString();
                    continue;
                }
            }
            return ret;
        }
        public DataTable selectMedicalField()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "SELECT *  " +
                "FROM bithis.depmst1  " +
                "Where depgrpcod in ('GS','PED','OBGY','MED') and depcod <> 'D888' Order By depkornam";
            dt = conn.selectData(sql, "orc_bit");

            return dt;
        }
        public DataTable selectUsrCashier()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select uid.* " +
                "From uidmst1 uid " +
                "Where uiddepcod = 'FIN'";
            DataTable dtInc = new DataTable();
            dt = conn.selectData(sql, "orc_bit");
            return dt;
        }
        public DataTable selectUsrDoctor()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select uid.* " +
                "From uidmst1 uid " +
                "Where uidprtcod = 'DTR'";
            DataTable dtInc = new DataTable();
            dt = conn.selectData(sql, "orc_bit");
            return dt;
        }
    }
}
