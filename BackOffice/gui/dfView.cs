using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class dfView : Form
    {
        public ConnectDB conn;
        BackOfficeControl boC;
        int colCnt = 18, colRow = 0, colPatientName = 1, colHnno = 2, colDate = 3, colTime = 4, colBilNum = 5, colRcpNum = 6, colTotal = 7, coldrfodrcod = 8, coldtlcodnam = 9, colDf=10;
        int coldtrcod = 11, coldtrnam = 12, colUpdDtm = 14, colPatTyp = 13, colUidNam = 16, colUidCod = 15, colInsNam = 17;
        public dfView(BackOfficeControl boc)
        {
            boC = boc;
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            
            //boC = new BackOfficeControl();
            conn = new ConnectDB("bit", boC.initC);
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml(boC.backColor1);
            //foreach (Control x in this.Controls)
            //{
            //    x.Font = boC.fV2;
            //    if (x is Label)
            //    {
            //        x.ForeColor = System.Drawing.ColorTranslator.FromHtml(boC.foreColor1);
            //    }
            //    else if (x is GroupBox)
            //    {
            //        x.ForeColor = System.Drawing.ColorTranslator.FromHtml(boC.foreColor1);
            //    }
            //    else if (x is DataGridView)
            //    {
            //        x.BackColor = System.Drawing.ColorTranslator.FromHtml(boC.backColor1);
            //    }
            //}
        }
        private void setResize()
        {
            if (boC.tcW > 0)
            {
                if(dgvView.Width < boC.tcW)
                {
                    dgvView.Width = boC.tcW-450;
                }
                
            }
            else
            {
                dgvView.Width = this.Width - 50;
            }
            
            dgvView.Height = this.Height - 150;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //[OdrInf]
            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
            String dailyDate = "";
            dailyDate = dtpDailyDate.Value.Year.ToString() + dtpDailyDate.Value.ToString("MMdd");
            //String sql = "select psp.PspPatNam, psp.PspSurNam, orp.OrpChtNum, orp.OrpBilNum, orp.OrpRcpNum, orp.OrpTotAmt "
            //                +", orp.OrpAskAmt, orp.OrpDisAmt, orp.OrpPayAmt, orp.OrpCasAmt, orp.OrpCrdAmt, orp.OrpUpdDtm, orp.OrpAccDte "
            //                + ", orp.OrpPatTyp, orp.OrpDtrCod, orp.OrpUidCod, uidm.UidNam as UidNam, uidd.UidNam as dtrName, orp.OrpUidCod, orp.OrpDtrCod, insm.InsCodNam "
            //                + "From orpend orp "
            //                +"left join pspinf psp on orp.OrpChtNum = psp.PspChtNum "
            //                +"left join UidMst uidm on uidm.UidCod = orp.OrpUidCod "
            //                +"left join UidMst uidd on uidd.UidCod = orp.OrpDtrCod "
            //                + "left join InsMst insm on insm.InsCod = orp.OrpInsCod ";
            String sql = "select psp.PspPatNam, psp.PspSurNam, orp.OrpChtNum, drf.drfodrcod, drf.drfdtrcod, drf.drfocmnum, drf.drfpattyp, drf.drfodramt, drf.drfodrdtm, drf.drfinccod, drf.drfbilnum " +
                            " , drf.drfuidcod,drf.drfodrcod, dtlm.dtlcodnam, uidm.UidNam as UidNam, uidd.UidNam as dtrName, drf.drfrcpnum, drf.drfrcpnum, drf.drfuidcod " +
                            ", insm.InsCodNam, orp.orptotamt, drf.drfodrdtm  "
                            + "From drfrcp drf "
                            + "left join dtlmst dtlm on drf.drfodrcod = dtlm.dtlcodval  "
                            + "left join UidMst uidm on uidm.UidCod = drf.drfuidcod  "
                            + "left join UidMst uidd on uidd.UidCod = drf.drfdtrcod "
                            + "left join orpinf orp on orp.Orpocmnum = drf.drfocmnum "
                            + "left join pspinf psp on orp.OrpChtNum = psp.PspChtNum    "
                            + "left join InsMst insm on insm.InsCod = orp.OrpInsCod  "
                            + "Where  orp.OrpCtrCod = 'TOTAL' and drfodrdtm >='" + dailyDate + "0000' and drfodrdtm <='" + dailyDate + "2359' " +
                            "order by drf.drfodrdtm, drf.drfodrseq ";
            DataTable dt = new DataTable();
            
            dt = conn.selectData(sql, "bit");
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt + 1;
            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colPatientName].Width = 250;
            dgvView.Columns[colHnno].Width = 80;
            dgvView.Columns[colDate].Width = 120;
            dgvView.Columns[colTime].Width = 85;
            dgvView.Columns[colBilNum].Width = 120;
            dgvView.Columns[colRcpNum].Width = 85;
            dgvView.Columns[colTotal].Width = 85;

            dgvView.Columns[coldrfodrcod].Width = 85;
            dgvView.Columns[coldtlcodnam].Width = 150;
            dgvView.Columns[colDf].Width = 85;
            dgvView.Columns[coldtrcod].Width = 70;
            dgvView.Columns[coldtrnam].Width = 150;
            dgvView.Columns[colPatTyp].Width = 50;
            dgvView.Columns[colUpdDtm].Width = 75;
            dgvView.Columns[colUidCod].Width = 140;
            dgvView.Columns[colUidNam].Width = 50;
            dgvView.Columns[colInsNam].Width = 80;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colPatientName].HeaderText = "ชื่อ-นามสกุล";
            dgvView.Columns[colHnno].HeaderText = "HN";
            dgvView.Columns[colDate].HeaderText = "Date";
            dgvView.Columns[colTime].HeaderText = "Time";
            dgvView.Columns[colBilNum].HeaderText = "Invoice";
            dgvView.Columns[colRcpNum].HeaderText = "Receipt";
            dgvView.Columns[colTotal].HeaderText = "Total";

            dgvView.Columns[coldrfodrcod].HeaderText = "code";
            dgvView.Columns[coldtlcodnam].HeaderText = "name";
            dgvView.Columns[colDf].HeaderText = "df";
            dgvView.Columns[coldtrcod].HeaderText = "dr code";
            dgvView.Columns[coldtrnam].HeaderText = "dr name";
            dgvView.Columns[colPatTyp].HeaderText = "pat typ";
            dgvView.Columns[colUpdDtm].HeaderText = "date";
            dgvView.Columns[colUidCod].HeaderText = "ur code";
            dgvView.Columns[colUidNam].HeaderText = "ur name";
            dgvView.Columns[colInsNam].HeaderText = "insur typ";

            //dgvView.Columns[colUidNam].HeaderText = "UidNam";
            //dgvView.Columns[colInsNam].HeaderText = "insur";
            //dgvView.Columns[colDf].HeaderText = "df";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
                dgvView[colPatientName, i].Value = dt.Rows[i]["PspPatNam"].ToString().Trim() + " " + dt.Rows[i]["PspSurNam"].ToString().Trim();
                dgvView[colHnno, i].Value = dt.Rows[i]["OrpChtNum"].ToString().Trim();
                //dgvView[colDate, i].Value = dt.Rows[i]["OrpBilNum"].ToString();
                //dgvView[colTime, i].Value = dt.Rows[i]["OrpRcpNum"].ToString();
                dgvView[colBilNum, i].Value = dt.Rows[i]["drfbilnum"].ToString();
                dgvView[colRcpNum, i].Value = dt.Rows[i]["drfrcpnum"].ToString();
                dgvView[colTotal, i].Value = dt.Rows[i]["orptotamt"].ToString();

                dgvView[coldrfodrcod, i].Value = dt.Rows[i]["drfodrcod"].ToString();
                dgvView[coldtlcodnam, i].Value = dt.Rows[i]["dtlcodnam"].ToString();
                dgvView[colDf, i].Value = dt.Rows[i]["drfodramt"].ToString();
                dgvView[coldtrcod, i].Value = dt.Rows[i]["drfdtrcod"].ToString();
                dgvView[coldtrnam, i].Value = dt.Rows[i]["dtrName"].ToString();
                dgvView[colPatTyp, i].Value = dt.Rows[i]["drfpattyp"].ToString();
                dgvView[colUpdDtm, i].Value = dt.Rows[i]["drfodrdtm"].ToString().Trim();
                //dgvView[colDtrNam, i].Value = dt.Rows[i]["dtrName"].ToString().Trim();
                dgvView[colUidCod, i].Value = dt.Rows[i]["drfuidcod"].ToString().Trim();
                dgvView[colUidNam, i].Value = dt.Rows[i]["UidNam"].ToString().Trim();
                //dgvView[colInsNam, i].Value = dt.Rows[i]["UidNam"].ToString().Trim();

                dgvView[colDate, i].Value = dt.Rows[i]["drfodrdtm"].ToString().Substring(0, 8);
                dgvView[colTime, i].Value = dt.Rows[i]["drfodrdtm"].ToString().Substring(8);
                dgvView[colInsNam, i].Value = dt.Rows[i]["InsCodNam"].ToString().Trim();
                //dgvView[colDf, i].Value = dt.Rows[i]["df"].ToString().Trim();
                if ((i % 2) != 0)
                {
                    dgvView.Rows[i].DefaultCellStyle.BackColor = Color.DarkKhaki;
                }
                else
                {
                    //dgvView.Rows[i].DefaultCellStyle.BackColor = Color.DarkKhaki;
                }
            }
        }

        private void dfView_Load(object sender, EventArgs e)
        {

        }

        private void dfView_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
