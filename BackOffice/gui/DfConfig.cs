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
    class DfConfig:Form
    {
        int gapLine = 5;
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd51=700, grd6=820, grd7=900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3=85, line4=105, line41=120, line5=270, ControlHeight=21, lineGap=5;

        int colRow = 0, colItmCod = 1, colItmAstCod = 2, colDsc = 3, colInsNam = 4, colTypTime = 5, colRateID = 6, colRateCode = 7, colInsCod=8, colRateTyp=9, colRate=10;
        int colCnt = 9;
        Label lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10, lb11, lb12, lb13,lb14, lb15, lb16, lb17, lb18, lb19;
        //TextBox txtDtrCode, txtTaxID, txtAddr, txtPhone, txtPrnNo, txtAppointmentCnt, txtBankNo, txtSalaryMin;
        MaterialSingleLineTextField txtCode, txtNameT, txtNameE, txtSNameT, txtSNameE, txtDtrCode, txtTaxID, txtAddr, txtPhone, txtPrnNo, txtAppointmentCnt, txtBankNo, txtSalaryMin;
        ComboBox cboPNameT, cboPNameE, cboDtrTyp, cboDtrCat, cboMedicalField;
        GroupBox gb1, gb2;
        DateTimePicker dtpWorkStart;
        //Button btnSearch, btnGen, btnCopy, btnSave ;
        MaterialFlatButton btnSearch, btnGen, btnCopy, btnSave,btnExcel;
        
        DataGridView dgvView;

        ComboBoxItem cboI;

        BackOfficeControl boC;

        Color cTxtL, cTxtE, cForm;

        private readonly MaterialSkinManager materialSkinManager;

        //ConnectDB conn;

        Doctor dtr;
        public DfConfig(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            cForm = this.BackColor;
            //conn = new ConnectDB("bit");
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            dtr = new Doctor();
            cboI = new ComboBoxItem();
            cTxtL = txtCode.BackColor;
            cTxtE = Color.Yellow;

            

            setDgvH();
            cboPNameT = boC.getCboDtrTitleT(cboPNameT);
            cboPNameE = boC.getCboDtrTitleE(cboPNameE);
            cboMedicalField = boC.getCboMedicalField(cboMedicalField);
            cboDtrCat = boC.getCboDtrCat(cboDtrCat);
            cboDtrTyp = boC.getCboDtrTyp(cboDtrTyp);
        }
        private void initCompoment()
        {
            //btnExcel.Size = new System.Drawing.Size(75, 23);
            //btnSearch.TabIndex = 0;
            //btnSearch.UseVisualStyleBackColor = true;
            //groupBox1.Location = new System.Drawing.Point(5, 4);

            //SELECT* FROM bithis.depmst1 where depgrpcod in ('GS', 'OBGY', 'PED', 'MED')
            line1 = 30 + gapLine;
            line2 = 57 + gapLine;
            line3 = 85 + gapLine;
            line4 = 105 + gapLine;
            line41 = 120 + gapLine;
            line5 = 270 + gapLine;

            lb1 = new Label();
            lb1.Font = boC.fV1;
            lb1.Text = "รหัสแพทย์";
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
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight );
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1+txtCode.Width+5, boC.formFirstLineY + gapLine);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            lb2 = new Label();
            lb2.Font = boC.fV1;
            lb2.Text = "คำนำหน้า";//ชื่อ-นามสกุล แพทย์
            lb2.AutoSize = true;
            Controls.Add(lb2);
            lb2.Location = new System.Drawing.Point(boC.formFirstLineX, line1);

            cboPNameT = new ComboBox();
            cboPNameT.Font = boC.fV1;
            cboPNameT.Text = "";
            cboPNameT.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(cboPNameT);
            cboPNameT.Location = new System.Drawing.Point(grd1, line1);
            cboPNameT.BackColor = cForm;

            lb4 = new Label();
            lb4.Font = boC.fV1;
            lb4.Text = "ชื่อ";//ชื่อ-นามสกุล แพทย์
            lb4.AutoSize = true;
            Controls.Add(lb4);
            lb4.Location = new System.Drawing.Point(grd2, line1);

            txtNameT = new MaterialSingleLineTextField();
            txtNameT.Font = boC.fV1;
            txtNameT.Text = "";
            txtNameT.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtNameT);
            txtNameT.Location = new System.Drawing.Point(grd3, line1);
            txtNameT.Hint = lb4.Text+" ภาษาไทย";
            txtNameT.Enter += TxtNameT_Enter;
            txtNameT.Leave += TxtNameT_Leave;

            lb5 = new Label();
            lb5.Font = boC.fV1;
            lb5.Text = "นามสกุล";//ชื่อ-นามสกุล แพทย์
            lb5.AutoSize = true;
            Controls.Add(lb5);
            lb5.Location = new System.Drawing.Point(grd4, line1);

            txtSNameT = new MaterialSingleLineTextField();
            txtSNameT.Font = boC.fV1;
            txtSNameT.Text = "";
            txtSNameT.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtSNameT);
            txtSNameT.Location = new System.Drawing.Point(grd5, line1);
            txtSNameT.Hint = lb5.Text + " ภาษาไทย";
            txtSNameT.Enter += TxtSNameT_Enter;
            txtSNameT.Leave += TxtSNameT_Leave;

            lb3 = new Label();
            lb3.Font = boC.fV1;
            lb3.Text = "Title";
            lb3.AutoSize = true;
            Controls.Add(lb3);
            lb3.Location = new System.Drawing.Point(boC.formFirstLineX, line2);

            cboPNameE = new ComboBox();
            cboPNameE.Font = boC.fV1;
            cboPNameE.Text = "";
            cboPNameE.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(cboPNameE);
            cboPNameE.Location = new System.Drawing.Point(grd1, line2);
            cboPNameE.BackColor = cForm;

            lb6 = new Label();
            lb6.Font = boC.fV1;
            lb6.Text = "Name";//ชื่อ-นามสกุล แพทย์
            lb6.AutoSize = true;
            Controls.Add(lb6);
            lb6.Location = new System.Drawing.Point(grd2, line2);

            txtNameE = new MaterialSingleLineTextField();
            txtNameE.Font = boC.fV1;
            txtNameE.Text = "";
            txtNameE.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtNameE);
            txtNameE.Location = new System.Drawing.Point(grd3, line2);
            txtNameE.Hint = " ชื่อภาษาอังกฤษ";
            txtNameE.Enter += TxtNameE_Enter;
            txtNameE.Leave += TxtNameE_Leave;

            lb7 = new Label();
            lb7.Font = boC.fV1;
            lb7.Text = "Sur name";//ชื่อ-นามสกุล แพทย์
            lb7.AutoSize = true;
            Controls.Add(lb7);
            lb7.Location = new System.Drawing.Point(grd4, line2);

            txtSNameE = new MaterialSingleLineTextField();
            txtSNameE.Font = boC.fV1;
            txtSNameE.Text = "";
            txtSNameE.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtSNameE);
            txtSNameE.Location = new System.Drawing.Point(grd5, line2);
            txtSNameE.Hint = " นามสกุลภาษาอังกฤษ";
            txtSNameE.Enter += TxtSNameE_Enter;
            txtSNameE.Leave += TxtSNameE_Leave;

            gb1 = new GroupBox();
            gb1.Text = "ข้อมูลทั่วไป";
            gb1.Font = boC.fV1;
            gb1.Size = new System.Drawing.Size(boC.tcW - 20, 170);
            Controls.Add(gb1);
            gb1.Location = new System.Drawing.Point(boC.formFirstLineX, line4-20);

            lb8 = new Label();
            lb8.Font = boC.fV1;
            lb8.Text = "วันที่เข้างาน";
            lb8.AutoSize = true;
            gb1.Controls.Add(lb8);
            lb8.Location = new System.Drawing.Point(boC.formFirstLineX, line1);

            dtpWorkStart = new DateTimePicker();
            dtpWorkStart.Font = boC.fV1;
            dtpWorkStart.Size = new System.Drawing.Size(100, ControlHeight);
            dtpWorkStart.Location = new System.Drawing.Point(grd1, line1);
            dtpWorkStart.Format = DateTimePickerFormat.Short;
            gb1.Controls.Add(dtpWorkStart);

            lb9 = new Label();
            lb9.Font = boC.fV1;
            lb9.Text = "เลขที่ใบประกอบวิชาชีพ";
            lb9.AutoSize = true;
            gb1.Controls.Add(lb9);
            lb9.Location = new System.Drawing.Point(grd2, line1);

            txtDtrCode = new MaterialSingleLineTextField();
            txtDtrCode.Font = boC.fV1;
            txtDtrCode.Text = "";
            txtDtrCode.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtDtrCode);
            txtDtrCode.Location = new System.Drawing.Point(grd3+100, line1);
            txtDtrCode.KeyUp += new KeyEventHandler(txtDtrCode_KeyUp);
            txtDtrCode.Hint = lb9.Text;
            txtDtrCode.Enter += TxtDtrCode_Enter;
            txtDtrCode.Leave += TxtDtrCode_Leave;

            lb10 = new Label();
            lb10.Font = boC.fV1;
            lb10.Text = "ประเภทแพทย์";
            lb10.AutoSize = true;
            gb1.Controls.Add(lb10);
            lb10.Location = new System.Drawing.Point(grd4, line1);

            cboDtrTyp = new ComboBox();
            cboDtrTyp.Font = boC.fV1;
            cboDtrTyp.Text = "";
            cboDtrTyp.Size = new System.Drawing.Size(150, ControlHeight);
            gb1.Controls.Add(cboDtrTyp);
            cboDtrTyp.Location = new System.Drawing.Point(grd5, line1);
            cboDtrTyp.BackColor = cForm;

            lb11 = new Label();
            lb11.Font = boC.fV1;
            lb11.Text = "ชนิดแพทย์";
            lb11.AutoSize = true;
            gb1.Controls.Add(lb11);
            lb11.Location = new System.Drawing.Point(grd6, line1);

            cboDtrCat = new ComboBox();
            cboDtrCat.Font = boC.fV1;
            cboDtrCat.Text = "";
            cboDtrCat.Size = new System.Drawing.Size(150, ControlHeight);
            gb1.Controls.Add(cboDtrCat);
            cboDtrCat.Location = new System.Drawing.Point(grd7, line1);
            cboDtrCat.BackColor = cForm;

            lb12 = new Label();
            lb12.Font = boC.fV1;
            lb12.Text = "สาขาแพทย์";
            lb12.AutoSize = true;
            gb1.Controls.Add(lb12);
            lb12.Location = new System.Drawing.Point(grd8, line1);

            cboMedicalField = new ComboBox();
            cboMedicalField.Font = boC.fV1;
            cboMedicalField.Text = "";
            cboMedicalField.Size = new System.Drawing.Size(150, ControlHeight);
            gb1.Controls.Add(cboMedicalField);
            cboMedicalField.Location = new System.Drawing.Point(grd9, line1);
            cboMedicalField.BackColor = cForm;

            lb13 = new Label();
            lb13.Font = boC.fV1;
            lb13.Text = "Tax ID";
            lb13.AutoSize = true;
            gb1.Controls.Add(lb13);
            lb13.Location = new System.Drawing.Point(boC.formFirstLineX, line2);

            txtTaxID = new MaterialSingleLineTextField();
            txtTaxID.Font = boC.fV1;
            txtTaxID.Text = "";
            txtTaxID.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtTaxID);
            txtTaxID.Location = new System.Drawing.Point(grd1, line2);
            txtTaxID.Hint = " เลขที่ผู้เสียภาษี";
            txtTaxID.Enter += TxtTaxID_Enter;
            txtTaxID.Leave += TxtTaxID_Leave;

            lb14 = new Label();
            lb14.Font = boC.fV1;
            lb14.Text = "ที่อยู่";
            lb14.AutoSize = true;
            gb1.Controls.Add(lb14);
            lb14.Location = new System.Drawing.Point(grd2, line2);

            txtAddr = new MaterialSingleLineTextField();
            txtAddr.Font = boC.fV1;
            txtAddr.Text = "";
            txtAddr.Size = new System.Drawing.Size(400, ControlHeight);
            gb1.Controls.Add(txtAddr);
            txtAddr.Location = new System.Drawing.Point(grd3, line2);
            txtAddr.Hint = lb14.Text + " บ้านเลขที่ ซอย ถนน ตำบล อำเภอ จังหวัด รหัสไปษรณีย์";
            txtAddr.Enter += TxtAddr_Enter;
            txtAddr.Leave += TxtAddr_Leave;

            lb15 = new Label();
            lb15.Font = boC.fV1;
            lb15.Text = "Phone";
            lb15.AutoSize = true;
            gb1.Controls.Add(lb15);
            lb15.Location = new System.Drawing.Point(grd6, line2);

            txtPhone = new MaterialSingleLineTextField();
            txtPhone.Font = boC.fV1;
            txtPhone.Text = "";
            txtPhone.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtPhone);
            txtPhone.Location = new System.Drawing.Point(grd7, line2);
            txtPhone.Enter += TxtPhone_Enter;
            txtPhone.Leave += TxtPhone_Leave;

            lb16 = new Label();
            lb16.Font = boC.fV1;
            lb16.Text = "จน.นัดผู้ป่วยต่อวัน";
            lb16.AutoSize = true;
            gb1.Controls.Add(lb16);
            lb16.Location = new System.Drawing.Point(grd8, line2);

            txtAppointmentCnt = new MaterialSingleLineTextField();
            txtAppointmentCnt.Font = boC.fV1;
            txtAppointmentCnt.Text = "";
            txtAppointmentCnt.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtAppointmentCnt);
            txtAppointmentCnt.Location = new System.Drawing.Point(grd9, line2);
            txtAppointmentCnt.Enter += TxtAppointmentCnt_Enter;
            txtAppointmentCnt.Leave += TxtAppointmentCnt_Leave;

            lb17 = new Label();
            lb17.Font = boC.fV1;
            lb17.Text = "ลำดับการพิมพ์";
            lb17.AutoSize = true;
            gb1.Controls.Add(lb17);
            lb17.Location = new System.Drawing.Point(boC.formFirstLineX, line3);

            txtPrnNo = new MaterialSingleLineTextField();
            txtPrnNo.Font = boC.fV1;
            txtPrnNo.Text = "";
            txtPrnNo.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtPrnNo);
            txtPrnNo.Location = new System.Drawing.Point(grd1, line3);
            txtPrnNo.Enter += TxtPrnNo_Enter;
            txtPrnNo.Leave += TxtPrnNo_Leave;

            lb18 = new Label();
            lb18.Font = boC.fV1;
            lb18.Text = "เลขที่บัญชี";
            lb18.AutoSize = true;
            gb1.Controls.Add(lb18);
            lb18.Location = new System.Drawing.Point(grd2, line3);

            txtBankNo = new MaterialSingleLineTextField();
            txtBankNo.Font = boC.fV1;
            txtBankNo.Text = "";
            txtBankNo.Size = new System.Drawing.Size(200, ControlHeight);
            gb1.Controls.Add(txtBankNo);
            txtBankNo.Location = new System.Drawing.Point(grd3, line3);
            txtBankNo.Enter += TxtBankNo_Enter;
            txtBankNo.Leave += TxtBankNo_Leave;

            lb19 = new Label();
            lb19.Font = boC.fV1;
            lb19.Text = "ประกันรายได้";
            lb19.AutoSize = true;
            gb1.Controls.Add(lb19);
            lb19.Location = new System.Drawing.Point(grd4, line3);

            txtSalaryMin = new MaterialSingleLineTextField();
            txtSalaryMin.Font = boC.fV1;
            txtSalaryMin.Text = "";
            txtSalaryMin.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtSalaryMin);
            txtSalaryMin.Location = new System.Drawing.Point(grd5, line3);
            txtSalaryMin.Enter += TxtSalaryMin_Enter;
            txtSalaryMin.Leave += TxtSalaryMin_Leave;

            btnGen = new MaterialFlatButton();
            btnGen.Font = boC.fV1;
            btnGen.Text = "gen เงื่อนไขค่าแพทย์";
            btnGen.Size = new System.Drawing.Size(100, ControlHeight+7);
            gb1.Controls.Add(btnGen);
            btnGen.Location = new System.Drawing.Point(grd1, line41);
            btnGen.Click += new EventHandler(btnGen_Click);

            btnCopy = new MaterialFlatButton();
            btnCopy.Font = boC.fV1;
            btnCopy.Text = "copy เงื่อนไขค่าแพทย์";
            btnCopy.Size = new System.Drawing.Size(100, ControlHeight+7);
            gb1.Controls.Add(btnCopy);
            btnCopy.Location = new System.Drawing.Point(grd2, line41);

            btnSave = new MaterialFlatButton();
            btnSave.Font = boC.fV1;
            btnSave.Text = "Save บันทึกข้อมูล";
            btnSave.Size = new System.Drawing.Size(100, ControlHeight + 7);
            gb1.Controls.Add(btnSave);
            btnSave.Location = new System.Drawing.Point(grd4, line41);
            btnSave.Click += new EventHandler(btnSave_Click);

            btnExcel = new MaterialFlatButton();
            btnExcel.Text = "Export Excel";
            gb1.Controls.Add(btnExcel);
            btnExcel.Location = new Point(grd51, line41);
            btnExcel.Size = new System.Drawing.Size(100, ControlHeight+7);
            //btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnExcel.Click += new EventHandler(btnExcel_Click);

            gb2 = new GroupBox();
            gb2.Text = "เงื่อนไขแพทย์ (DF)";
            gb2.Font = boC.fV1;
            gb2.Size = new System.Drawing.Size(boC.tcW-20, boC.tcH-gb1.Height-160);
            Controls.Add(gb2);
            gb2.Location = new System.Drawing.Point(boC.formFirstLineX, line5);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(gb2.Width-15, gb2.Height-35);
            gb2.Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line1);
        }

        private void TxtSalaryMin_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtSalaryMin.BackColor = cTxtL;
        }

        private void TxtSalaryMin_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtSalaryMin.BackColor = cTxtE;
        }

        private void TxtBankNo_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtBankNo.BackColor = cTxtL;
        }

        private void TxtBankNo_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtBankNo.BackColor = cTxtE;
        }

        private void TxtPrnNo_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtPrnNo.BackColor = cTxtL;
        }

        private void TxtPrnNo_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtPrnNo.BackColor = cTxtE;
        }

        private void TxtAppointmentCnt_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtAppointmentCnt.BackColor = cTxtL;
        }

        private void TxtAppointmentCnt_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtAppointmentCnt.BackColor = cTxtE;
        }

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtPhone.BackColor = cTxtL;
        }

        private void TxtPhone_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtPhone.BackColor = cTxtE;

        }

        private void TxtAddr_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtAddr.BackColor = cTxtL;
        }

        private void TxtAddr_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtAddr.BackColor = cTxtE;
        }

        private void TxtTaxID_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtTaxID.BackColor = cTxtL;
        }

        private void TxtTaxID_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtTaxID.BackColor = cTxtE;
        }

        private void TxtDtrCode_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtDtrCode.BackColor = cTxtL;
        }

        private void TxtDtrCode_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtDtrCode.BackColor = cTxtE;
        }

        private void TxtSNameE_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtSNameE.BackColor = cTxtL;
        }

        private void TxtNameE_Leave(object sender, EventArgs e)
        {

            txtNameE.BackColor = cTxtL;
            //throw new NotImplementedException();
        }

        private void TxtSNameT_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtSNameT.BackColor = cTxtL;
        }

        private void TxtNameT_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtNameT.BackColor = cTxtL;
        }

        private void TxtSNameE_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtSNameE.BackColor = cTxtE;
        }

        private void TxtNameE_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtNameE.BackColor = cTxtE;
        }

        private void TxtSNameT_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtSNameT.BackColor = cTxtE;
        }

        private void TxtNameT_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtNameT.BackColor = cTxtE;
        }

        private void TxtCode_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtCode.BackColor = cTxtL;
        }

        private void TxtCode_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtCode.BackColor = cTxtE;
        }

        private void setDgvH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt ;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colItmCod].Width = 80;
            dgvView.Columns[colItmAstCod].Width = 80;
            dgvView.Columns[colDsc].Width = 500;
            dgvView.Columns[colInsNam].Width = 220;
            dgvView.Columns[colTypTime].Width = 120;
            dgvView.Columns[colRateID].Width = 85;
            dgvView.Columns[colRateCode].Width = 85;
            dgvView.Columns[colInsCod].Width = 85;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colItmCod].HeaderText = "รหัสหลัก";
            dgvView.Columns[colItmAstCod].HeaderText = "รหัสรอง";
            dgvView.Columns[colDsc].HeaderText = "รายการ";
            dgvView.Columns[colInsNam].HeaderText = "insur name";
            dgvView.Columns[colTypTime].HeaderText = "ประเภทค่าแพทย์";
            dgvView.Columns[colRateID].HeaderText = "colRateID";
            dgvView.Columns[colRateCode].HeaderText = "colRateCode";
            dgvView.Columns[colInsCod].HeaderText = "colInsCod";

            dgvView.Columns[colRateID].Visible = false;
            dgvView.Columns[colRateCode].Visible = false;
            dgvView.Columns[colInsCod].Visible = false;

            DataGridViewComboBoxColumn RateTyp = new DataGridViewComboBoxColumn();
            var list12 = new List<string>() { "%", "บาท"};
            RateTyp.DataSource = list12;
            RateTyp.HeaderText = "Rate Type";
            RateTyp.DataPropertyName = "Money";
            RateTyp.Width = 110;
            dgvView.Columns.AddRange(RateTyp);

            DataGridViewTextBoxColumn rate = new DataGridViewTextBoxColumn();
            rate.HeaderText = "Rate";
            dgvView.Columns.AddRange(rate);

            //DataGridViewCheckBoxColumn rate1 = new DataGridViewCheckBoxColumn();
            //rate1.HeaderText = "%";
            ////rate1.
            //dgvView.Columns.AddRange(rate1);
            //DataGridViewCheckBoxColumn rate2 = new DataGridViewCheckBoxColumn();
            //rate2.HeaderText = "บาท";
            //dgvView.Columns.AddRange(rate2);

            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
        private void genDf()
        {
            int rowCnt = 0, k=0;
            //String sql = "Select itmm.*  "
            //                + "From ItmMst itmm "                            
            //                + "Where  itmm.itmsrvopd = '11'  " +
            //                "order by itmm.itminccod ";
            //DataTable dtItm = new DataTable();
            //dtItm =  conn.selectData(sql, "bit");
            DataTable dtItm = boC.selectItmMstDtr();
            //sql = "Select insm.* " +
            //    "From insmst insm ";
            //DataTable dtInc = new DataTable();
            //dtInc = conn.selectData(sql, "bit");
            DataTable dtInc = boC.selectInsMst();
            rowCnt = ((dtItm.Rows.Count * dtInc.Rows.Count*2) + 1);

            dgvView.Rows.Clear();
            //dgvView.ColumnCount = colCnt + 1;
            dgvView.RowCount = rowCnt;
            for(int i = 0; i < rowCnt; i++)
            {
                //dgvView[colRow, i].Value = (i + 1);
                for (int j=0;j< dtItm.Rows.Count; j++)
                {
                    if (i >= rowCnt) continue;
                    if (k >= dtInc.Rows.Count) continue;
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colItmCod, i].Value = dtItm.Rows[j]["itmcod"].ToString().Trim();
                    dgvView[colItmAstCod, i].Value = dtItm.Rows[j]["itmastcod"].ToString().Trim();
                    dgvView[colDsc, i].Value = dtItm.Rows[j]["itmkornam"].ToString().Trim();
                    dgvView[colInsNam, i].Value = dtInc.Rows[k]["inscodnam"].ToString().Trim();
                    dgvView[colTypTime, i].Value = "ในเวลา";
                    dgvView[colRateTyp, i].Value = "%";
                    dgvView[colRate, i].Value = "100";
                    dgvView[colRateID, i].Value = "0";
                    dgvView[colRateCode, i].Value = "-";
                    dgvView[colInsCod, i].Value = dtInc.Rows[k]["inscod"].ToString().Trim();
                    dgvView.Rows[i].DefaultCellStyle.BackColor = Color.DarkKhaki;
                    i++;

                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colItmCod, i].Value = dtItm.Rows[j]["itmcod"].ToString().Trim();
                    dgvView[colItmAstCod, i].Value = dtItm.Rows[j]["itmastcod"].ToString().Trim();
                    dgvView[colDsc, i].Value = dtItm.Rows[j]["itmkornam"].ToString().Trim();
                    dgvView[colInsNam, i].Value = dtInc.Rows[k]["inscodnam"].ToString().Trim();
                    dgvView[colTypTime, i].Value = "นอกเวลา";
                    dgvView[colRateTyp, i].Value = "%";
                    dgvView[colRate, i].Value = "100";
                    dgvView[colRateID, i].Value = "0";
                    dgvView[colRateCode, i].Value = "-";
                    dgvView[colInsCod, i].Value = dtInc.Rows[k]["inscod"].ToString().Trim();
                    if (j != (dtItm.Rows.Count-1))
                    {
                        i++;
                    }
                }
                k++;
            }
        }
        private void setDgv(String dtrCode)
        {
            DataTable dt = new DataTable();
            dt = boC.dtrRDB.selectByDoctor(dtrCode);
            dgvView.Rows.Clear();            
            dgvView.RowCount = dt.Rows.Count;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
                dgvView[colItmCod, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.ItmCod].ToString().Trim();
                dgvView[colItmAstCod, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.ItmAstCod].ToString().Trim();
                dgvView[colDsc, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.Desc].ToString().Trim();
                dgvView[colInsNam, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.InsCodeName].ToString().Trim();
                dgvView[colTypTime, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.TypTime].ToString().Trim();
                dgvView[colRateTyp, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.RateTyp].ToString().Trim();
                dgvView[colRate, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.Rate].ToString().Trim();
                dgvView[colRateID, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.RateId].ToString().Trim();
                dgvView[colRateCode, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.RateCode].ToString().Trim();
                dgvView[colInsCod, i].Value = dt.Rows[i][boC.dtrRDB.dtrR.InsCode].ToString().Trim();
            }
        }
        private void setControl()
        {
            dtr = boC.dtrDB.selectByPk(boC.DtrCode);
            txtCode.Text = dtr.Code;
            txtNameT.Text = dtr.DtrFnameT;
            txtSNameT.Text = dtr.DtrSnameT;
            txtNameE.Text = dtr.DtrFnameE;
            txtDtrCode.Text = dtr.DtrCode;
            //ComboBoxItem cb = new ComboBoxItem();
            //cb.Value = dtr.DtrMedicalField; ;
            cboMedicalField.Text = boC.getMedecalFieldName(dtr.DtrMedicalField);
            
            cboDtrCat.Text = boC.getDtrCatName(dtr.DtrCatCode);
            cboDtrTyp.Text = boC.getDtrTypName(dtr.DtrTypCode);
            cboPNameT.Text = boC.getTitleNameT(dtr.DtrTitCode);
            cboPNameE.Text = boC.getTitleNameE(dtr.DtrTitCode);
            //txtNameE.Text = dtr.DtrFnameE;
            txtSNameE.Text = dtr.DtrSnameE;
            txtPhone.Text = dtr.Phone;
            txtTaxID.Text = dtr.TaxID;
            txtPrnNo.Text = dtr.Sort1;
            txtSalaryMin.Text = dtr.SalaryMin;
            txtBankNo.Text = dtr.BankNO;
            txtAppointmentCnt.Text = dtr.AppointmnetCnt;
            txtAddr.Text = dtr.Address;
            

            setDgv(txtDtrCode.Text);
        }
        private void getDoctor()
        {
            dtr = new Doctor();
            dtr.Code = txtCode.Text;
            dtr.DtrFnameT = txtNameT.Text;
            dtr.DtrSnameT = txtSNameT.Text;
            dtr.DtrFnameE = txtNameE.Text;
            dtr.DtrSnameE = txtSNameE.Text;
            dtr.DtrCode = txtDtrCode.Text;
            dtr.TaxID = txtTaxID.Text;
            dtr.Address = txtAddr.Text;
            dtr.BankNO = txtBankNo.Text;
            dtr.AppointmnetCnt = txtAppointmentCnt.Text;
            dtr.Phone = txtPhone.Text;
            dtr.Sort1 = txtPrnNo.Text;
            dtr.Remark = "";
            dtr.SalaryMin = txtSalaryMin.Text;
            cboI = (ComboBoxItem)cboDtrTyp.SelectedItem;
            dtr.DtrTypCode = cboI.Value;
            cboI = (ComboBoxItem)cboDtrCat.SelectedItem;
            dtr.DtrCatCode = cboI.Value;
            cboI = (ComboBoxItem)cboPNameT.SelectedItem;
            dtr.DtrTitCode = cboI.Value;            
            cboI = (ComboBoxItem)cboMedicalField.SelectedItem;
            dtr.DtrMedicalField = cboI.Value;
        }
        private void saveDoctorRate()
        {
            for(int i = 0; i < dgvView.RowCount; i++)
            {
                if(dgvView[colDsc, i].Value == null)
                {
                    continue;
                }
                DoctorRate dtrR = new DoctorRate();
                dtrR.row1 = i.ToString();
                dtrR.Desc = dgvView[colDsc, i].Value.ToString();
                dtrR.DtrCode = txtDtrCode.Text;
                dtrR.InsCode = dgvView[colInsCod, i].Value.ToString();
                dtrR.InsCodeName = dgvView[colInsNam, i].Value.ToString();
                dtrR.ItmAstCod = dgvView[colItmAstCod, i].Value.ToString();
                dtrR.ItmCod = dgvView[colItmCod, i].Value.ToString();
                dtrR.ItmKorNam = "";
                
                dtrR.RateCode = dgvView[colRateCode, i].Value.ToString();
                dtrR.RateId = dgvView[colRateID, i].Value.ToString();
                dtrR.TypTime = dgvView[colTypTime, i].Value.ToString();
                dtrR.RateTyp = dgvView[colRateTyp, i].Value.ToString();
                dtrR.Rate = dgvView[colRate, i].Value.ToString();
                dtrR.Remark = "";

                boC.saveDoctorRaate(dtrR);
            }
        }
        private void saveDoctor()
        {
            getDoctor();
            boC.saveDoctor(dtr);
            saveDoctorRate();
        }
        private void openDtView1()
        {
            boC.DtrCode = "";
            DfView1 frm = new DfView1(boC);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);

            if (!boC.DtrCode.Equals(""))
            {
                txtCode.Text = boC.DtrCode;
                txtDtrCode.Text = boC.DtrCode;
                setControl();
            }
        }
        private void ExcelData()
        {
            String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            worksheet.Cells[1, 1] = txtDtrCode.Text;
            worksheet.Cells[1, 2] = txtNameT.Text;
            worksheet.Cells[1, 3] = txtSNameT.Text;
            for (int i = 0; i < dgvView.Rows.Count; i++)
            {
                try
                {
                    if (dgvView[colRow, i].Value == null)
                    {
                        continue;
                    }
                    worksheet.Cells[i + 3 + 1, colRow+1] = dgvView[colRow, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colItmCod + 1] = dgvView[colItmCod, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colItmAstCod + 1] = dgvView[colItmAstCod, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colDsc + 1] = dgvView[colDsc, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colInsNam + 1] = dgvView[colInsNam, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colTypTime + 1] = dgvView[colTypTime, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colRateTyp + 1] = dgvView[colRateTyp, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colRate + 1] = dgvView[colRate, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colTypTime + 1] = dgvView[colTypTime, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colTypTime + 1] = dgvView[colTypTime, i].Value.ToString();
                    worksheet.Cells[i + 3 + 1, colTypTime + 1] = dgvView[colTypTime, i].Value.ToString();
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
        private void txtDtrCode_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                openDtView1();
            }
        }
        private void btnGen_Click(object sender, EventArgs e)
        {
            genDf();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //genDf();
            openDtView1();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDoctor();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelData();
        }
    }
}
