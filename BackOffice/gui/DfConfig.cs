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
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd6=820, grd7=900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3=85, line4=105, line41=120, line5=270, ControlHeight=21, lineGap=5;

        int colRow = 0, colItmCod = 1, colItmAstCod = 2, colDsc = 3, colInsNam = 4, colTypTime = 5, colRateTyp = 6, colRate = 7;
        int colCnt = 6;
        Label lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10, lb11, lb12, lb13,lb14, lb15, lb16, lb17, lb18, lb19;
        TextBox txtCode, txtNameT, txtNameE, txtSNameT, txtSNameE, txtDtrCode, txtTaxID, txtAddr, txtPhone, txtPrnNo, txtAppointmentCnt, txtBankNo, txtSalaryMin;
        ComboBox cboPNameT, cboPNameE, cboDtrTyp, cboDtrCat, cboMedicalField;
        GroupBox gb1, gb2;
        DateTimePicker dtpWorkStart;
        Button btnSearch, btnGen, btnCopy, btnSave;
        DataGridView dgvView;

        ComboBoxItem cboI;

        BackOfficeControl boC;
        //ConnectDB conn;

        Doctor dtr;
        public DfConfig(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            //conn = new ConnectDB("bit");
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            dtr = new Doctor();
            cboI = new ComboBoxItem();
            setDgvH();
            cboPNameT = boC.getCboTitleDrT(cboPNameT);
            cboPNameE = boC.getCboTitleDrE(cboPNameE);
            cboMedicalField = boC.getCboMedicalField(cboMedicalField);
        }
        private void initCompoment()
        {
            //btnExcel.Size = new System.Drawing.Size(75, 23);
            //btnSearch.TabIndex = 0;
            //btnSearch.UseVisualStyleBackColor = true;
            //groupBox1.Location = new System.Drawing.Point(5, 4);

            //SELECT* FROM bithis.depmst1 where depgrpcod in ('GS', 'OBGY', 'PED', 'MED')

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
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight );
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1+txtCode.Width+5, boC.formFirstLineY);
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

            lb4 = new Label();
            lb4.Font = boC.fV1;
            lb4.Text = "ชื่อ";//ชื่อ-นามสกุล แพทย์
            lb4.AutoSize = true;
            Controls.Add(lb4);
            lb4.Location = new System.Drawing.Point(grd2, line1);

            txtNameT = new TextBox();
            txtNameT.Font = boC.fV1;
            txtNameT.Text = "";
            txtNameT.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtNameT);
            txtNameT.Location = new System.Drawing.Point(grd3, line1);

            lb5 = new Label();
            lb5.Font = boC.fV1;
            lb5.Text = "นามสกุล";//ชื่อ-นามสกุล แพทย์
            lb5.AutoSize = true;
            Controls.Add(lb5);
            lb5.Location = new System.Drawing.Point(grd4, line1);

            txtSNameT = new TextBox();
            txtSNameT.Font = boC.fV1;
            txtSNameT.Text = "";
            txtSNameT.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtSNameT);
            txtSNameT.Location = new System.Drawing.Point(grd5, line1);

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

            lb6 = new Label();
            lb6.Font = boC.fV1;
            lb6.Text = "Name";//ชื่อ-นามสกุล แพทย์
            lb6.AutoSize = true;
            Controls.Add(lb6);
            lb6.Location = new System.Drawing.Point(grd2, line2);

            txtNameE = new TextBox();
            txtNameE.Font = boC.fV1;
            txtNameE.Text = "";
            txtNameE.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtNameE);
            txtNameE.Location = new System.Drawing.Point(grd3, line2);

            lb7 = new Label();
            lb7.Font = boC.fV1;
            lb7.Text = "Sur name";//ชื่อ-นามสกุล แพทย์
            lb7.AutoSize = true;
            Controls.Add(lb7);
            lb7.Location = new System.Drawing.Point(grd4, line2);

            txtSNameE = new TextBox();
            txtSNameE.Font = boC.fV1;
            txtSNameE.Text = "";
            txtSNameE.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtSNameE);
            txtSNameE.Location = new System.Drawing.Point(grd5, line2);

            gb1 = new GroupBox();
            gb1.Text = "ข้อมูลทั่วไป";
            gb1.Font = boC.fV1;
            gb1.Size = new System.Drawing.Size(boC.tcW - 20, 150);
            Controls.Add(gb1);
            gb1.Location = new System.Drawing.Point(boC.formFirstLineX, line4);

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

            txtDtrCode = new TextBox();
            txtDtrCode.Font = boC.fV1;
            txtDtrCode.Text = "";
            txtDtrCode.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtDtrCode);
            txtDtrCode.Location = new System.Drawing.Point(grd3+100, line1);
            txtDtrCode.KeyUp += new KeyEventHandler(txtDtrCode_KeyUp);

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

            lb13 = new Label();
            lb13.Font = boC.fV1;
            lb13.Text = "Tax ID";
            lb13.AutoSize = true;
            gb1.Controls.Add(lb13);
            lb13.Location = new System.Drawing.Point(boC.formFirstLineX, line2);

            txtTaxID = new TextBox();
            txtTaxID.Font = boC.fV1;
            txtTaxID.Text = "";
            txtTaxID.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtTaxID);
            txtTaxID.Location = new System.Drawing.Point(grd1, line2);

            lb14 = new Label();
            lb14.Font = boC.fV1;
            lb14.Text = "ที่อยู่";
            lb14.AutoSize = true;
            gb1.Controls.Add(lb14);
            lb14.Location = new System.Drawing.Point(grd2, line2);

            txtAddr = new TextBox();
            txtAddr.Font = boC.fV1;
            txtAddr.Text = "";
            txtAddr.Size = new System.Drawing.Size(400, ControlHeight);
            gb1.Controls.Add(txtAddr);
            txtAddr.Location = new System.Drawing.Point(grd3, line2);

            lb15 = new Label();
            lb15.Font = boC.fV1;
            lb15.Text = "Phone";
            lb15.AutoSize = true;
            gb1.Controls.Add(lb15);
            lb15.Location = new System.Drawing.Point(grd6, line2);

            txtPhone = new TextBox();
            txtPhone.Font = boC.fV1;
            txtPhone.Text = "";
            txtPhone.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtPhone);
            txtPhone.Location = new System.Drawing.Point(grd7, line2);

            lb16 = new Label();
            lb16.Font = boC.fV1;
            lb16.Text = "จน.นัดผู้ป่วยต่อวัน";
            lb16.AutoSize = true;
            gb1.Controls.Add(lb16);
            lb16.Location = new System.Drawing.Point(grd8, line2);

            txtAppointmentCnt = new TextBox();
            txtAppointmentCnt.Font = boC.fV1;
            txtAppointmentCnt.Text = "";
            txtAppointmentCnt.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtAppointmentCnt);
            txtAppointmentCnt.Location = new System.Drawing.Point(grd9, line2);

            lb17 = new Label();
            lb17.Font = boC.fV1;
            lb17.Text = "ลำดับการพิมพ์";
            lb17.AutoSize = true;
            gb1.Controls.Add(lb17);
            lb17.Location = new System.Drawing.Point(boC.formFirstLineX, line3);

            txtPrnNo = new TextBox();
            txtPrnNo.Font = boC.fV1;
            txtPrnNo.Text = "";
            txtPrnNo.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtPrnNo);
            txtPrnNo.Location = new System.Drawing.Point(grd1, line3);

            lb18 = new Label();
            lb18.Font = boC.fV1;
            lb18.Text = "เลขที่บัญชี";
            lb18.AutoSize = true;
            gb1.Controls.Add(lb18);
            lb18.Location = new System.Drawing.Point(grd2, line3);

            txtBankNo = new TextBox();
            txtBankNo.Font = boC.fV1;
            txtBankNo.Text = "";
            txtBankNo.Size = new System.Drawing.Size(200, ControlHeight);
            gb1.Controls.Add(txtBankNo);
            txtBankNo.Location = new System.Drawing.Point(grd3, line3);

            lb19 = new Label();
            lb19.Font = boC.fV1;
            lb19.Text = "ประกันรายได้";
            lb19.AutoSize = true;
            gb1.Controls.Add(lb19);
            lb19.Location = new System.Drawing.Point(grd4, line3);

            txtSalaryMin = new TextBox();
            txtSalaryMin.Font = boC.fV1;
            txtSalaryMin.Text = "";
            txtSalaryMin.Size = new System.Drawing.Size(100, ControlHeight);
            gb1.Controls.Add(txtSalaryMin);
            txtSalaryMin.Location = new System.Drawing.Point(grd5, line3);

            btnGen = new Button();
            btnGen.Font = boC.fV1;
            btnGen.Text = "gen เงื่อนไขค่าแพทย์";
            btnGen.Size = new System.Drawing.Size(100, ControlHeight+7);
            gb1.Controls.Add(btnGen);
            btnGen.Location = new System.Drawing.Point(grd1, line41);
            btnGen.Click += new EventHandler(btnGen_Click);

            btnCopy = new Button();
            btnCopy.Font = boC.fV1;
            btnCopy.Text = "copy เงื่อนไขค่าแพทย์";
            btnCopy.Size = new System.Drawing.Size(100, ControlHeight+7);
            gb1.Controls.Add(btnCopy);
            btnCopy.Location = new System.Drawing.Point(grd2, line41);

            btnSave = new Button();
            btnSave.Font = boC.fV1;
            btnSave.Text = "Save";
            btnSave.Size = new System.Drawing.Size(100, ControlHeight + 7);
            gb1.Controls.Add(btnSave);
            btnSave.Location = new System.Drawing.Point(grd4, line41);
            btnSave.Click += new EventHandler(btnSave_Click);

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
            //dgvView.Columns[colTypTime].Width = 120;
            //dgvView.Columns[colRateTyp].Width = 85;
            //dgvView.Columns[colRate].Width = 85;            

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colItmCod].HeaderText = "รหัสหลัก";
            dgvView.Columns[colItmAstCod].HeaderText = "รหัสรอง";
            dgvView.Columns[colDsc].HeaderText = "รายการ";
            dgvView.Columns[colInsNam].HeaderText = "insur name";
            dgvView.Columns[colTypTime].HeaderText = "ประเภทค่าแพทย์";
            //dgvView.Columns[colRateTyp].HeaderText = "Rate Type";
            //dgvView.Columns[colRate].HeaderText = "Rate";

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

            DataGridViewCheckBoxColumn rate1 = new DataGridViewCheckBoxColumn();
            rate1.HeaderText = "%";
            //rate1.
            dgvView.Columns.AddRange(rate1);
            DataGridViewCheckBoxColumn rate2 = new DataGridViewCheckBoxColumn();
            rate2.HeaderText = "บาท";
            dgvView.Columns.AddRange(rate2);

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
                    if (j != (dtItm.Rows.Count-1))
                    {
                        i++;
                    }
                }
                k++;
            }
        }
        private void setControl()
        {
            dtr = boC.dtrDB.selectByPk(boC.DtrCode);
            txtCode.Text = dtr.Code;
            txtNameT.Text = dtr.DtrFnameT;
            txtSNameT.Text = dtr.DtrSnameT;
            txtNameE.Text = dtr.DtrFnameT;
            ComboBoxItem cb = new ComboBoxItem();
            cb.Value = dtr.DtrMedicalField; ;
            cboMedicalField.SelectedItem = cb;
        }
        private void getDoctor()
        {
            dtr = new Doctor();
            dtr.Code = txtCode.Text;
            dtr.DtrFnameT = txtNameT.Text;
            dtr.DtrSnameT = txtSNameT.Text;
            cboI = (ComboBoxItem)cboMedicalField.SelectedItem;
            dtr.DtrMedicalField = cboI.Value;
        }
        private void saveDoctor()
        {
            getDoctor();
            boC.saveDoctor(dtr);
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
    }
}
