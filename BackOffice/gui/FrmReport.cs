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
            boC = boc;
            bitC = new BITHisControl();
            InitializeComponent();
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
        public void setReportQuotation(DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                
                rpt.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\QuotationPrint2.rpt");
                
                rpt.SetDataSource(dt);
                
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                //rpt.SetParameterValue("header1", cc.cp.NameT);
                //rpt.SetParameterValue("header2", reportName);
                //rpt.SetParameterValue("header3", condition);

                //rpt.SetParameterValue("quoNumber", qu.QuoNumber);
                //rpt.SetParameterValue("quoDate", qu.QuoDate);
                //rpt.SetParameterValue("contactName", qu.ContactName);
                //rpt.SetParameterValue("compName", qu.CompName);
                //rpt.SetParameterValue("compAddress1", qu.CompAddress1);
                //rpt.SetParameterValue("compAddress2", qu.CompAddress2);
                //rpt.SetParameterValue("compTaxId", qu.CompTaxId);
                //rpt.SetParameterValue("line1", qu.Line1);
                ////rpt.SetParameterValue("contactName", qu.ContactName);
                //rpt.SetParameterValue("custName", qu.CustName);
                //rpt.SetParameterValue("custAddress", qu.CustAddress);
                //rpt.SetParameterValue("custTel", qu.CustTel);
                //rpt.SetParameterValue("custFax", qu.CustFax);
                //rpt.SetParameterValue("custEmail", qu.CustEmail);
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
                cc.lw.WriteLog("rpt.setReportQuotation Error " + chk);
            }
        }
    }
}
