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
        ConnectDB conn, connBIT, connORCBA;

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

        public String DtrCode="";
        public DataTable dtDep;
        public BackOfficeControl()
        {
            conn = new ConnectDB("orc_bit");
            connBIT = new ConnectDB("bit");
            connORCBA = new ConnectDB("orc_ba");
            fontSize9 = 9.75f;
            fontSize8 = 8.25f;
            fV1B = new Font(fontName, fontSize9, FontStyle.Bold);
            fV1 = new Font(fontName, fontSize8, FontStyle.Regular);

            iBITDB = new ImportBITDB();
            dtrDB = new DoctorDB(connORCBA);
            dtrRDB = new DoctorRateDB(connORCBA);
            cm = new ControlMaster(conn, connBIT);
            dtDep = cm.selectMedicalField();
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
        public ComboBox getCboTitleE(ComboBox c)
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
        public ComboBox getCboTitleDrT(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectTitleDr();
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
        public ComboBox getCboTitleDrE(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectTitleDr();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i]["dtlcod"].ToString();
                item.Text = dt.Rows[i]["dtlcodval"].ToString();
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
        public DataTable selectTitleDr()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "SELECT *  " +
                "FROM DtlMst1  " +
                "Where DtlTblCod = 'TITCOD' and dtlcod in ('04','06') Order By DtlCod";
            dt = conn.selectData(sql, "orc_bit");

            return dt;
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
            dt = conn.selectData(sql, "orc_bit");
            return dt;
        }
        public DataTable selectInsMst()
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "Select insm.* " +
                "From insmst1 insm ";
            DataTable dtInc = new DataTable();
            dt = conn.selectData(sql, "orc_bit");
            return dt;
        }
        public void saveDoctor(Doctor dtr)
        {
            dtrDB.insertDoctor(dtr);
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
    }
}
