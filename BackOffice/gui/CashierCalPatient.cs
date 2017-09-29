using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    class CashierCalPatient:Form
    {
        int gapLine = 5;
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd51 = 700, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        int colRow = 0, colHn = 1, colVn = 2, colFullName=3, colVisitDate = 4, colDsc = 5;
        int colCnt = 6;

        BackOfficeControl boC;
        HisDB hisDB;

        Color cTxtL, cTxtE, cForm;

        MaterialSingleLineTextField txtCode;
        MaterialFlatButton btnSearch;
        MaterialLabel lb1;

        DataGridView dgvView, dgvVn;
        DateTimePicker dtpDateCal;
        //private readonly MaterialSkinManager materialSkinManager;

        public CashierCalPatient(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            cForm = this.BackColor;
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            cTxtL = txtCode.BackColor;
            cTxtE = Color.Yellow;

            setDgvHnH();
        }
        private void initCompoment()
        {
            line1 = 30 + gapLine;
            line2 = 57 + gapLine;
            line3 = 85 + gapLine;
            line4 = 105 + gapLine;
            line41 = 120 + gapLine;
            line5 = 270 + gapLine;

            lb1 = new MaterialLabel();
            lb1.Font = boC.fV1;
            lb1.Text = "ค้นหา ผู้ป่วย";
            lb1.AutoSize = true;
            Controls.Add(lb1);
            lb1.Location = new System.Drawing.Point(boC.formFirstLineX, boC.formFirstLineY + gapLine);

            txtCode = new MaterialSingleLineTextField();
            txtCode.Font = boC.fV1;
            txtCode.Text = "";
            txtCode.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txtCode);
            txtCode.Location = new System.Drawing.Point(grd1, boC.formFirstLineY + gapLine);
            txtCode.Hint = lb1.Text;
            txtCode.Enter += TxtCode_Enter;
            txtCode.Leave += TxtCode_Leave;

            btnSearch = new MaterialFlatButton();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "...";
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1 + txtCode.Width + 5, boC.formFirstLineY + gapLine);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(boC.tcW - 20, 600);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line3);
        }
        private void TxtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = cTxtL;
        }

        private void TxtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = cTxtE;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            openPatientSearch();
        }
        private void setDgvHnH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt ;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colHn].Width = 80;
            dgvView.Columns[colVn].Width = 80;
            dgvView.Columns[colFullName].Width = 80;
            dgvView.Columns[colVisitDate].Width = 100;
            dgvView.Columns[colDsc].Width = 220; 

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colHn].HeaderText = "HN";
            dgvView.Columns[colVn].HeaderText = "VN";
            dgvView.Columns[colVisitDate].HeaderText = "วันที่รักษา";
            dgvView.Columns[colDsc].HeaderText = "อาการ";
            dgvView.Columns[colFullName].HeaderText = "ชื่อ-นามสกุล";

            //dgvView.Columns[colRateID].Visible = false;
            //dgvView.Columns[colRateCode].Visible = false;
            //dgvView.Columns[colInsCod].Visible = false;

            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
        private void setDgvHn()
        {

        }
        private void openPatientSearch()
        {
            boC.DtrCode = "";
            CashierSearchPatient frm = new CashierSearchPatient(boC);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);

            if (!boC.DtrCode.Equals(""))
            {
                txtCode.Text = boC.DtrCode;
                
                //setControl();
            }
        }
    }
}
