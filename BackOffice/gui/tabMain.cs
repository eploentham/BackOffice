using BackOffice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class tabMain : Form
    {
        BackOfficeControl boC;
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);
        Image CloseImage;
        public tabMain()
        {
            //MessageBox.Show("2222", "1111");
            InitializeComponent();
            //MessageBox.Show("2222", "1111");
            initConfig();
        }
        private void initConfig()
        {
            //string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            //string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            //MessageBox.Show("2222","1111");
            boC = new BackOfficeControl();
            //Font ftV1 = new Font(tabControl1.Font.Name,9.75f, FontStyle.Bold);
            //ftV1.f
            //ftV1.Size = 12;
            showMenu();
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml(boC.backColor1);
            //tV1.BackColor = System.Drawing.ColorTranslator.FromHtml(boC.backColor2);
            //tV1.Font = boC.fV1;
            //tV1.ForeColor = Color.White;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TabPage myTabPage = new TabPage("");
            //tabControl1.TabPages.Add(myTabPage);
            dfView frm = new dfView(boC);
            ImportDF frm1 = new ImportDF(boC);
            frm.FormBorderStyle = FormBorderStyle.None;
            //frm.TopLevel = false;
            //frm.Visible = true;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Dock = DockStyle.Fill;
            ////tabControl1.ControlAdded();
            //tabControl1.TabPages[0].Controls.Add(frm);
            AddNewTab(frm1,"");
        }
        private void AddNewTab(Form frm, String label)
        {
            TabPage tab = new TabPage(label);
            tab.SuspendLayout();
            frm.TopLevel = false;
            tab.Width = tC1.Width-10;
            tab.Height = tC1.Height-35;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.Width = tab.Width;
            frm.Height = tab.Height;
            foreach (Control x in frm.Controls)
            {
                if (x is DataGridView)
                {
                    //x.Dock = DockStyle.Fill;
                }
            }
            //tab.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E1E1E");
            frm.Visible = true;

            tC1.TabPages.Add(tab);

            //frm.Location = new Point((tab.Width - frm.Width) / 2, (tab.Height - frm.Height) / 2);
            frm.Location = new Point(0,0);
            tab.ResumeLayout();
            tab.Refresh();
            tC1.SelectedTab = tab;

        }
        private void setResize()
        {
            tC1.Width = this.Width - tV1.Width - 50;
            tC1.Height = this.Height - 70;
            boC.tcW = tC1.Width;
            boC.tcH = tC1.Height;
            //groupBox1.Width = this.Width - 50;
            //pB1.Width = this.Width - 900;
        }

        private void tabMain_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void tabMain_Load(object sender, EventArgs e)
        {
            tC1.DrawMode = TabDrawMode.OwnerDrawFixed;
            CloseImage = (Image)Resource1.rsz_close;
            tC1.Padding = new Point(10, 3);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.tC1.GetTabRect(e.Index);
                r.Offset(2, 2);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.tC1.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

                if (tC1.SelectedIndex >= 0)
                {
                    e.Graphics.DrawImage(img, new Point((r.X - 10) + (this.tC1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
                }

                //if (e.Index == tC1.SelectedIndex)
                //{
                //    e.Graphics.DrawString(title, new Font(tC1.Font, FontStyle.Bold), Brushes.Red, new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
                //}
                //else
                //{
                //    e.Graphics.DrawString(title, tC1.Font, Brushes.Black, new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
                //}
            }
            catch (Exception) { }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tC1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tC1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tC1.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(TabP);
                }
            }
        }
        private void showMenu()
        {
            TreeNode node, node1;
            tV1.Nodes.Add("BackOffice", "Back Office");
            node = tV1.Nodes["BackOffice"].Nodes.Add("ImportData","นำเข้า ข้อมูล");
            node.Nodes.Add("ImportHos","นำเข้า ข้อมูลโรงพยาบาล");
            node.Nodes.Add("ImportDF", "นำเข้า ค่าแพทย์");
            node = tV1.Nodes["BackOffice"].Nodes.Add("DfDoctor", "ค่าแพทย์");
            node.Nodes.Add("DfConfig", "กำหนดเงื่อนไข ค่าแพทย์");
            node.Nodes.Add("DfAdd", "ตรวจข้อมูล ค่าแพทย์");
            node.Nodes.Add("DfMonthly", "ทำค่าแพทย์ ประจำเดือน");
            node.Nodes.Add("DfSpec", "ทำค่าแพทย์ เฉพาะกิจ");
            node1 = node.Nodes.Add("DfReport", "รายงาน ค่าแพทย์ ");
            node1.Nodes.Add("DfReport", "รายงาน");

            node = tV1.Nodes["BackOffice"].Nodes.Add("AR", "ลูกหนี้");
            node.Nodes.Add("AR", "ข้อมูลลูกหนี้");
            tV1.Nodes.Add("CashierCalPatient", "คิดเงิน ผู้ป่วย");
            tV1.Nodes.Add("RegHnSearch", "ค้นหา ผู้ป่วย");
            tV1.Nodes.Add("TestUX", "Test UX");
        }

        private void tV1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name.Equals("ImportHos"))
            {
                ImportHos frm = new ImportHos(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("ImportDF"))
            {
                ImportDF frm = new ImportDF(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("DfConfig"))
            {
                DfConfig frm = new DfConfig(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("DfAdd"))
            {
                DfAdd frm = new DfAdd(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("DfMonthly"))
            {
                DfMonthly frm = new DfMonthly(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("TestUX"))
            {
                TestUX frm = new TestUX(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("CashierCalPatient"))
            {
                CashierCalPatient frm = new CashierCalPatient(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
            else if (e.Node.Name.Equals("RegHnSearch"))
            {
                RegHnSearch frm = new RegHnSearch(boC);
                frm.FormBorderStyle = FormBorderStyle.None;
                AddNewTab(frm, e.Node.Text);
            }
        }
    }
}
