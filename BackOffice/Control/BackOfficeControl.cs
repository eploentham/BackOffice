using BackOffice.objdb;
using BackOffice.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public class BackOfficeControl
    {
        ConnectDB connORCBIT, connBIT, connORCBA;

        static String fontName = "Microsoft Sans Serif";
        public String backColor1 = "#1E1E1E";
        public String backColor2 = "#2D2D30";
        public String foreColor1 = "#fff";
        static float fontSize9 = 9.75f;
        static float fontSize8 = 8.25f;
        public Font fV1B, fV1;
        public int tcW = 0, tcH=0, tcWMinus = 25, tcHMinus = 70, formFirstLineX=5, formFirstLineY=5;

        public ImportBITDB iBITDB;
        public DoctorDB dtrDB;
        public DoctorRateDB dtrRDB;
        public ControlMaster cm;
        public DfTDoctorDB dfDB;
        public DfTDoctorDetailDB dfDDB;

        public String DtrCode="";
        public DataTable dtDep, dtDtrTit, dtTit, dtDtrCat, dtDtrTyp;
        private IniFile iniFile;
        public InitC initC;
        public BackOfficeControl()
        {
            iniFile = new IniFile(Environment.CurrentDirectory + "\\" + Application.ProductName + ".ini");
            initC = new InitC();

            connORCBIT = new ConnectDB("orc_bit");
            connBIT = new ConnectDB("bit");
            connORCBA = new ConnectDB("orc_ba");
            fontSize9 = 9.75f;
            fontSize8 = 8.25f;
            fV1B = new Font(fontName, fontSize9, FontStyle.Bold);
            fV1 = new Font(fontName, fontSize8, FontStyle.Regular);

            iBITDB = new ImportBITDB();
            dtrDB = new DoctorDB(connORCBA);
            dtrRDB = new DoctorRateDB(connORCBA);
            dfDB = new DfTDoctorDB(connORCBIT,connORCBA);
            dfDDB = new DfTDoctorDetailDB(connORCBIT, connORCBA);
            cm = new ControlMaster(connORCBIT, connBIT);

            dtDep = cm.selectMedicalField();
            dtDtrTit = selectTitleDtr();
            dtDtrCat = selectDtrCat();
            dtDtrTyp = selectDtrTyp();

            dtTit = selectTitle();
        }
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
        public String getMedecalFieldName(String code)
        {
            String txt = "";
            for(int i = 0; i < dtDep.Rows.Count; i++)
            {
                if (dtDep.Rows[i]["depcod"].ToString().Equals(code))
                {
                    txt = dtDep.Rows[i]["depkornam"].ToString();
                    break;
                }
            }
            return txt;
        }
        public String getDtrCatName(String code)
        {
            String txt = "";
            for (int i = 0; i < dtDtrCat.Rows.Count; i++)
            {
                if (dtDtrCat.Rows[i]["init_val"].ToString().Equals(code))
                {
                    txt = dtDtrCat.Rows[i]["init_name_t"].ToString();
                    break;
                }
            }
            return txt;
        }
        public String getDtrTypName(String code)
        {
            String txt = "";
            for (int i = 0; i < dtDtrTyp.Rows.Count; i++)
            {
                if (dtDtrTyp.Rows[i]["init_val"].ToString().Equals(code))
                {
                    txt = dtDtrTyp.Rows[i]["init_name_t"].ToString();
                    break;
                }
            }
            return txt;
        }
        public String getTitleNameT(String code)
        {
            String txt = "";
            for (int i = 0; i < dtDtrTit.Rows.Count; i++)
            {
                if (dtDtrTit.Rows[i]["dtlcod"].ToString().Equals(code))
                {
                    txt = dtDtrTit.Rows[i]["dtlcodnam"].ToString();
                    break;
                }
            }
            return txt;
        }
        public String getTitleNameT1(String code)
        {
            String txt = "";
            for (int i = 0; i < dtTit.Rows.Count; i++)
            {
                if (dtTit.Rows[i]["dtlcod"].ToString().Equals(code))
                {
                    txt = dtTit.Rows[i]["dtlcodnam"].ToString();
                    break;
                }
            }
            return txt;
        }
        public String getTitleNameE(String code)
        {
            String txt = "";
            for (int i = 0; i < dtDtrTit.Rows.Count; i++)
            {
                if (dtDtrTit.Rows[i]["dtlcod"].ToString().Equals(code))
                {
                    txt = dtDtrTit.Rows[i]["dtlcodval"].ToString();
                    break;
                }
            }
            return txt;
        }
        public ComboBoxItem getCboItem(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Value.Equals(valueId))
                {
                    r = cc;
                }
            }
            return r;
        }
        public ComboBox getCboTitleT(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectTitle();
            for (int i = 0; i < dtDtrTit.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dtDtrTit.Rows[i]["dtlcod"].ToString();
                item.Text = dtDtrTit.Rows[i]["dtlcodnam"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboTitleE(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectTitle();
            for (int i = 0; i < dtDtrTit.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dtDtrTit.Rows[i]["dtlcod"].ToString();
                item.Text = dtDtrTit.Rows[i]["dtlcodnam"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboDtrTitleT(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectTitleDr();
            for (int i = 0; i < dtDtrTit.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dtDtrTit.Rows[i]["dtlcod"].ToString();
                item.Text = dtDtrTit.Rows[i]["dtlcodnam"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboDtrTitleE(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectTitleDr();
            for (int i = 0; i < dtDtrTit.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dtDtrTit.Rows[i]["dtlcod"].ToString();
                item.Text = dtDtrTit.Rows[i]["dtlcodval"].ToString();
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
            dt = connORCBIT.selectData(sql, "orc_bit");

            return dt;
        }
        public DataTable selectTitleDtr()
        {
            String sql = "";
            //DataTable dt = new DataTable();
            sql = "SELECT *  " +
                "FROM DtlMst1  " +
                "Where DtlTblCod = 'TITCOD' and dtlcod in ('04','06') Order By DtlCod";
            dtDtrTit = connORCBIT.selectData(sql, "orc_bit");

            return dtDtrTit;
        }
        public DataTable selectDtrTyp()
        {
            String sql = "";
            //DataTable dt = new DataTable();
            sql = "SELECT *  " +
                "FROM b_master_initial  " +
                "Where init_dep = 'dtr' and init_code = 'typ' Order By sort1";
            dtDtrTyp = connORCBA.selectData(sql, "orc_ba");

            return dtDtrTyp;
        }
        public DataTable selectDtrCat()
        {
            String sql = "";
            //DataTable dt = new DataTable();
            sql = "SELECT *  " +
                "FROM b_master_initial  " +
                "Where init_dep = 'dtr' and init_code = 'cat' Order By sort1";
            dtDtrCat = connORCBA.selectData(sql, "orc_ba");

            return dtDtrCat;
        }
        public ComboBox getCboDtrTyp(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectTitleDr();
            for (int i = 0; i < dtDtrTyp.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dtDtrTyp.Rows[i]["init_val"].ToString();
                item.Text = dtDtrTyp.Rows[i]["init_name_t"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboDtrCat(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //DataTable dt = selectTitleDr();
            for (int i = 0; i < dtDtrCat.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dtDtrCat.Rows[i]["init_val"].ToString();
                item.Text = dtDtrCat.Rows[i]["init_name_t"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboMedicalField(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = cm.selectMedicalField();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i]["depcod"].ToString();
                item.Text = dt.Rows[i]["depkornam"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboUsrCashier(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = cm.selectUsrCashier();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i]["uidcod"].ToString();
                item.Text = dt.Rows[i]["uidnam"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            return c;
        }
        public String getValueCboItem(ComboBox c)
        {
            ComboBoxItem iSale;
            iSale = (ComboBoxItem)c.SelectedItem;
            if (iSale == null)
            {
                return "";
            }
            else
            {
                return iSale.Value;
            }
        }
        public ComboBox setCboItem(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Value.Equals(valueId))
                {
                    c.Text = cc.Text;
                    return c;
                }
            }
            return c;
        }
        public DataTable selectItmMstDtr()
        {
            DataTable dt = new DataTable();
            String sql = "Select itmm.*  "
                            + "From ItmMst1 itmm "
                            + "Where  itmm.itmsrvopd = '11'  " +
                            "order by itmm.itminccod ";
            DataTable dtItm = new DataTable();
            dt = connORCBIT.selectData(sql, "orc_bit");
            return dt;
        }
        public DataTable selectInsMst()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select insm.* " +
                "From insmst1 insm ";
            DataTable dtInc = new DataTable();
            dt = connORCBIT.selectData(sql, "orc_bit");
            return dt;
        }
        
        public void saveDoctor(Doctor dtr)
        {
            dtrDB.insertDoctor(dtr);
        }
        public void saveDoctorRaate(DoctorRate dtrR)
        {
            dtrRDB.insertDoctorRate(dtrR);
        }
        public String ThaiBaht(string txt)
        {
            string bahtTxt, n, bahtTH = "";
            double amount;
            try { amount = Convert.ToDouble(txt); }
            catch { amount = 0; }
            bahtTxt = amount.ToString("####.00");
            string[] num = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
            string[] rank = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            string[] temp = bahtTxt.Split('.');
            string intVal = temp[0];
            string decVal = temp[1];
            if (Convert.ToDouble(bahtTxt) == 0)
                bahtTH = "ศูนย์บาทถ้วน";
            else
            {
                for (int i = 0; i < intVal.Length; i++)
                {
                    n = intVal.Substring(i, 1);
                    if (n != "0")
                    {
                        if ((i == (intVal.Length - 1)) && (n == "1"))
                            bahtTH += "เอ็ด";
                        else if ((i == (intVal.Length - 2)) && (n == "2"))
                            bahtTH += "ยี่";
                        else if ((i == (intVal.Length - 2)) && (n == "1"))
                            bahtTH += "";
                        else
                            bahtTH += num[Convert.ToInt32(n)];
                        bahtTH += rank[(intVal.Length - i) - 1];
                    }
                }
                bahtTH += "บาท";
                if (decVal == "00")
                    bahtTH += "ถ้วน";
                else
                {
                    for (int i = 0; i < decVal.Length; i++)
                    {
                        n = decVal.Substring(i, 1);
                        if (n != "0")
                        {
                            if ((i == decVal.Length - 1) && (n == "1"))
                                bahtTH += "เอ็ด";
                            else if ((i == (decVal.Length - 2)) && (n == "2"))
                                bahtTH += "ยี่";
                            else if ((i == (decVal.Length - 2)) && (n == "1"))
                                bahtTH += "";
                            else
                                bahtTH += num[Convert.ToInt32(n)];
                            bahtTH += rank[(decVal.Length - i) - 1];
                        }
                    }
                    bahtTH += "สตางค์";
                }
            }
            return bahtTH;
        }
        public DataTable genDtrAutoImport(String dailyDate)
        {
            DataTable dt = new DataTable();
            dt = dfDB.selectDfToImport(dailyDate);
            return dt;
        }
        public String FormatTime(String t)
        {
            String aa = "";
            aa = "0000" + t;
            if (aa.Length >= 4)
            {
                aa = aa.Substring(aa.Length - 4, 2) + ":" + aa.Substring(aa.Length - 2);
            }
            return aa;
        }
        public String getMonth(String monthId)
        {
            if (monthId == "01")
            {
                return "มกราคม";
            }
            else if (monthId == "02")
            {
                return "กุมภาพันธ์";
            }
            else if (monthId == "03")
            {
                return "มีนาคม";
            }
            else if (monthId == "04")
            {
                return "เมษายน";
            }
            else if (monthId == "05")
            {
                return "พฤษภาคม";
            }
            else if (monthId == "06")
            {
                return "มิถุนายน";
            }
            else if (monthId == "07")
            {
                return "กรกฎาคม";
            }
            else if (monthId == "08")
            {
                return "สิงหาคม";
            }
            else if (monthId == "09")
            {
                return "กันยายน";
            }
            else if (monthId == "10")
            {
                return "ตุลาคม";
            }
            else if (monthId == "11")
            {
                return "พฤศจิกายน";
            }
            else if (monthId == "12")
            {
                return "ธันวาคม";
            }
            else
            {
                return "";
            }
        }
        public ComboBox setCboMonth(ComboBox c)
        {
            c.Items.Clear();
            var items = new[]{
                new{Text = "มกราคม", Value="01"},
                new{Text = "กุมภาพันธ์", Value="02"},
                new{Text = "มีนาคม", Value="03"},
                new{Text = "เมษายน", Value="04"},
                new{Text = "พฤษภาคม", Value="05"},
                new{Text = "มิถุนายน", Value="06"},
                new{Text = "กรกฎาคม", Value="07"},
                new{Text = "สิงหาคม", Value="08"},
                new{Text = "กันยายน", Value="09"},
                new{Text = "ตุลาคม", Value="10"},
                new{Text = "พฤศจิกายน", Value="11"},
                new{Text = "ธันวาคม", Value="12"}
            };
            c.DataSource = items;
            c.DisplayMember = "Text";

            c.ValueMember = "Value";
            c.SelectedIndex = c.FindStringExact(getMonth(System.DateTime.Now.Month.ToString("00")));
            return c;
        }
        public ComboBox setCboYear(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add(System.DateTime.Now.Year + 543);
            c.Items.Add(System.DateTime.Now.Year + 543 - 1);
            c.Items.Add(System.DateTime.Now.Year + 543 - 2);
            c.SelectedIndex = c.FindStringExact(String.Concat(System.DateTime.Now.Year + 543));
            return c;
        }
        public String getReceiptNumber()
        {
            DataTable dt = new DataTable();
            String sql = "", prefix="", number="";
            sql = "Select receipt_number, receipt_prefix From b_site";
            dt = connORCBA.selectData(sql, "orc_bit");
            if(dt.Rows.Count > 0)
            {
                prefix = dt.Rows[0]["receipt_prefix"].ToString();
                number = "000000" + dt.Rows[0]["receipt_number"].ToString();
                number = number.Substring(number.Length - 6);
            }
            return prefix + number;
        }
        public String getInvoiceNumber()
        {
            DataTable dt = new DataTable();
            String sql = "", prefix = "", number = "";
            sql = "Select invoice_number, invoice_prefix From b_site";
            dt = connORCBA.selectData(sql, "orc_bit");
            if (dt.Rows.Count > 0)
            {
                prefix = dt.Rows[0]["invoice_prefix"].ToString();
                number = "000000" + dt.Rows[0]["invoice_number"].ToString();
                number = number.Substring(number.Length - 6);
            }
            return prefix + number;
        }
        public void genReceiptNumber()
        {
            String sql = "Update b_site Set receipt_number = receipt_number+1";
            connORCBA.ExecuteNonQuery(sql, "orc_ba");
        }
        public void genInvoiceNumber()
        {
            String sql = "Update b_site Set invoice_number = invoice_number+1";
            connORCBA.ExecuteNonQuery(sql, "orc_ba");
        }
        public String docReceiptNumber()
        {
            genReceiptNumber();
            return getReceiptNumber();
        }
        public String docInvoiceNumber()
        {
            genInvoiceNumber();
            return getInvoiceNumber();
        }
    }
}
