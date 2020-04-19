using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Configuration;
using System.Threading;

namespace ForSBO.ChildForm
{
    public partial class frmBQDY : Form
    {
        public frmBQDY()
        {
            InitializeComponent();
        }

        private string currDYJ;
        private void frmBQDY_Load(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument();
            string sDefault = print.PrinterSettings.PrinterName;//默认打印机名

            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                cmbDYJ.Items.Add(sPrint);
                if (sPrint == sDefault)
                {
                    currDYJ = sPrint;
                    cmbDYJ.SelectedIndex = cmbDYJ.Items.IndexOf(sPrint);
                }
            }
            dgData.AutoGenerateColumns = false;
            cmbDYFS.SelectedIndex = 0;
        }

        private void cmbBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZT.Text == "")
            {
                MessageBox.Show("请选择账套！");
                return;
            }
            strDYBS = "";
            BS = "";

            cmbName.DataSource = null;
            cmbCode.DataSource = null;
            cmbBH.DataSource = null;
            cmbPH.DataSource = null;
            dgData.DataSource = null;

            if (cmbBM.Text == "")
            {
                return;
            }

            switch (cmbBM.Text)
            {
                case "原材料仓库":
                    strDYBS = ConfigurationManager.AppSettings["YCL"].Trim().Split('|')[0];
                    break;
                case "压制车间":
                    strDYBS = ConfigurationManager.AppSettings["YZ"].Trim().Split('|')[0];
                    break;
                case "整形车间":
                    strDYBS = ConfigurationManager.AppSettings["ZX"].Trim().Split('|')[0];
                    break;
                case "包装车间":
                    strDYBS = ConfigurationManager.AppSettings["BZ"].Trim().Split('|')[0];
                    break;
                case "成品仓库":
                    strDYBS = ConfigurationManager.AppSettings["CP"].Trim().Split('|')[0];
                    break;
            }
            DataSet ds;
            ds = new ClassLibraryWithCliff.OperateDataBase().GetData(SetSQL(), JH_JM_ZT);
            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("没有相关数据！");
                return;
            }
            else
            {
                SetDisplay(ds);
            }
        }

        private void SetDisplay(DataSet ds)
        {
            for (int i = 0; i < ds.Tables.Count; i++)
                ds.Tables[i].Rows.InsertAt(ds.Tables[i].NewRow(), 0);

            cmbCode.DisplayMember = "ItemCode";
            cmbCode.DataSource = ds.Tables[0];
            cmbName.DisplayMember = "ItemName";
            cmbName.DataSource = ds.Tables[1];
            cmbBH.DisplayMember = "BAK3";
            cmbBH.DataSource = ds.Tables[2];
            if (cmbBM.Text != "压制车间")
            {
                cmbPH.DisplayMember = cmbBM.Text == "包装车间" ? "BAK5" : "bath";
                cmbPH.DataSource = ds.Tables[3];
            }
        }

        private string strDYBS;
        private string SetSQL()
        {
            string strSQL = "";
            switch (cmbBM.Text)
            {
                case "原材料仓库":
                    strSQL = @"select distinct ItemCode from B_CODE where ItemCode <> '' and DYBS = '" + strDYBS + @"' order by ItemCode 
                                select distinct ItemName from B_CODE where ItemName <> '' and DYBS = '" + strDYBS + @"' order by ItemName
                                select distinct BAK3 from B_CODE where BAK3 <> '' and DYBS = '" + strDYBS + @"' and LEN(BAK3) > 2  order by BAK3
                                select distinct bath from B_CODE where bath <> '' and DYBS = '" + strDYBS + @"'  order by bath";
                    break;
                case "压制车间":
                    strSQL = @"select distinct ItemCode from B_CODE where ItemCode <> '' and DYBS = '" + strDYBS + @"' order by ItemCode 
                                select distinct ItemName from B_CODE where ItemName <> '' and DYBS = '" + strDYBS + @"' order by ItemName
                                select distinct BAK3 from B_CODE where BAK3 <> '' and DYBS = '" + strDYBS + @"' and LEN(BAK3) > 2   order by BAK3";
                    break;
                case "整形车间":
                    strSQL = @"select distinct ItemCode from B_CODE where ItemCode <> '' and DYBS = '" + strDYBS + @"' order by ItemCode 
                                select distinct ItemName from B_CODE where ItemName <> '' and DYBS = '" + strDYBS + @"' order by ItemName
                                select distinct BAK3 from B_CODE where BAK3 <> '' and DYBS = '" + strDYBS + @"' and LEN(BAK3) > 2   order by BAK3
                                select distinct bath from B_CODE where bath <> '' and DYBS = '" + strDYBS + @"'  order by bath";
                    break;
                case "包装车间":
                    strSQL = @"select distinct ItemCode from B_CODE where ItemCode <> '' and DYBS = '" + strDYBS + @"' order by ItemCode 
                                select distinct ItemName from B_CODE where ItemName <> '' and DYBS = '" + strDYBS + @"' order by ItemName
                                select distinct BAK3 from B_CODE where BAK3 <> '' and DYBS = '" + strDYBS + @"' and LEN(BAK3) > 2   order by BAK3
                                select distinct BAK5 from B_CODE where BAK5 <> '' and DYBS = '" + strDYBS + @"'  order by BAK5";
                    break;
                case "成品仓库":
                    strSQL = @"select distinct ItemCode from B_CODE where ItemCode <> '' and DYBS = '" + strDYBS + @"' order by ItemCode 
                                select distinct ItemName from B_CODE where ItemName <> '' and DYBS = '" + strDYBS + @"' order by ItemName
                                select distinct BAK3 from B_CODE where BAK3 <> '' and DYBS = '" + strDYBS + @"' and LEN(BAK3) > 2   order by BAK3
                                select distinct bath from B_CODE where bath <> '' and DYBS = '" + strDYBS + @"'  order by bath";
                    break;
            }


            return strSQL;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (dgData.Rows.Count <= 0) return;
            if (dgData.Rows.Count > int.Parse(ConfigurationManager.AppSettings["BQKZCount"].ToString()))
            {
                MessageBox.Show("当前要打印的标签数量是: " + dgData.Rows.Count + ".\r\n超出打印限制数量，系统不予打印！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgData.Rows.Count > int.Parse(ConfigurationManager.AppSettings["BQTSCount"].ToString()))
            {
                DialogResult result = MessageBox.Show("当前要打印的标签数量是: " + dgData.Rows.Count + ".\r\n是否继续打印？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
            }


            String IDS = "";
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                if (IDS == "")
                    IDS = dgData.Rows[i].Cells[0].Value.ToString();
                else
                    IDS += "," + dgData.Rows[i].Cells[0].Value.ToString();
            }

            string str = "SELECT * FROM B_CODE WHERE ID IN (" + IDS + ")";
            string printFile = AppDomain.CurrentDomain.BaseDirectory + JH_JM_File + @"\" + BS + ".btw";

            ClassLibraryWithCliff.BarTenderPrint bt = new ClassLibraryWithCliff.BarTenderPrint();

            int DYFS = int.Parse(cmbDYFS.Text);
            bt.PrintData(printFile, currDYJ, DYFS, str);
        }

        private void cmbZT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZT.Text == "金恒")
            {
                JH_JM_File = ConfigurationManager.AppSettings["JHBQ"];
                JH_JM_ZT = ConfigurationManager.AppSettings["JH_CS"];
            }
            else if (cmbZT.Text == "骏马")
            {
                JH_JM_File = ConfigurationManager.AppSettings["JMBQ"];
                JH_JM_ZT = ConfigurationManager.AppSettings["JM_CS"];
            }
            else
            {
                JH_JM_File = "";
                JH_JM_ZT = "";
                return;
            }

            cmbBM.SelectedIndex = 0;
            dgData.DataSource = null;
        }


        private string JH_JM_ZT;
        private string JH_JM_File;
        private string DYJ = "";
        private string BS = "";
        private void btnSelectData_Click(object sender, EventArgs e)
        {
            if (cmbZT.Text == "") return;

            lblData.Visible = true;            
            dgData.DataSource = null;
            this.Refresh(); //强制刷新界面，以显示等待标签

            DYJ = "";
            BS = "";

            switch (cmbBM.Text)
            {
                case "原材料仓库":
                    DYJ = ConfigurationManager.AppSettings["YCL"].Trim().Split('|')[0];
                    BS = ConfigurationManager.AppSettings["YCL"].Trim().Split('|')[1];
                    break;
                case "压制车间":
                    DYJ = ConfigurationManager.AppSettings["YZ"].Trim().Split('|')[0];
                    BS = ConfigurationManager.AppSettings["YZ"].Trim().Split('|')[1];
                    break;
                case "整形车间":
                    DYJ = ConfigurationManager.AppSettings["ZX"].Trim().Split('|')[0];
                    BS = ConfigurationManager.AppSettings["ZX"].Trim().Split('|')[1];
                    break;
                case "包装车间":
                    DYJ = ConfigurationManager.AppSettings["BZ"].Trim().Split('|')[0];
                    BS = ConfigurationManager.AppSettings["BZ"].Trim().Split('|')[1];
                    break;
                case "成品仓库":
                    DYJ = ConfigurationManager.AppSettings["CP"].Trim().Split('|')[0];
                    BS = ConfigurationManager.AppSettings["CP"].Trim().Split('|')[1];
                    break;
            }
            string tempField = cmbBM.Text == "包装车间" ? "BAK5" : "bath";
            string strSQL = "select * from B_CODE WHERE BarType = '" + BS + "' and DYBS = '" + DYJ + "' and ItemCode like '%" + cmbCode.Text + @"%'  and ItemName like '%" + cmbName.Text + "%' and BAK3 like '%" + cmbBH.Text + "%' and " + tempField + " like '%" + cmbPH.Text + "%'";
            if (cmbBM.Text == "压制车间")
            {
                strSQL = "select * from B_CODE WHERE BarType = '" + BS + "' and DYBS = '" + DYJ + "' and ItemCode like '%" + cmbCode.Text + @"%'  and ItemName like '%" + cmbName.Text + "%' and BAK3 like '%" + cmbBH.Text + "%'";
            }
            ClassLibraryWithCliff.OperateDataBase od = new ClassLibraryWithCliff.OperateDataBase();
            DataSet ds = od.GetData(strSQL, JH_JM_ZT);
            dgData.DataSource = ds.Tables[0];
            lblData.Visible = false;
        }

        private void btnPrintSelect_Click(object sender, EventArgs e)
        {
            if (dgData.Rows.Count <= 0) return;
           
            String IDS = "";
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                if (dgData.Rows[i].Selected == true)
                {
                    if (IDS == "")
                        IDS = dgData.Rows[i].Cells[0].Value.ToString();
                    else
                        IDS += "," + dgData.Rows[i].Cells[0].Value.ToString();
                }
            }
            string str = "SELECT * FROM B_CODE WHERE ID IN (" + IDS + ")";
            string printFile = AppDomain.CurrentDomain.BaseDirectory + JH_JM_File + @"\" + BS + ".btw";

            ClassLibraryWithCliff.BarTenderPrint bt = new ClassLibraryWithCliff.BarTenderPrint();

            int DYFS = int.Parse(cmbDYFS.Text);
            bt.PrintData(printFile, currDYJ, DYFS, str);
        }
    }
}
