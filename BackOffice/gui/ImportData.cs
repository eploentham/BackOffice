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
    public partial class ImportData : Form
    {
        public ConnectDB conn;
        BackOfficeControl boC;
        Boolean flagHost = false;
        int colCnt = 20, colRow = 0, colPatientName = 1, colHnno = 2, colDate = 3, colTime = 4, colBilNum = 5, colRcpNum = 6, colTotal = 7, colAskAmt = 8, colDisAmt = 9, colPayAmt = 10;
        int colCasAmt = 11, colCrdAmt = 12, colUpdDtm = 13, colAccDte = 14, colPatTyp = 15, colDtrCod = 16, colUidNam = 19, colDtrNam = 17, colUidCod = 18, colInsNam = 19, colDf = 20;

        private void btnDF_Click(object sender, EventArgs e)
        {
            dfView frm = new dfView(boC);
            frm.ShowDialog(this);
        }
        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            tabMain tabm = new tabMain();
            tabm.Show();
        }
        private void ImportData_Load(object sender, EventArgs e)
        {

        }

        private void ImportData_Resize(object sender, EventArgs e)
        {
            setResize();
        }
                
        private void initConfig()
        {
            boC = new BackOfficeControl();
            conn = new ConnectDB("bit");
            txtHostDB.Text = conn.hostDBBIT;
            txtNameDB.Text = conn.databaseDBBIT;
            txtUserDB.Text = conn.userDBBIT;
            txtPassDB.Text = conn.passDBBIT;
        }
        public ImportData()
        {
            InitializeComponent();
            
            initConfig();
            showHideHost();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            showHideHost();
        }
        private void showHideHost()
        {
            if (!flagHost)
            {
                txtHostDB.Hide();
                txtNameDB.Hide();
                txtPassDB.Hide();
                txtUserDB.Hide();
                btnTestConnect.Hide();
                flagHost = true;
            }
            else
            {
                txtHostDB.Show();
                txtNameDB.Show();
                txtPassDB.Show();
                txtUserDB.Show();
                btnTestConnect.Show();
                flagHost = false;
            }
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 150;
            //groupBox1.Width = this.Width - 50;
            //pB1.Width = this.Width - 900;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            String sql = "select pbs.PbsPatNam, pbs.PbsSurNam, orp.OrpChtNum, orp.OrpBilNum, orp.OrpRcpNum, orp.OrpTotAmt "
                            + ", orp.OrpAskAmt, orp.OrpDisAmt, orp.OrpPatAmt, orp.OrpCasAmt, orp.OrpCrdAmt, orp.OrpUpdDtm, orp.OrpAccDte "
                            + ", orp.OrpPatTyp, orp.OrpDtrCod, orp.OrpUidCod, uidm.UidNam as UidNam, uidd.UidNam as dtrName, orp.OrpInsCod, insm.InsCodNam, orp.OrpCtrSeq" +
                            ", orp.OrpOcmNum, odli.odlTotAmt as df "
                            + "From orpinf orp "
                            + "left join pbsinf pbs on orp.OrpChtNum = pbs.PbsChtNum "
                            + "left join UidMst uidm on uidm.UidCod = orp.OrpUidCod "
                            + "left join UidMst uidd on uidd.UidCod = orp.OrpDtrCod "
                            + "left join InsMst insm on insm.InsCod = orp.OrpInsCod "
                            + "left join OdlInf odli on odli.odlRcpNum = orp.OrpRcpNum  "
                            + "Where orp.OrpCtrCod = 'TOTAL' and odli.OdlIncCod = '350' and OrpUpdDtm >='"+ dailyDate + "0000' and OrpUpdDtm <='" + dailyDate+"2359'";
            DataTable dt = new DataTable();
            conn = new ConnectDB(txtHostDB.Text, txtNameDB.Text, txtUserDB.Text,txtPassDB.Text);
            dt = conn.selectData(sql,"bit");
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt + 1;
            dgvView.RowCount = dt.Rows.Count+1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colPatientName].Width = 250;
            dgvView.Columns[colHnno].Width = 80;
            dgvView.Columns[colBilNum].Width = 120;
            dgvView.Columns[colRcpNum].Width = 85;
            dgvView.Columns[colTotal].Width = 85;
            dgvView.Columns[colAskAmt].Width = 85;
            dgvView.Columns[colDisAmt].Width = 85;
            dgvView.Columns[colPayAmt].Width = 85;
            dgvView.Columns[colCasAmt].Width = 85;
            dgvView.Columns[colCrdAmt].Width = 85;
            dgvView.Columns[colUpdDtm].Width = 50;
            dgvView.Columns[colAccDte].Width = 50;
            dgvView.Columns[colPatTyp].Width = 50;
            dgvView.Columns[colDtrCod].Width = 75;
            dgvView.Columns[colDtrNam].Width = 140;
            dgvView.Columns[colUidCod].Width = 50;
            dgvView.Columns[colUidNam].Width = 80;
            dgvView.Columns[colDate].Width = 80;
            dgvView.Columns[colTime].Width = 50;
            dgvView.Columns[colInsNam].Width = 80;
            dgvView.Columns[colDf].Width = 80;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colPatientName].HeaderText = "ชื่อ-นามสกุล";
            dgvView.Columns[colHnno].HeaderText = "HN";
            dgvView.Columns[colDate].HeaderText = "Date";
            dgvView.Columns[colTime].HeaderText = "Time";
            dgvView.Columns[colBilNum].HeaderText = "Invoice";
            dgvView.Columns[colRcpNum].HeaderText = "Receipt";
            dgvView.Columns[colTotal].HeaderText = "Total";
            dgvView.Columns[colAskAmt].HeaderText = "Ask";
            dgvView.Columns[colDisAmt].HeaderText = "Discount";
            dgvView.Columns[colPayAmt].HeaderText = "NetTotal";
            dgvView.Columns[colCasAmt].HeaderText = "Cash";
            dgvView.Columns[colCrdAmt].HeaderText = "Credit";
            dgvView.Columns[colUpdDtm].HeaderText = "UpdDtm";
            dgvView.Columns[colAccDte].HeaderText = "AccDte";
            dgvView.Columns[colPatTyp].HeaderText = "PatTyp";
            dgvView.Columns[colDtrCod].HeaderText = "D code";
            dgvView.Columns[colDtrNam].HeaderText = "Doctor name";
            dgvView.Columns[colUidCod].HeaderText = "UidCod";
            dgvView.Columns[colUidNam].HeaderText = "UidNam";
            dgvView.Columns[colInsNam].HeaderText = "insur";
            dgvView.Columns[colDf].HeaderText = "df";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i+1);
                dgvView[colPatientName, i].Value = dt.Rows[i]["PbsPatNam"].ToString().Trim() + " "+ dt.Rows[i]["PbsSurNam"].ToString().Trim();
                dgvView[colHnno, i].Value = dt.Rows[i]["OrpChtNum"].ToString().Trim();
                dgvView[colBilNum, i].Value = dt.Rows[i]["OrpBilNum"].ToString();
                dgvView[colRcpNum, i].Value = dt.Rows[i]["OrpRcpNum"].ToString();
                dgvView[colTotal, i].Value = dt.Rows[i]["OrpTotAmt"].ToString();
                dgvView[colAskAmt, i].Value = dt.Rows[i]["OrpAskAmt"].ToString();
                dgvView[colDisAmt, i].Value = dt.Rows[i]["OrpDisAmt"].ToString();
                dgvView[colPayAmt, i].Value = dt.Rows[i]["OrpPatAmt"].ToString();
                dgvView[colCasAmt, i].Value = dt.Rows[i]["OrpCasAmt"].ToString();

                dgvView[colCrdAmt, i].Value = dt.Rows[i]["OrpCrdAmt"].ToString();
                dgvView[colUpdDtm, i].Value = dt.Rows[i]["OrpUpdDtm"].ToString();
                dgvView[colAccDte, i].Value = dt.Rows[i]["OrpAccDte"].ToString();
                dgvView[colPatTyp, i].Value = dt.Rows[i]["OrpPatTyp"].ToString();
                dgvView[colDtrCod, i].Value = dt.Rows[i]["OrpDtrCod"].ToString().Trim();
                dgvView[colDtrNam, i].Value = dt.Rows[i]["dtrName"].ToString().Trim();
                dgvView[colUidCod, i].Value = dt.Rows[i]["OrpUidCod"].ToString().Trim();
                dgvView[colUidNam, i].Value = dt.Rows[i]["UidNam"].ToString().Trim();
                dgvView[colUidNam, i].Value = dt.Rows[i]["UidNam"].ToString().Trim();

                dgvView[colDate, i].Value = dt.Rows[i]["OrpUpdDtm"].ToString().Substring(0,8);
                dgvView[colTime, i].Value = dt.Rows[i]["OrpUpdDtm"].ToString().Substring(8);
                dgvView[colInsNam, i].Value = dt.Rows[i]["InsCodNam"].ToString().Trim();
                dgvView[colDf, i].Value = dt.Rows[i]["df"].ToString().Trim();
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
    }
}
