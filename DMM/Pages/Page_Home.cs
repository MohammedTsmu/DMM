using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.Pages
{
    public partial class Page_Home : DevExpress.XtraEditors.XtraUserControl
    {
        private MemoryStream ma;

        public Page_Home()
        {
            InitializeComponent();
        }


        // Timer for Date and Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_datetime.Text = DateTime.Now.ToString();
        }
        private void SetSettings()
        {
            var compname = Properties.Settings.Default.CompanyName;
            var compdes = Properties.Settings.Default.CompanyDec;
            txt_companytitle.Text = compname;
            try
            {
                var imgebyt = Convert.FromBase64String(Properties.Settings.Default.Logo);
                ma = new MemoryStream(imgebyt);
                pictureBox1.Image = Image.FromStream(ma);
            }
            catch { }
        }

        private void Page_Home_Load(object sender, EventArgs e)
        {
            SetSettings();
        }
    }
}