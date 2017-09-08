using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public class TestUX : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        int grd0 = 0, grd1 = 100, grd2 = 240, grd3 = 320, grd4 = 570, grd5 = 650, grd51 = 700, grd6 = 820, grd7 = 900, grd8 = 1070, grd9 = 1200;
        int line1 = 30, line2 = 57, line3 = 85, line4 = 105, line41 = 120, line5 = 270, ControlHeight = 21, lineGap = 5;

        BackOfficeControl boC;

        MaterialLabel lb1, lb2;
        MaterialSingleLineTextField txt1, txt2;
        public TestUX(BackOfficeControl boc)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.FormBorderStyle = FormBorderStyle.None;
            boC = boc;

            initConfig();
        }
        private void initConfig()
        {
            initCompoment();
        }
        private void initCompoment()
        {
            lb1 = new MaterialLabel();
            lb1.Font = boC.fV1;
            lb1.Text = "ประจำเดือน";
            lb1.AutoSize = true;
            Controls.Add(lb1);
            lb1.Location = new System.Drawing.Point(grd2, line3);

            txt1 = new MaterialSingleLineTextField();
            txt1.Font = boC.fV1;
            txt1.Text = "";
            txt1.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txt1);
            txt1.Location = new System.Drawing.Point(grd3, line4);
            //txt1.KeyUp += new KeyEventHandler(txtCode_KeyUp);

            txt2 = new MaterialSingleLineTextField();
            txt2.Font = boC.fV1;
            txt2.Text = "";
            txt2.Size = new System.Drawing.Size(100, ControlHeight);
            Controls.Add(txt2);
            txt2.Location = new System.Drawing.Point(grd5, line4);
        }
    }
}
