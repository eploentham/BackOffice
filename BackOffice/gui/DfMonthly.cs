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
    class DfMonthly : Form
    {
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd51=700, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        int colCnt = 7, colRow = 0, colDtrCode = 1, colDtrName = 2, colDf=3, colOnHand=4, colAmt=5, colPay=6, colOwe=7;

        BackOfficeControl boC;
        ConnectDB conn;

        Label lb1, lb2, lb3, lb4, lb5;
        ComboBox cboDoctor, cboMonth, cboYear;
        DataGridView dgvView, dgvDf;
        Button btnSearch, btnSave, btnGen;

        ComboBoxItem cboI;

        Boolean pageLoad = false;
        public DfMonthly(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            conn = new ConnectDB("bit");
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            cboI = new ComboBoxItem();
            boC.setCboMonth(cboMonth);
            boC.setCboYear(cboYear);
            setDgvH();
        }
        private void initCompoment()
        {
            lb1 = new Label();
            lb1.Font = boC.fV1;
            lb1.Text = "ประจำเดือน";
            lb1.AutoSize = true;
            Controls.Add(lb1);
            lb1.Location = new System.Drawing.Point(boC.formFirstLineX, boC.formFirstLineY);

            cboMonth = new ComboBox();
            cboMonth.Font = boC.fV1;
            cboMonth.Text = "";
            cboMonth.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(cboMonth);
            cboMonth.Location = new System.Drawing.Point(grd1, boC.formFirstLineY);

            lb2 = new Label();
            lb2.Font = boC.fV1;
            lb2.Text = "ประจำปี";
            lb2.AutoSize = true;
            Controls.Add(lb2);
            lb2.Location = new System.Drawing.Point(grd2, boC.formFirstLineY);

            cboYear = new ComboBox();
            cboYear.Font = boC.fV1;
            cboYear.Text = "";
            cboYear.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(cboYear);
            cboYear.Location = new System.Drawing.Point(grd3, boC.formFirstLineY);

            btnSearch = new Button();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "ดึงข้อมูล";
            btnSearch.Size = new System.Drawing.Size(80, ControlHeight+5);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd4, boC.formFirstLineY);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            btnSave = new Button();
            btnSave.Font = boC.fV1;
            btnSave.Text = "บันทึกช้อมูล";
            btnSave.Size = new System.Drawing.Size(80, ControlHeight + 5);
            Controls.Add(btnSave);
            btnSave.Location = new System.Drawing.Point(grd51, boC.formFirstLineY);
            btnSave.Click += new EventHandler(btnSave_Click);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(boC.tcW - 20, boC.tcH - 122);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line3);
        }
        private void setDgvH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colDtrCode].Width = 80;
            dgvView.Columns[colDtrName].Width = 250;
            dgvView.Columns[colDf].Width = 90;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colDtrCode].HeaderText = "รหัส";
            dgvView.Columns[colDtrName].HeaderText = "ชื่อ-นามสกุล แพทย์";
            dgvView.Columns[colDf].HeaderText = "df";
            dgvView.Columns[colOnHand].HeaderText = "ยอดยกมา";
            dgvView.Columns[colAmt].HeaderText = "รวม";
            dgvView.Columns[colPay].HeaderText = "ทำจ่าย";
            dgvView.Columns[colOwe].HeaderText = "ค้างชำระ";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //getDataDf();
            dt = boC.dfDB.selectDfMonthly();
            dgvView.Rows.Clear();            
            dgvView.RowCount = dt.Rows.Count + 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
                dgvView[colDtrCode, i].Value = dt.Rows[i]["dtr_code"].ToString().Trim();
                dgvView[colDtrName, i].Value = dt.Rows[i]["dtr_name"].ToString().Trim();
                dgvView[colDf, i].Value = dt.Rows[i]["df"].ToString().Trim();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //getDataDf();
        }
    }
}
