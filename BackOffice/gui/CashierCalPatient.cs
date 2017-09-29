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
    class CashierCalPatient:Form
    {
        int gapLine = 5;
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd51 = 700, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        int colRow = 0, colOdrCod = 1, colOdrCodNam = 2, colItmNam=3, colOdrItmCod = 4, colOdrAstCod = 5, colQty=6, colPrc=7, colAmt=8;
        int colCnt = 9;

        BackOfficeControl boC;
        BITHisControl bitC;
        HisDB hisDB;

        Color cTxtL, cTxtE, cForm;

        MaterialSingleLineTextField txtHN, txtAmt, txtDiscount, txtNettotal, txtReceiptNum;
        MaterialFlatButton btnSearch, btnPrintReceipt, btnPrintInvoice, btnCal;
        MaterialLabel lb1, lb2, lb3, lb4, lb5,lb6, lb7, lbOcmNum, lbPatientFullName;

        DataGridView dgvView, dgvVn;
        DateTimePicker dtpDateCal;
        //private readonly MaterialSkinManager materialSkinManager;

        public CashierCalPatient(BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            bitC = new BITHisControl();

            cForm = this.BackColor;
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            cTxtL = txtHN.BackColor;
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

            lbPatientFullName = new MaterialLabel();
            lbPatientFullName.Font = boC.fV1;
            lbPatientFullName.Text = "";
            lbPatientFullName.AutoSize = true;
            Controls.Add(lbPatientFullName);
            lbPatientFullName.Location = new System.Drawing.Point(grd3, boC.formFirstLineY + gapLine);

            txtHN = new MaterialSingleLineTextField();
            txtHN.Font = boC.fV1;
            txtHN.Text = "";
            txtHN.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txtHN);
            txtHN.Location = new System.Drawing.Point(grd1, boC.formFirstLineY + gapLine);
            txtHN.Hint = lb1.Text;
            txtHN.Enter += TxtCode_Enter;
            txtHN.Leave += TxtCode_Leave;

            btnSearch = new MaterialFlatButton();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "...";
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1 + txtHN.Width + 5, boC.formFirstLineY + gapLine);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            lb2 = new MaterialLabel();
            lb2.Font = boC.fV1;
            lb2.Text = "วันที่";
            lb2.AutoSize = true;
            Controls.Add(lb2);
            lb2.Location = new System.Drawing.Point(boC.formFirstLineX, line2);
            dtpDateCal = new DateTimePicker();
            dtpDateCal.Font = boC.fV1;
            dtpDateCal.Size = new System.Drawing.Size(100, ControlHeight);
            dtpDateCal.Location = new System.Drawing.Point(grd1, line2);
            dtpDateCal.Format = DateTimePickerFormat.Short;
            Controls.Add(dtpDateCal);

            lb3 = new MaterialLabel();
            lb3.Font = boC.fV1;
            lb3.Text = "ocm num";
            lb3.AutoSize = true;
            Controls.Add(lb3);
            lb3.Location = new System.Drawing.Point(grd3, line2);
            lbOcmNum = new MaterialLabel();
            lbOcmNum.Font = boC.fV1;
            lbOcmNum.Text = "";
            lbOcmNum.AutoSize = true;
            Controls.Add(lbOcmNum);
            lbOcmNum.Location = new System.Drawing.Point(grd3+lb3.Width+30, line2);            

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(boC.tcW - 20, 600);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line3);

            lb4 = new MaterialLabel();
            lb4.Font = boC.fV1;
            lb4.Text = "รวม :";
            lb4.AutoSize = true;
            Controls.Add(lb4);
            lb4.Location = new System.Drawing.Point(grd5, line3+dgvView.Height+20);
            txtAmt = new MaterialSingleLineTextField();
            txtAmt.Font = boC.fV1;
            txtAmt.Text = "";
            txtAmt.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtAmt);
            txtAmt.Location = new System.Drawing.Point(grd5+80, line3 + dgvView.Height + 20);

            lb5 = new MaterialLabel();
            lb5.Font = boC.fV1;
            lb5.Text = "ส่วนลด :";
            lb5.AutoSize = true;
            Controls.Add(lb5);
            lb5.Location = new System.Drawing.Point(grd5, line3 + dgvView.Height + 50);
            txtDiscount = new MaterialSingleLineTextField();
            txtDiscount.Font = boC.fV1;
            txtDiscount.Text = "";
            txtDiscount.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtDiscount);
            txtDiscount.Location = new System.Drawing.Point(grd5 + 80, line3 + dgvView.Height + 50);
            txtDiscount.KeyUp += new KeyEventHandler(txtDiscount_KeyUp);

            lb6 = new MaterialLabel();
            lb6.Font = boC.fV1;
            lb6.Text = "สุทธิ :";
            lb6.AutoSize = true;
            Controls.Add(lb6);
            lb6.Location = new System.Drawing.Point(grd5, line3 + dgvView.Height + 80);
            txtNettotal = new MaterialSingleLineTextField();
            txtNettotal.Font = boC.fV1;
            txtNettotal.Text = "";
            txtNettotal.Size = new System.Drawing.Size(200, ControlHeight);
            
            Controls.Add(txtNettotal);
            txtNettotal.Location = new System.Drawing.Point(grd5 + 80, line3 + dgvView.Height + 80);

            lb7 = new MaterialLabel();
            lb7.Font = boC.fV1;
            lb7.Text = "เลขที่ใบเสร็จ :";
            lb7.AutoSize = true;
            Controls.Add(lb7);
            lb7.Location = new System.Drawing.Point(grd2, line3 + dgvView.Height + 20);
            txtReceiptNum = new MaterialSingleLineTextField();
            txtReceiptNum.Font = boC.fV1;
            txtReceiptNum.Text = "";
            txtReceiptNum.Size = new System.Drawing.Size(200, ControlHeight);
            Controls.Add(txtReceiptNum);
            txtReceiptNum.Location = new System.Drawing.Point(grd3, line3 + dgvView.Height +20);

            btnCal = new MaterialFlatButton();
            btnCal.Font = boC.fV1;
            btnCal.Text = "คำนวณใหม่";
            btnCal.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnCal);
            btnCal.Location = new System.Drawing.Point(grd2, line3 + dgvView.Height + 50);
            btnCal.Click += new EventHandler(btnPrintInvoice_Click);

            btnPrintInvoice = new MaterialFlatButton();
            btnPrintInvoice.Font = boC.fV1;
            btnPrintInvoice.Text = "พิมพ์ ใบงบสรุปค่าใช้จ่าย";
            btnPrintInvoice.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnPrintInvoice);
            btnPrintInvoice.Location = new System.Drawing.Point(grd5 , line2-20);
            btnPrintInvoice.Click += new EventHandler(btnPrintInvoice_Click);

            btnPrintReceipt = new MaterialFlatButton();
            btnPrintReceipt.Font = boC.fV1;
            btnPrintReceipt.Text = "พิมพ์ ใบเสร็จ";
            btnPrintReceipt.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnPrintReceipt);
            btnPrintReceipt.Location = new System.Drawing.Point(grd5 + btnPrintInvoice.Width+20, line2-20);
            btnPrintReceipt.Click += new EventHandler(btnPrintReceipt_Click);
        }
        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            calNetTotal();
        }
        private void TxtCode_Leave(object sender, EventArgs e)
        {
            txtHN.BackColor = cTxtL;
        }

        private void TxtCode_Enter(object sender, EventArgs e)
        {
            txtHN.BackColor = cTxtE;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            openPatientSearch();
        }
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            openPatientSearch();
        }
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            openPatientSearch();
        }
        private void calNetTotal()
        {
            txtDiscount.Text = txtDiscount.Text.Equals("") ? "0.0" : txtDiscount.Text;
            txtAmt.Text = txtAmt.Text.Equals("") ? "0.0" : txtAmt.Text;
            txtNettotal.Text = String.Concat(Decimal.Parse(txtAmt.Text) - Decimal.Parse(txtDiscount.Text));
        }
        private void setDgvHnH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt ;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colOdrCod].Width = 80;
            dgvView.Columns[colOdrCodNam].Width = 300;
            dgvView.Columns[colItmNam].Width = 300;
            dgvView.Columns[colQty].Width = 80;
            dgvView.Columns[colOdrItmCod].Width = 60;
            dgvView.Columns[colOdrAstCod].Width = 60;            
            dgvView.Columns[colPrc].Width = 80;
            dgvView.Columns[colAmt].Width = 80;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colOdrCod].HeaderText = "odr cod";
            dgvView.Columns[colOdrCodNam].HeaderText = "cod name";
            dgvView.Columns[colItmNam].HeaderText = "Itm nam";
            dgvView.Columns[colOdrItmCod].HeaderText = "Itm Cod";
            dgvView.Columns[colOdrAstCod].HeaderText = "Ast Cod";
            dgvView.Columns[colQty].HeaderText = "qty";
            dgvView.Columns[colPrc].HeaderText = "price";
            dgvView.Columns[colAmt].HeaderText = "Amount";

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
            int rowCnt = 0;

            bitC.HN = "";
            String curDate = dtpDateCal.Value.Year.ToString() + dtpDateCal.Value.ToString("MMdd");
            CashierSearchPatient frm = new CashierSearchPatient(boC, bitC, curDate);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);

            if (!bitC.HN.Equals(""))
            {
                txtHN.Text = bitC.HN;
                lbPatientFullName.Text = bitC.PatientFullName+"  "+ bitC.insCodNam +"  "+ bitC.rsvCmt;
                lbOcmNum.Text = bitC.ocmNum;
                DataTable dt = new DataTable();
                Decimal qty = 0, amt=0;

                dt = bitC.getPatientCal(bitC.ocmNum);
                dgvView.Rows.Clear();
                rowCnt = dt.Rows.Count;
                dgvView.RowCount = rowCnt;
                for (int i = 0; i < rowCnt; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colOdrCod, i].Value = dt.Rows[i]["odrcod"].ToString().Trim();
                    dgvView[colOdrCodNam, i].Value = dt.Rows[i]["odrcodnam"].ToString().Trim();
                    dgvView[colOdrItmCod, i].Value = dt.Rows[i]["odritmcod"].ToString().Trim();
                    dgvView[colOdrAstCod, i].Value = dt.Rows[i]["odrastcod"].ToString().Trim();
                    dgvView[colQty, i].Value = dt.Rows[i]["odrqty"].ToString().Trim();
                    dgvView[colPrc, i].Value = dt.Rows[i]["odrprc"].ToString().Trim();
                    dgvView[colAmt, i].Value = dt.Rows[i]["odramt"].ToString().Trim();
                    dgvView[colItmNam, i].Value = dt.Rows[i]["itmkornam"].ToString().Trim();
                    amt += (Decimal.Parse(dt.Rows[i]["odramt"].ToString().Trim()));
                }
                txtAmt.Text = amt.ToString();
                calNetTotal();
                //setControl();
            }
        }
    }
}
