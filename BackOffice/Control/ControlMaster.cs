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
    class ControlMaster
    {
        ConnectDB conn, connBIT;
        DataTable dtTit = new DataTable();
        public ControlMaster()
        {
            conn = new ConnectDB("orc_bit");
            connBIT = new ConnectDB("bit");
            initConfig();
        }
        public ControlMaster(ConnectDB orc_bit, ConnectDB bit)
        {
            conn = orc_bit;
            connBIT = bit;
            initConfig();
        }
        private void initConfig()
        {
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
    }
}
