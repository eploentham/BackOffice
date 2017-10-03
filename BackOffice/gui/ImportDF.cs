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
    class ImportDF : Form
    {
        int gapLine = 5;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 30, lineGap = 5;

        Label lb1 = new Label();
        DateTimePicker dtpDailyDate;
        MaterialFlatButton btnSearch, btnExcel;
        DataGridView dgvView;

        BackOfficeControl boC;
        ConnectDB conn;

        int colCnt = 22, colRow = 0, colPatientName = 1, colHnno = 2, colDate = 3, colTime = 4, colBilNum = 5, colRcpNum = 6, colTotal = 7, coldrfodrcod = 8, coldtlcodnam = 9, colDf = 10;
        int coldtrcod = 11, coldtrnam = 12, colUpdDtm = 14, colPatTyp = 13, colUidNam = 16, colUidCod = 15, colInsNam = 17, colItmCod=18, colItmAstCod=19, colodrocmnum=20, colodrseq=21, colodrdtm=22;


        private void ImportDF_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ImportDF
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ImportDF";
            this.Load += new System.EventHandler(this.ImportDF_Load);
            this.ResumeLayout(false);

        }

        
        public ImportDF(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            conn = new ConnectDB("bit", boc.initC);
            initConfig();

        }
        private void initConfig()
        {
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
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            btnExcel = new MaterialFlatButton();
            btnExcel.Text = "Export Excel";
            Controls.Add(btnExcel);
            btnExcel.Location = new Point(330 + btnSearch.Width + 80 + btnSearch.Width + 80, 5);
            btnExcel.Size = new System.Drawing.Size(100, ControlHeight);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnExcel.Click += new EventHandler(btnExcel_Click);

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
            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelData();
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
            String sql = "select psp.PspPatNam, psp.PspSurNam, orp.OrpChtNum, drf.drfodrcod, drf.drfdtrcod, drf.drfocmnum, drf.drfpattyp, drf.drfodramt, drf.drfodrdtm, drf.drfinccod, drf.drfbilnum  " +
                            " , drf.drfuidcod,drf.drfodrcod, uidm.UidNam as UidNam, uidd.UidNam as dtrName, drf.drfrcpnum, drf.drfrcpnum, drf.drfuidcod  " +
                            ", insm.InsCodNam, orp.orptotamt, drf.drfodrdtm  , itmm.ItmKorNam, odr.OdrItmCod, odr.OdrastCod, odr.odrocmnum, odr.odrseq, odr.odrdtm  "
                            + "From drfrcp drf "
                            + "left join OrpInf orp on drf.DrfRcpNum = orp.OrpRcpNum  and orp.Orpocmnum = drf.drfocmnum   "
                            + "left join OdrInf odr on odr.OdrOcmNum = orp.OrpOcmNum  "
                            + "left join UidMst uidm on uidm.UidCod = drf.drfuidcod   "
                            + "left join UidMst uidd on uidd.UidCod = drf.drfdtrcod  "
                            + "left join pspinf psp on orp.OrpChtNum = psp.PspChtNum    "
                            + "left join InsMst insm on insm.InsCod = orp.OrpInsCod  "
                            + "inner join ItmMst itmm on itmm.ItmCod = odr.OdrItmCod and itmm.ItmAstCod = odr.OdrAstCod "
                            + "Where  orp.OrpCtrCod = 'TOTAL' and drfodrdtm >='" + dailyDate + "0000' and drfodrdtm <='" + dailyDate + "2359' and itmm.ItmSrvOpd = '11' " +
                            "order by drf.drfodrdtm, drf.drfodrseq ";
            DataTable dt = new DataTable();

            dt = conn.selectData(sql, "bit");
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt + 1;
            dgvView.RowCount = dt.Rows.Count + 1;

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
                dgvView[coldtlcodnam, i].Value = dt.Rows[i]["ItmKorNam"].ToString();
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
                dgvView[colItmCod, i].Value = dt.Rows[i]["odritmcod"].ToString().Trim();
                dgvView[colItmAstCod, i].Value = dt.Rows[i]["odrastcod"].ToString().Trim();

                dgvView[colodrocmnum, i].Value = dt.Rows[i]["odrocmnum"].ToString().Trim();
                dgvView[colodrseq, i].Value = dt.Rows[i]["odrseq"].ToString().Trim();
                dgvView[colodrdtm, i].Value = dt.Rows[i]["odrdtm"].ToString().Trim();
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
        private void ExcelData()
        {
            String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //worksheet.Cells[1, 1] = txtDtrCode.Text;
            //worksheet.Cells[1, 2] = txtNameT.Text;
            //worksheet.Cells[1, 3] = txtSNameT.Text;
            for (int i = 0; i < dgvView.Rows.Count; i++)
            {
                try
                {
                    if (dgvView[colRow, i].Value == null)
                    {
                        continue;
                    }
                    worksheet.Cells[i + 3 + 1, colRow + 1] = dgvView[colRow, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colPatientName + 1] = dgvView[colPatientName, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colHnno + 1] = dgvView[colHnno, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colBilNum + 1] = dgvView[colBilNum, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colRcpNum + 1] = dgvView[colRcpNum, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colTotal + 1] = dgvView[colTotal, i].Value.ToString();

                    worksheet.Cells[i + 3 + 1, coldrfodrcod + 1] = dgvView[coldrfodrcod, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colItmCod + 1] = dgvView[colItmCod, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colItmAstCod + 1] = dgvView[colItmAstCod, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, coldtlcodnam + 1] = dgvView[coldtlcodnam, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colDf + 1] = dgvView[colDf, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, coldtrcod + 1] = dgvView[coldtrcod, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, coldtrnam + 1] = dgvView[coldtrnam, i].Value.ToString();

                    worksheet.Cells[i + 3 + 1, colodrocmnum + 1] = dgvView[colodrocmnum, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colodrseq + 1] = dgvView[colodrseq, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colodrdtm + 1] = dgvView[colodrdtm, i].Value.ToString();
                    //err = "001 " + dgvView[colPatientHnno, i].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
                }
                //if (dgvView[colPatientHnno, i].Value == null)
                //{
                //    continue;
                //}
            }
            excelapp.UserControl = true;
            excelapp.Visible = true;
        }
    }
}
