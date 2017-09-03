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
    }
}
