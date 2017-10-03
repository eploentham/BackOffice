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
    class ImportHos:Form
    {
        int gapLine = 5;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 30, lineGap = 5;

        Label lb1 = new Label();
        Label lb2 = new Label();
        DateTimePicker dtpDailyDate;
        MaterialFlatButton btnSearch, btnImport, btnExcel, btnImportMst, btnConvertDemo;
        DataGridView dgvView;
        ProgressBar pb1;

        BackOfficeControl boC;
        ConnectDB conn;

        Color cTxtL, cTxtE, cForm;

        int colCnt = 20, colRow = 0, colPatientName = 1, colHnno = 2, colDate = 3, colTime = 4, colBilNum = 5, colRcpNum = 6, colTotal = 7, colAskAmt = 8, colDisAmt = 9, colPayAmt = 10;
        int colCasAmt = 11, colCrdAmt = 12, colUpdDtm = 13, colAccDte = 14, colPatTyp = 15, colDtrCod = 16, colUidNam = 19, colDtrNam = 17, colUidCod = 18, colInsNam = 19, colDf = 20;
        public ImportHos(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            cForm = this.BackColor;
            conn = new ConnectDB("bit", boC.initC);
            initConfig();
        }
        private void initConfig()
        {
            line1 = 30 + gapLine;
            line2 = 57 + gapLine;
            line3 = 85 + gapLine;
            line4 = 105 + gapLine;
            line41 = 120 + gapLine;
            line5 = 270 + gapLine;

            lb1 = new Label();
            lb1.Text = "วันที่";
            lb1.AutoSize = true;
            Controls.Add(lb1);
            lb1.Location = new Point(5, 5);

            dtpDailyDate = new DateTimePicker();
            Controls.Add(dtpDailyDate);
            dtpDailyDate.Location = new Point(100, 5);

            btnSearch = new MaterialFlatButton();
            btnSearch.Text = "ดึงข้อมูล";
            Controls.Add(btnSearch);
            btnSearch.Location = new Point(330, 5);
            btnSearch.Size = new System.Drawing.Size(100, ControlHeight);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            btnImport = new MaterialFlatButton();
            btnImport.Text = "นำเข้าข้อมูลประจำวัน";
            Controls.Add(btnImport);
            btnImport.Location = new Point(330+btnSearch.Width+80, 5);
            btnImport.Size = new System.Drawing.Size(100, ControlHeight);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnImport.Click += new EventHandler(btnImport_Click);

            btnImportMst = new MaterialFlatButton();
            btnImportMst.Text = "นำเข้าข้อมูล Master";
            Controls.Add(btnImportMst);
            btnImportMst.Location = new Point(330 + btnSearch.Width + btnImport.Width + btnImport.Width , 5);
            btnImportMst.Size = new System.Drawing.Size(100, ControlHeight);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnImportMst.Click += new EventHandler(btnImportMst_Click);

            btnExcel = new MaterialFlatButton();
            btnExcel.Text = "Export Excel";
            Controls.Add(btnExcel);
            btnExcel.Location = new Point(330 + btnSearch.Width + 80 + btnImport.Width + 80 + btnImportMst.Width + 80, 5);
            btnExcel.Size = new System.Drawing.Size(100, ControlHeight);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnExcel.Click += new EventHandler(btnExcel_Click);

            btnConvertDemo = new MaterialFlatButton();
            btnConvertDemo.Text = "Convert to Demo";
            Controls.Add(btnConvertDemo);
            btnConvertDemo.Location = new Point(330 + btnSearch.Width + 80 + btnImport.Width + 80 + btnImportMst.Width + 80 + btnExcel.Width + 80, 5);
            btnConvertDemo.Size = new System.Drawing.Size(100, ControlHeight);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnConvertDemo.Click += new EventHandler(btnConvertDemo_Click);

            lb2 = new Label();
            lb2.Text = "";
            lb2.AutoSize = true;
            Controls.Add(lb2);
            lb2.Location = new Point(330 + btnSearch.Width + 80 + btnImport.Width + 80 + btnImportMst.Width + 80 + btnExcel.Width + 80+ btnConvertDemo.Width+5, 5);

            dgvView = new DataGridView();
            dgvView.Width = boC.tcW - boC.tcWMinus;
            dgvView.Height = boC.tcH - boC.tcHMinus-10;
            dgvView.Location = new Point(5, lb1.Top + 40);
            Controls.Add(dgvView);
            setDgvH();
        }
        private void setDgvH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt + 1;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.ColumnCount = colCnt + 1;
            //dgvView.RowCount = dt.Rows.Count + 1;
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
            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportData();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelData();
        }
        private void btnImportMst_Click(object sender, EventArgs e)
        {
            ImportDataMst();
        }
        private void btnConvertDemo_Click(object sender, EventArgs e)
        {
            ConvertDataDemo();
        }
        private void ImportData()
        {
            btnImport.Enabled = false;
            String dailyDate = "";
            dailyDate = dtpDailyDate.Value.Year.ToString() + dtpDailyDate.Value.ToString("MMdd");
            boC.iBITDB.ImportOrpInf(dailyDate);

            boC.iBITDB.ImportPbsInf(dailyDate);

            boC.iBITDB.ImportOdlInf(dailyDate);

            boC.iBITDB.ImportDrfRcp(dailyDate);

            boC.iBITDB.ImportPspInf(dailyDate);

            boC.iBITDB.ImportOdrInf(dailyDate);            

            btnImport.Enabled = true;
        }
        private void ImportDataMst()
        {
            btnImport.Enabled = false;

            boC.iBITDB.ImportDtlMst();

            boC.iBITDB.ImportInsMst();

            boC.iBITDB.ImportUidMst();

            boC.iBITDB.ImportDepMst();

            boC.iBITDB.ImportItmMst();

            boC.iBITDB.ImportGrpMst();

            boC.iBITDB.ImportGrdMst();

            boC.iBITDB.ImportFeeMst();

            btnImport.Enabled = true;
        }
        private void ConvertDataDemo()
        {
            boC.iBITDB.DeleteDatabase("BITHIS", lb2, this);
        }
        private void ExcelData()
        {
            //Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            //excelapp.Visible = false;
            //Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //for (int i = 1; i < dgvAdd.Rows.Count; i++)
            //{

            //}
        }
        private void getData()
        {
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
                            + "Where orp.OrpCtrCod = 'TOTAL' and odli.OdlIncCod = '350' and OrpUpdDtm >='" + dailyDate + "0000' and OrpUpdDtm <='" + dailyDate + "2359'";
            DataTable dt = new DataTable();
            //conn = new ConnectDB(txtHostDB.Text, txtNameDB.Text, txtUserDB.Text, txtPassDB.Text);
            dt = conn.selectData(sql, "bit");
            dgvView.Rows.Clear();
            dgvView.RowCount = dt.Rows.Count + 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
                dgvView[colPatientName, i].Value = dt.Rows[i]["PbsPatNam"].ToString().Trim() + " " + dt.Rows[i]["PbsSurNam"].ToString().Trim();
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

                dgvView[colDate, i].Value = dt.Rows[i]["OrpUpdDtm"].ToString().Substring(0, 8);
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
