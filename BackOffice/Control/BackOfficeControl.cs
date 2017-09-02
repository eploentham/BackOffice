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
        ConnectDB conn, connBIT;

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
        public BackOfficeControl()
        {
            conn = new ConnectDB("orc_bit");
            connBIT = new ConnectDB("bit");
            fontSize9 = 9.75f;
            fontSize8 = 8.25f;
            fV1B = new Font(fontName, fontSize9, FontStyle.Bold);
            fV1 = new Font(fontName, fontSize8, FontStyle.Regular);

            iBITDB = new ImportBITDB();
            dtrDB = new DoctorDB(conn);
            dtrRDB = new DoctorRateDB(conn);
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
                "FROM DtlMst  " +
                "Where DtlTblCod = 'TITCOD' Order By DtlCod";
            dt = connBIT.selectData(sql, "orc_bit");

            return dt;
        }
         
    }
}
