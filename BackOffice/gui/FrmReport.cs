using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class FrmReport : Form
    {
        BackOfficeControl boC;
        BITHisControl bitC;
        HisDB hisDB;
        public FrmReport(BackOfficeControl boc)
        {
            //MessageBox.Show("111", "11");
            boC = boc;
            //MessageBox.Show("22", "11");
            //bitC = new BITHisControl();
            InitializeComponent();
            //MessageBox.Show("33", "11");
        }
        public void setReport(String rptName, String reportName, String condition, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            //DataTable dt1;
            //DataSet ds = new DataSet();
            //if (!sql.Equals(""))
            //{
            //    dt1 = conn.selectData(sql);
            //}
            //else
            //{
            //    dt1 = dt;
            //}

            //string directory = My.Application.Info.DirectoryPath;
            //rpt.Load(directory & "\myCrystalReport1.rpt")
            //rpt.Load(Environment.CurrentDirectory + "\\report\\" + rptName + ".rpt");

            //ConnectionInfo crConnectionInfo = new ConnectionInfo();
            //crConnectionInfo.ServerName = "";
            //crConnectionInfo.DatabaseName = Environment.CurrentDirectory + "\\database\\cemp.mdb";
            //foreach (Table crTable in rpt.Database.Tables)
            //{
            //    TableLogOnInfo crLogOnInfo = crTable.LogOnInfo;
            //    crLogOnInfo.ConnectionInfo = crConnectionInfo;
            //    crTable.ApplyLogOnInfo(crLogOnInfo);
            //    //crTable.Location = crTable.Location;
            //}
            //rpt.DataSourceConnections.Clear();
            //rpt.DataSourceConnections[0].SetConnection("", Environment.CurrentDirectory + "\\database\\cemp.mdb", false);
            //rpt.Database.Tables[0].Location = Environment.CurrentDirectory + "\\database\\cemp.mdb";
            //rpt.Load(Environment.CurrentDirectory + "\\report\\test.rpt");
            try
            {
                
                rpt.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + rptName + ".rpt");
                
                rpt.SetDataSource(dt);
                
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", "");
                rpt.SetParameterValue("header2", reportName);
                rpt.SetParameterValue("header3", condition);
                
                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                
            }

            //rpt.SetParameterValue("CustomerID", this.txtCustomerID.Text);

        }
        private void initConfig(String rptName, String reportName, String condition, String sql, DataSet ds)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                rpt.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + rptName + ".rpt");
                rpt.SetDataSource(ds);
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", "");
                rpt.SetParameterValue("header2", reportName);
                rpt.SetParameterValue("header3", condition);

                //if (rptName.Equals("QuotationPrint"))
                //{
                //    rpt.SetParameterValue("", cc.qu
                //}

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
            }
        }
        public void SetReportReceipt(PrnRecepit prnr, DataTable dt)
        {
            //MessageBox.Show("2222", "11");
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "11");
                rpt.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\receipt.rpt");                
                rpt.SetDataSource(dt);

                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", "");
                rpt.SetParameterValue("compName", "โรงพยาบาลอรวรรณ");
                rpt.SetParameterValue("compAddress1", "8/8 ม.6 ต.แพรกษา อ.เมืองสมุทรปราการ จ.สมุทรปราการ 10280 โทร 02-3342555");
                rpt.SetParameterValue("compAddress2", "8/8 Moo.6 District Mueang Samutprakan, Sub-district Phraek Sa, Samutprakan, 10280 Tel.02-3342555");

                rpt.SetParameterValue("line1", "ใบเสร็จรับเงิน ");
                rpt.SetParameterValue("receiptNumber", prnr.receiptnumber);
                rpt.SetParameterValue("thaibaht", prnr.thaibaht);
                rpt.SetParameterValue("taxName", "เลขประจำตัวผู้เสียภาษี(Tax ID)");
                rpt.SetParameterValue("taxid", "0115555011261");
                rpt.SetParameterValue("date", prnr.date);
                rpt.SetParameterValue("hn", prnr.hn);
                rpt.SetParameterValue("patientFullName", prnr.fullname);
                rpt.SetParameterValue("doctorName", prnr.doctor);
                rpt.SetParameterValue("paidType", prnr.paidtype);
                rpt.SetParameterValue("remark", prnr.remark);
                rpt.SetParameterValue("cashier", "");
                rpt.SetParameterValue("positioncashier", prnr.positioncashier);
                rpt.SetParameterValue("nettotal1", prnr.NetTotal1);
                //rpt.SetParameterValue("line2", qu.Line2);
                //rpt.SetParameterValue("staffName", "ผู้เสนอราคา : " + qu.StaffName);
                //rpt.SetParameterValue("staffName1", "( " + qu.StaffName + " )");
                //rpt.SetParameterValue("staffTel", qu.StaffTel);
                //rpt.SetParameterValue("staffEmail", qu.StaffEmail);
                //rpt.SetParameterValue("remark1", qu.Remark1);
                //rpt.SetParameterValue("remark2", qu.Remark2);
                //rpt.SetParameterValue("remark3", qu.Remark3);
                //rpt.SetParameterValue("remark4", qu.Remark4);
                //rpt.SetParameterValue("remark5", qu.Remark5);
                //rpt.SetParameterValue("remark6", qu.Remark6);
                //rpt.SetParameterValue("remark7", qu.Remark7);

                //rpt.SetParameterValue("line1", qu.Line1);
                //rpt.SetParameterValue("line2", qu.Line2);
                //rpt.SetParameterValue("line3", qu.Line3);
                //rpt.SetParameterValue("line4", qu.Line4);
                //rpt.SetParameterValue("line5", qu.Line5);
                //rpt.SetParameterValue("line6", qu.Line6);
                //rpt.SetParameterValue("staffApproveName", "( " + qu.StaffApproveName + " )");

                //rpt.SetParameterValue("amount2", qu.Amount);

                //if (qu.Discount.Equals("0.00"))
                //{
                //    rpt.SetParameterValue("discount", "-");
                //    rpt.SetParameterValue("discountPer", "");
                //}
                //else if (qu.Discount.Equals("0"))
                //{
                //    rpt.SetParameterValue("discount", "-");
                //    rpt.SetParameterValue("discountPer", "");
                //}
                //else
                //{
                //    //String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(qu.Plus1)));
                //    rpt.SetParameterValue("discount", String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(qu.Discount))));
                //    rpt.SetParameterValue("discountPer", String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(qu.DiscountPer))));
                //}
                //if (qu.DiscountPer.Equals(".00") || qu.DiscountPer.Equals("0.00") || qu.DiscountPer.Equals("0"))
                //{
                //    rpt.SetParameterValue("discountPer", "");
                //}
                //else
                //{
                //    rpt.SetParameterValue("discountPer", qu.DiscountPer);
                //}

                //rpt.SetParameterValue("amountDiscount", qu.AmountDiscount);
                //rpt.SetParameterValue("plus1Name", qu.Plus1Name);
                //if (qu.Plus1.Equals("0.00"))
                //{
                //    rpt.SetParameterValue("plus1", "");
                //}
                //else if (qu.Plus1.Equals("0"))
                //{
                //    rpt.SetParameterValue("plus1", "-");
                //    //rpt.SetParameterValue("discountPer", "");
                //}
                //else
                //{
                //    rpt.SetParameterValue("plus1", String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(qu.Plus1))));
                //}

                //rpt.SetParameterValue("total", qu.Total);
                //rpt.SetParameterValue("vatRate", qu.VatRate);
                //rpt.SetParameterValue("vat", qu.Vat);
                //rpt.SetParameterValue("netTotal", qu.NetTotal);
                //rpt.SetParameterValue("lamount", "รวมราคา");
                //rpt.SetParameterValue("ldiscount", "ส่วนลด");
                //rpt.SetParameterValue("plus1name", "ค่าภาคสนาม(ค่าเดินทาง)");
                //rpt.SetParameterValue("ltotal", "รวมราคา");
                //rpt.SetParameterValue("lvat", "ภาษีมูลค่าเพิ่ม " + qu.VatRate + "%");
                //rpt.SetParameterValue("lnettotal", "ราคารวมทั้งสิ้น");
                //rpt.SetParameterValue("lcustapprove", "อนุมัติสั่งซื้อตามรายการที่เสนอ");
                //rpt.SetParameterValue("lstaffquotation", "ผู้เสนอราคา");
                //rpt.SetParameterValue("lstaffapprove", "ขอแสดงความนับถือ");
                //rpt.SetParameterValue("thaibaht", qu.ThaiBaht);
                //rpt.SetParameterValue("staffApproveposition", cc.sfdb.selectPositionByPk(qu.StaffApproveId));
                //rpt.SetParameterValue("staffposition", cc.sfdb.selectPositionByPk(qu.StaffId));
                //rpt.SetParameterValue("lamountdiscount", "ราคาหลังหักส่วนลด");
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                //cc.lw.WriteLog("rpt.setReportQuotation Error " + chk);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
