﻿using System;
using System.Collections.Generic;
using System.Data;
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
        MaterialListView lV;

        BackOfficeControl boC;
        ConnectDB conn;

        public DfView1(BackOfficeControl boc)
        {            
            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;
            conn = new ConnectDB("bit", boC.initC);
            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
            this.Size = new System.Drawing.Size(900, 500);
            //this.Location = new System.Drawing.Point(boC.formFirstLineX-20, line1-20);
            //this.Opacity = 0.7;
            this.BackColor = Color.DarkSlateGray;
            //this.TransparencyKey = Color.LimeGreen;
            setDgvH();
            setDgv();
            //setLvH();
        }
        private void initCompoment()
        {
            lb1 = new Label();
            lb1.Font = boC.fV1B;
            lb1.ForeColor = Color.White;
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
            txtCode.KeyUp += new KeyEventHandler(txtCode_KeyUp);

            btnSearch = new Button();
            btnSearch.Font = boC.fV1;
            btnSearch.Text = "...";
            btnSearch.Size = new System.Drawing.Size(30, ControlHeight);
            Controls.Add(btnSearch);
            btnSearch.Location = new System.Drawing.Point(grd1 + txtCode.Width + 5, boC.formFirstLineY);
            //btnSearch.Click += new EventHandler(btnSearch_Click);

            dgvView = new DataGridView();
            dgvView.Font = boC.fV1;
            dgvView.Size = new System.Drawing.Size(880, 460);
            Controls.Add(dgvView);
            dgvView.Location = new System.Drawing.Point(boC.formFirstLineX, line1);
            dgvView.KeyDown += new KeyEventHandler(dgvView_KeyDown);

            //lV = new MaterialListView();
            //lV.GridLines = true;
            //lV.FullRowSelect = true;
            //lV.Font = boC.fV1;
            //lV.Size = new System.Drawing.Size(880, 460);
            //Controls.Add(lV);
            //lV.Location = new System.Drawing.Point(boC.formFirstLineX, line1);
        }
        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvView.Focus();
                
                //return;
            }else if (txtCode.Text.Length > 2)
            {
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvView.Rows)
                {
                    if (row.Cells[colDtrCod].Value.ToString().Length >= txtCode.Text.Length)
                    {
                        if (row.Cells[colDtrCod].Value.ToString().Substring(0, txtCode.Text.Length).Equals(txtCode.Text))
                        {
                            rowIndex = row.Index;
                            dgvView.CurrentCell = dgvView.Rows[rowIndex].Cells[0];
                            dgvView.Rows[dgvView.CurrentCell.RowIndex].Selected = true;
                            break;
                        }
                        else if ((row.Cells[colDtrName].Value.ToString().Length >= txtCode.Text.Length) && (row.Cells[colDtrName].Value.ToString().Substring(0, txtCode.Text.Length).Equals(txtCode.Text)))
                        {
                            rowIndex = row.Index;
                            dgvView.CurrentCell = dgvView.Rows[rowIndex].Cells[0];
                            dgvView.Rows[dgvView.CurrentCell.RowIndex].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        private void dgvView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boC.DtrCode = dgvView[colDtrCod, dgvView.CurrentCell.RowIndex].Value.ToString().Trim();
                this.Dispose();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }
        private void setDgvH()
        {
            dgvView.AllowUserToAddRows = false;
            dgvView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt;
            //dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colDtrCod].Width = 80;
            dgvView.Columns[colDtrName].Width = 300;
            dgvView.Columns[colTypeName].Width = 140;
            dgvView.Columns[colCatName].Width = 100;
            dgvView.Columns[colMedicalField].Width = 150;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colDtrCod].HeaderText = "รหัส";
            dgvView.Columns[colDtrName].HeaderText = "ชื่อ-นามสกุล";
            dgvView.Columns[colTypeName].HeaderText = "ประเภทแพทย์";
            dgvView.Columns[colCatName].HeaderText = "ชนิดแพทย์";
            dgvView.Columns[colMedicalField].HeaderText = "สาขาแพทย์";

            Font font = new Font("Microsoft Sans Serif", 10);

            dgvView.Font = font;
            //dgvView.Visible = false;
        }
        private void setLvH()
        {
            lV.View = View.Details;
            lV.FullRowSelect = true;
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                lV.Items.Add(item);
            }
            ListViewItem itm;
            
        }
        private void setDgv()
        {
            DataTable dt = new DataTable();
            dt = boC.dtrDB.selectAll();
            dgvView.RowCount = dt.Rows.Count;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dgvView[colRow, i].Value = (i + 1);
                dgvView[colDtrCod, i].Value = dt.Rows[i]["code"].ToString().Trim();
                dgvView[colDtrName, i].Value = dt.Rows[i]["dtr_fname_t"].ToString().Trim()+" "+ dt.Rows[i]["dtr_sname_t"].ToString().Trim();
                dgvView[colTypeName, i].Value = boC.getDtrTypName( dt.Rows[i]["dtr_typ_code"].ToString().Trim());
                dgvView[colCatName, i].Value = boC.getDtrCatName(dt.Rows[i]["dtr_cat_code"].ToString().Trim());
                dgvView[colMedicalField, i].Value = boC.getMedecalFieldName(dt.Rows[i]["dtr_medical_field"].ToString().Trim());
            }
        }
    }
}
