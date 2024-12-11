using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMM.Pages;
using System.Threading.Tasks;
using System.IO;

namespace DMM
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private MemoryStream ma;

        public Main()
        {
            InitializeComponent();
            LoadHomePage();
        }


        // void for Load home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }


        // Load Page
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                pn_container.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(Page);
            }
            catch { }

        }

        private void LoadHomePage()
        {
            Page_Home page = new Page_Home();
            LoadPage(page);
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            Page_Suppliers page = new Page_Suppliers();
            LoadPage(page);
        }

        private async void Main_Activated(object sender, EventArgs e)
        {
            BL.UPDATE uPDATE = new BL.UPDATE();

           await Task.Run(()=> uPDATE.SupplierDataUpdate());

            await Task.Run(() => uPDATE.CustomerDataUpdate());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Page_Customer page = new Page_Customer();
            LoadPage(page);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportPage page = new ReportPage();
            LoadPage(page);
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            AnaylisisPage page = new AnaylisisPage();
            LoadPage(page);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            Page_Users page = new Page_Users();
            LoadPage(page);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //FRM_Settings fRM_Settings = new FRM_Settings();
            //fRM_Settings.Show();
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            //AddPage.FRM_UserLogin fRM_User = new AddPage.FRM_UserLogin();
            //fRM_User.Show();
            //this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            //FRM_About fRM_About = new FRM_About();
            //fRM_About.Show();
        }
       
    }
}