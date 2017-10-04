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
    class RegHnSearch:Form
    {
        int gapLine = 5;
        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd51 = 700, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        int colRow = 0, colHn = 1, colPatNam = 2, colPatSur = 3, colAddr = 4, colQty = 6, colPrc = 7, colAmt = 8;
        int colCnt = 9;

        ControlMaster cM;
        BackOfficeControl boC;
        BITHisControl bitC;
        HisDB hisDB;

        Color cTxtL, cTxtE, cForm;

        MaterialSingleLineTextField txtHN;
        MaterialLabel lb1;
        MaterialFlatButton btnSearch;
        DataGridView dgvView;

        public RegHnSearch(ControlMaster cm,BackOfficeControl boc)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            cM = cm;
            boC = boc;
            bitC = new BITHisControl(cM);

            cForm = this.BackColor;
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            cTxtL = txtHN.BackColor;
            cTxtE = Color.Yellow;

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

            txtHN = new MaterialSingleLineTextField();
            txtHN.Font = boC.fV1;
            txtHN.Text = "";
            txtHN.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txtHN);
            txtHN.Location = new System.Drawing.Point(grd1, boC.formFirstLineY + gapLine);
            txtHN.Hint = lb1.Text;
            txtHN.Enter += TxtHN_Enter;
            txtHN.Leave += TxtHN_Leave;
            txtHN.KeyUp += new KeyEventHandler(txtHN_KeyUp);

            btnSearch = new MaterialFlatButton();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "...";
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1 + txtHN.Width + 5, boC.formFirstLineY + gapLine);
            btnSearch.Click += new EventHandler(btnSearch_Click);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(boC.tcW - 20, 550);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line3);
        }
        private void txtHN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openPatientSearch();
                dgvView.Focus();
                //return;
            }            
        }
        private void TxtHN_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtHN.BackColor = cTxtL;
        }

        private void TxtHN_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            txtHN.BackColor = cTxtE;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            openPatientSearch();
        }
        private void setDgvHnH()
        {
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colPatNam].Width = 120;
            dgvView.Columns[colPatSur].Width = 120;
            //dgvView.Columns[colAddr].Width = 250;

            dgvView.Columns[colHn].Width = 80;
            dgvView.Columns[colAddr].Width = 250;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colPatNam].HeaderText = "ชื่อ";
            dgvView.Columns[colPatSur].HeaderText = "นามสกุล";
            dgvView.Columns[colHn].HeaderText = "HN";
            dgvView.Columns[colAddr].HeaderText = "ที่อยู่";
            //dgvView.Columns[colOdrAstCod].HeaderText = "Ast Cod";
            //dgvView.Columns[colQty].HeaderText = "qty";
            //dgvView.Columns[colPrc].HeaderText = "price";
            //dgvView.Columns[colAmt].HeaderText = "Amount";

            dgvView.Columns[colPatNam].Visible = true;
            dgvView.Columns[colPatSur].Visible = true;
            dgvView.Columns[colHn].Visible = true;
            dgvView.Columns[colAddr].Visible = true;

            Font font = new Font("Microsoft Sans Serif", 10);
            dgvView.Font = font;
        }
        private void openPatientSearch()
        {
            setDgvHnH();
            int rowCnt = 0;

            //bitC.HN = "";
            //String curDate = dtpDateCal.Value.Year.ToString() + dtpDateCal.Value.ToString("MMdd");
            //CashierSearchPatient frm = new CashierSearchPatient(boC, bitC, curDate);
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.ShowDialog(this);

            DataTable dtItem = bitC.getPatientAll(txtHN.Text);
            if (dtItem.Rows.Count <= 0)
            {
                return;
            }
            dgvView.Rows.Clear();
            rowCnt = dtItem.Rows.Count;
            dgvView.RowCount = rowCnt;
            for (int i = 0; i < rowCnt; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
                dgvView[colPatNam, i].Value = dtItem.Rows[i]["pbspatnam"].ToString().Trim();
                dgvView[colPatSur, i].Value = dtItem.Rows[i]["pbssurnam"].ToString().Trim();
                dgvView[colHn, i].Value = dtItem.Rows[i]["pbschtnum"].ToString().Trim();
                dgvView[colAddr, i].Value = dtItem.Rows[i]["pbsDtlAdr"].ToString().Trim()+" "+ dtItem.Rows[i]["pbsadrsta"].ToString().Trim() + " " + dtItem.Rows[i]["pbsadrpro"].ToString().Trim() + " " + dtItem.Rows[i]["pbszipcod"].ToString().Trim();
                //    dgvView[colQty, i].Value = dtItem.Rows[i]["odrqty"].ToString().Trim();
                //    dgvView[colPrc, i].Value = dtItem.Rows[i]["odrprc"].ToString().Trim();
                //    dgvView[colAmt, i].Value = dtItem.Rows[i]["odramt"].ToString().Trim();
                //    dgvView[colItmNam, i].Value = dtItem.Rows[i]["itmkornam"].ToString().Trim();
                //    amt += (Decimal.Parse(dtItem.Rows[i]["odramt"].ToString().Trim()));
            }
            //txtAmt.Text = amt.ToString();
            //calNetTotal();
            ////setControl();
        
        }
    }
}
