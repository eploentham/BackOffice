using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    class DfAdd:Form
    {
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

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
            setDgvH();
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

            lb2 = new Label();
            lb2.Font = boC.fV1;
            lb2.Text = "ค้าหา";
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
        private void setDgvH()
        {

        }
    }
}
