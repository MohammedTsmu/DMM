using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DMM
{
    public partial class FRM_Start : SplashScreen
    {
        DBDMMEntities db;
        int state;
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2024-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private int CheckStartApp()
        {
            try
            {
                db = new DBDMMEntities();
                var usernameid = db.TB_Users.Select(x => x.ID).FirstOrDefault();
                if (usernameid > 0)
                {
                   
                    state = 1;
                }
                else
                {
                    
                    state = 2;

                }

            }
            catch
            {
                state = 0;
            }


            return state;
        }

        private async void FRM_Start_Load(object sender, EventArgs e)
        {
             await Task.Run(() =>Thread.Sleep(2000));

            labelStatus.Text = "... الاتصال بقاعدة البيانات";
            var st = await Task.Run(() => CheckStartApp());
            if (st == 0)
            {
                MessageBox.Show("هنالك خطأ في الاتصال في السيرفر ");
                Application.Exit();
            }
            else if (st == 1)
            {
                // Show Login
                AddPage.FRM_UserLogin fRM_User = new AddPage.FRM_UserLogin();
                fRM_User.Show();
                this.Hide();
            }
            else
            {
                Pages.Page_Users userpage = new Pages.Page_Users();
                AddPage.Add_Users add = new AddPage.Add_Users();
                add.id = 0;
                add.page = userpage;
                add.btn_add.Visible = false;
                add.btn_addclose.Text = "اعادة التشغيل +اضافة";
                add.Show();
            }

        }
    }
}