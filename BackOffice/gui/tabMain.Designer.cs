namespace BackOffice
{
    partial class tabMain
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
            this.tC1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tV1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tC1
            // 
            this.tC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tC1.Location = new System.Drawing.Point(236, 12);
            this.tC1.Name = "tC1";
            this.tC1.SelectedIndex = 0;
            this.tC1.Size = new System.Drawing.Size(861, 701);
            this.tC1.TabIndex = 0;
            this.tC1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tC1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tV1
            // 
            this.tV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tV1.Location = new System.Drawing.Point(12, 72);
            this.tV1.Name = "tV1";
            this.tV1.Size = new System.Drawing.Size(218, 408);
            this.tV1.TabIndex = 2;
            this.tV1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tV1_NodeMouseDoubleClick);
            // 
            // tabMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1109, 725);
            this.Controls.Add(this.tV1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tC1);
            this.Name = "tabMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tabMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tabMain_Load);
            this.Resize += new System.EventHandler(this.tabMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tC1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView tV1;
    }
}