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
    class DfAdd : Form
    {
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        int colCnt = 25, colRow = 0, colPatientName = 1, colHnno = 2, colDate = 3, colTime = 4, colBilNum = 5, colRcpNum = 6, colTotal = 7, coldrfodrcod = 8, coldtlcodnam = 9, colDf = 10;
        int coldtrcod = 11, coldtrnam = 12, colUpdDtm = 14, colPatTyp = 13, colUidNam = 16, colUidCod = 15, colInsNam = 17, colDfId = 18, colDrfSeqNum = 19, colActive=20;
        int colItmCod = 21, colItmAstCod = 22, colOdrSeq=23, colOdrOcmNum=24, colDF=25;

        DateTimePicker dtpDf;
        DataGridView dgvView, dgvDf;
        Label lb1, lb2, lb3;
        TextBox txtSearch;
        Button btnSearch, btnSave, btnGen;
        ComboBox cboDoctor;
        CheckBox chkOR;

        BackOfficeControl boC;
        ConnectDB conn;
        public DfAdd(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            conn = new ConnectDB("bit");
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            setDgvViewH();
        }
        private void initCompoment()
        {
            lb1 = new Label();
            lb1.Font = boC.fV1;
            lb1.Text = "วันที่";
            lb1.AutoSize = true;
            Controls.Add(lb1);
            lb1.Location = new System.Drawing.Point(boC.formFirstLineX, boC.formFirstLineY);

            dtpDf = new DateTimePicker();
            dtpDf.Font = boC.fV1;
            Controls.Add(dtpDf);
            dtpDf.Location = new System.Drawing.Point(grd1, boC.formFirstLineY);
            dtpDf.Size = new System.Drawing.Size(100, ControlHeight);
            dtpDf.Format = DateTimePickerFormat.Short;

            btnSearch = new Button();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "...";
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd2, boC.formFirstLineY);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            lb2 = new Label();
            lb2.Font = boC.fV1;
            lb2.Text = "ค้นหา";
            lb2.AutoSize = true;
            Controls.Add(lb2);
            lb2.Location = new System.Drawing.Point(grd2, boC.formFirstLineY);

            txtSearch = new TextBox();
            txtSearch.Font = boC.fV1;
            txtSearch.Text = "";
            txtSearch.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txtSearch);
            txtSearch.Location = new System.Drawing.Point(grd3, boC.formFirstLineY);

            lb3 = new Label();
            lb3.Font = boC.fV1;
            lb3.Text = "เลือกแพทย์";
            lb3.AutoSize = true;
            Controls.Add(lb3);
            lb3.Location = new System.Drawing.Point(boC.formFirstLineX, line1);

            cboDoctor = new ComboBox();
            cboDoctor.Font = boC.fV1;
            cboDoctor.Text = "";
            cboDoctor.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(cboDoctor);
            cboDoctor.Location = new System.Drawing.Point(grd1, line1);

            chkOR = new CheckBox();
            chkOR.Font = boC.fV1;
            chkOR.Text = "เฉพาะรายการผ่าตัด";
            chkOR.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(chkOR);
            chkOR.Location = new System.Drawing.Point(grd3, line1);

            btnSave = new Button();
            btnSave.Font = boC.fV1;
            btnSave.Text = "บันทึก ค่าแพทย์";
            btnSave.Size = new System.Drawing.Size(100, ControlHeight + 7);
            Controls.Add(btnSave);
            btnSave.Location = new System.Drawing.Point(grd1, line3);
            //btnGen.Click += new EventHandler(btnGen_Click);

            btnGen = new Button();
            btnGen.Font = boC.fV1;
            btnGen.Text = "gen ค่าแพทย์";
            btnGen.Size = new System.Drawing.Size(100, ControlHeight + 7);
            Controls.Add(btnGen);
            btnGen.Location = new System.Drawing.Point(grd3, line3);
            //btnGen.Click += new EventHandler(btnGen_Click);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(boC.tcW - 20, boC.tcH - 160);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line41);

            dgvDf = new DataGridView();
            dgvDf.Font = boC.fV1;
            dgvDf.Size = new System.Drawing.Size(600, 110);
            Controls.Add(dgvDf);
            dgvDf.Location = new System.Drawing.Point(grd5, boC.formFirstLineY);

        }
        private void setDgvViewH()
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
            dgvView.Columns[colDfId].HeaderText = "colDfId";
            dgvView.Columns[colDrfSeqNum].HeaderText = "colDrfSeqNum";
            dgvView.Columns[colDfId].Visible = false;
            dgvView.Columns[colDrfSeqNum].Visible = false;
            dgvView.Columns[colOdrSeq].Visible = false;
            dgvView.Columns[colOdrOcmNum].Visible = false;
            dgvView.Columns[colItmAstCod].Visible = false;
            dgvView.Columns[colItmCod].Visible = false;
            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
        private void getDataDf()
        {
            DataTable dt = new DataTable();
            String dailyDate = "";
            dailyDate = dtpDf.Value.Year.ToString() + dtpDf.Value.ToString("MMdd");

            dt = boC.selectDtrImport(dailyDate);
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
                dgvView[coldtrnam, i].Value = dt.Rows[i]["dtrNam"].ToString();
                dgvView[colPatTyp, i].Value = dt.Rows[i]["drfpattyp"].ToString();
                dgvView[colUpdDtm, i].Value = dt.Rows[i]["drfodrdtm"].ToString().Trim();
                dgvView[colItmAstCod, i].Value = dt.Rows[i]["odrastcod"].ToString().Trim();
                dgvView[colUidCod, i].Value = dt.Rows[i]["drfuidcod"].ToString().Trim();
                dgvView[colUidNam, i].Value = dt.Rows[i]["UidNam"].ToString().Trim();
                dgvView[colInsNam, i].Value = dt.Rows[i]["UidNam"].ToString().Trim();

                dgvView[colDate, i].Value = dt.Rows[i]["drfodrdtm"].ToString().Substring(0, 8);
                dgvView[colTime, i].Value = dt.Rows[i]["drfodrdtm"].ToString().Substring(8);
                dgvView[colItmCod, i].Value = dt.Rows[i]["odritmcod"].ToString().Trim();
                dgvView[colOdrSeq, i].Value = dt.Rows[i]["odrseq"].ToString().Trim();
                dgvView[colOdrOcmNum, i].Value = dt.Rows[i]["odrocmnum"].ToString().Trim();

                dgvView[colActive, i].Value = "1";
                dgvView[colDfId, i].Value = "-";
                dgvView[colDrfSeqNum, i].Value = dt.Rows[i]["drfseqnum"].ToString().Trim();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getDataDf();
        }
        private void saveDf()
        {
            for (int i = 0; i < dgvView.RowCount; i++)
            {
                if (dgvView[colHnno, i].Value == null)
                {
                    continue;
                }
                DfTDoctor df = new DfTDoctor();
                df.Active = dgvView[colActive, i].Value.ToString();
                df.DfId = dgvView[colDfId, i].Value.ToString();
                df.DrfBilNum = dgvView[colBilNum, i].Value.ToString();
                df.DrfCalNum = "";
                df.DrfCtrCodv = "";
                df.DrfCtrSeq = "";
                df.DrfCurStt = "";
                df.DrfDivYon = "";
                df.DrfGrpSeq = "";
                df.DrfIncCod = "";
                df.DrfOcmNum = dgvView[colOdrOcmNum, i].Value.ToString();
                df.DrfOdrAmt = dgvView[colTotal, i].Value.ToString();
                df.drfodrcod = dgvView[coldrfodrcod, i].Value.ToString();
                df.DrfOdrDtm = "";
                df.DrfOdrSeq = dgvView[colOdrSeq, i].Value.ToString();
                df.DrfOspTyp = "";
                df.DrfPatTyp = dgvView[colPatTyp, i].Value.ToString();
                df.DrfRcpNum = dgvView[colRcpNum, i].Value.ToString();
                df.DrfRcpSeq = "";                
                df.DrfUidCod = dgvView[colUidCod, i].Value.ToString();
                df.DrfUpdDtm = dgvView[colUpdDtm, i].Value.ToString();
                df.DtrCode = dgvView[coldtrcod, i].Value.ToString();
                df.InsCodNam = dgvView[colInsNam, i].Value.ToString();
                df.DrfSeqNum = dgvView[colDrfSeqNum, i].Value.ToString();
                df.ItmAstCod = dgvView[colItmAstCod, i].Value.ToString();
                df.ItmCod = dgvView[colItmCod, i].Value.ToString();
                df.ItmKorNam = dgvView[coldtlcodnam, i].Value.ToString();
                df.ItmSrvOpd = "";
                df.MonthId = "";
                df.OrpChtNum = dgvView[colHnno, i].Value.ToString();
                df.orptotamt = dgvView[colTotal, i].Value.ToString();
                df.PspPatNam = dgvView[colPatientName, i].Value.ToString();
                df.PspSurNam = dgvView[colPatientName, i].Value.ToString();
                df.StatusApprove = "";
                df.StatusDoc = "";
                df.YearId = "";
                df.df = "";

            }
        }
    }
}
