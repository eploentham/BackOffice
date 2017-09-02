namespace BackOffice
{
    partial class ImportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDF = new System.Windows.Forms.Button();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.txtUserDB = new System.Windows.Forms.TextBox();
            this.txtNameDB = new System.Windows.Forms.TextBox();
            this.txtHostDB = new System.Windows.Forms.TextBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dtpDailyDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPassDB = new System.Windows.Forms.TextBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDF);
            this.groupBox1.Controls.Add(this.btnTestConnect);
            this.groupBox1.Controls.Add(this.txtUserDB);
            this.groupBox1.Controls.Add(this.txtNameDB);
            this.groupBox1.Controls.Add(this.txtHostDB);
            this.groupBox1.Controls.Add(this.btnHost);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.dtpDailyDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เงื่อนไข";
            // 
            // btnDF
            // 
            this.btnDF.Location = new System.Drawing.Point(286, 20);
            this.btnDF.Name = "btnDF";
            this.btnDF.Size = new System.Drawing.Size(88, 23);
            this.btnDF.TabIndex = 9;
            this.btnDF.Text = "ข้อมูลค่าแพทย์";
            this.btnDF.UseVisualStyleBackColor = true;
            this.btnDF.Click += new System.EventHandler(this.btnDF_Click);
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Location = new System.Drawing.Point(955, 20);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(51, 23);
            this.btnTestConnect.TabIndex = 8;
            this.btnTestConnect.Text = "Test";
            this.btnTestConnect.UseVisualStyleBackColor = true;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // txtUserDB
            // 
            this.txtUserDB.Location = new System.Drawing.Point(742, 20);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Size = new System.Drawing.Size(100, 20);
            this.txtUserDB.TabIndex = 7;
            // 
            // txtNameDB
            // 
            this.txtNameDB.Location = new System.Drawing.Point(636, 20);
            this.txtNameDB.Name = "txtNameDB";
            this.txtNameDB.Size = new System.Drawing.Size(100, 20);
            this.txtNameDB.TabIndex = 6;
            // 
            // txtHostDB
            // 
            this.txtHostDB.Location = new System.Drawing.Point(530, 20);
            this.txtHostDB.Name = "txtHostDB";
            this.txtHostDB.Size = new System.Drawing.Size(100, 20);
            this.txtHostDB.TabIndex = 5;
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(473, 20);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(41, 23);
            this.btnHost.TabIndex = 4;
            this.btnHost.Text = "...";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(380, 20);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // dtpDailyDate
            // 
            this.dtpDailyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDailyDate.Location = new System.Drawing.Point(87, 19);
            this.dtpDailyDate.Name = "dtpDailyDate";
            this.dtpDailyDate.Size = new System.Drawing.Size(112, 20);
            this.dtpDailyDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "วันที่";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "ดึงข้อมูล";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPassDB
            // 
            this.txtPassDB.Location = new System.Drawing.Point(860, 32);
            this.txtPassDB.Name = "txtPassDB";
            this.txtPassDB.Size = new System.Drawing.Size(100, 20);
            this.txtPassDB.TabIndex = 8;
            // 
            // dgvView
            // 
            this.dgvView.AllowDrop = true;
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 83);
            this.dgvView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView.MultiSelect = false;
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(781, 505);
            this.dgvView.TabIndex = 9;
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 627);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.txtPassDB);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImportData_Load);
            this.Resize += new System.EventHandler(this.ImportData_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DateTimePicker dtpDailyDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUserDB;
        private System.Windows.Forms.TextBox txtNameDB;
        private System.Windows.Forms.TextBox txtHostDB;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.TextBox txtPassDB;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnDF;
    }
}

