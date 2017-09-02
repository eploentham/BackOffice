using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    class DfView1:Form
    {
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        int colRow = 0, colDtrCod = 1, colDtrName = 2, colTypeName = 3, colCatName = 4, colMedicalField = 5;
        int colCnt = 6;

        Label lb1, lb2;
        TextBox txtCode;
        DataGridView dgvView;
        Button btnSearch;

        BackOfficeControl boC;
        ConnectDB conn;

        public DfView1(BackOfficeControl boc)
        {            
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            conn = new ConnectDB("bit");
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();            
            this.Size = new System.Drawing.Size(800, 500);            
            //this.Location = new System.Drawing.Point(boC.formFirstLineX-20, line1-20);
            this.Opacity = 0.8;
            this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
            setDgvH();
        }
        private void initCompoment()
        {
            lb1 = new Label();
            lb1.Font = boC.fV1;
            lb1.Text = "รหัสแพทย์";
            lb1.AutoSize = true;
            Controls.Add(lb1);
            lb1.Location = new System.Drawing.Point(boC.formFirstLineX, boC.formFirstLineY);

            txtCode = new TextBox();
            txtCode.Font = boC.fV1;
            txtCode.Text = "";
            txtCode.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txtCode);
            txtCode.Location = new System.Drawing.Point(grd1, boC.formFirstLineY);

            btnSearch = new Button();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "...";
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1 + txtCode.Width + 5, boC.formFirstLineY);
            //btnSearch.Click += new EventHandler(btnSearch_Click);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(760, 460);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line1);
        }
        private void setDgvH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colDtrCod].Width = 80;
            dgvView.Columns[colDtrName].Width = 80;
            dgvView.Columns[colTypeName].Width = 500;
            dgvView.Columns[colCatName].Width = 220;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colDtrCod].HeaderText = "รหัสหลัก";
            dgvView.Columns[colDtrName].HeaderText = "รหัสรอง";
            dgvView.Columns[colTypeName].HeaderText = "รายการ";
            dgvView.Columns[colCatName].HeaderText = "insur name";            

            DataGridViewComboBoxColumn typTime = new DataGridViewComboBoxColumn();
            var list11 = new List<string>() { "ในเวลา", "นอกเวลา" };
            typTime.DataSource = list11;
            typTime.HeaderText = "ประเภทค่าแพทย์";
            typTime.DataPropertyName = "Money";
            dgvView.Columns.AddRange(typTime);

            DataGridViewComboBoxColumn RateTyp = new DataGridViewComboBoxColumn();
            var list12 = new List<string>() { "%", "บาท", "ตามแพทย์ เขียนdf" };
            RateTyp.DataSource = list12;
            RateTyp.HeaderText = "Rate Type";
            RateTyp.DataPropertyName = "Money";
            RateTyp.Width = 150;
            dgvView.Columns.AddRange(RateTyp);

            DataGridViewTextBoxColumn rate = new DataGridViewTextBoxColumn();
            rate.HeaderText = "Rate";
            dgvView.Columns.AddRange(rate);

            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
    }
}
