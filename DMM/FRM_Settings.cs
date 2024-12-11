using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DMM
{
    public partial class FRM_Settings : DevExpress.XtraEditors.XtraForm
    {
        MemoryStream ma;
        private DBDMMEntities db;

        public FRM_Settings()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        ///Load default settings
        private void SetSettings()
        {
            var compname = Properties.Settings.Default.CompanyName;
            var compdes = Properties.Settings.Default.CompanyDec;
            txt_name.Text = compname;
            txt_desc.Text = compdes;
            try
            {
                var imgebyt =Convert.FromBase64String( Properties.Settings.Default.Logo);
                ma = new MemoryStream(imgebyt);
                pic_logo.Image = Image.FromStream(ma);


            }
            catch { }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.CompanyName = txt_name.Text;
            Properties.Settings.Default.CompanyDec = txt_desc.Text;
            try
            {
                ma = new MemoryStream();
                pic_logo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.Logo = Convert.ToBase64String(ma.ToArray());
            }
            catch { }
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات بنجاح");
        }

        private void FRM_Settings_Load(object sender, EventArgs e)
        {
            SetSettings();
        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    pn_progress.Visible = true;

                    var result = await Task.Run(() => BackUp(folder)); // Time
                    if (result == true)
                    {
                        MessageBox.Show("تم النسخ الاحتياطي بنجاح");
                        pn_progress.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("خطأ , لا يمكن النسخ الاحتياطي الى المسار المحدد, الرجاء تحديد مسار مختلف, تذكر لا تحدد القرص C");
                        pn_progress.Visible = false;

                    }
                }
            }
            catch
            {
                MessageBox.Show("خطأ , لا يمكن النسخ الاحتياطي الى المسار المحدد, الرجاء تحديد مسار مختلف, تذكر لا تحدد القرص C");
                pn_progress.Visible = false;

            }
        }
        private bool BackUp(FolderBrowserDialog folder)
        {
            try
            {
                db = new DBDMMEntities();

                string dbname = db.Database.Connection.Database;
                //string dbBackUp = "DMMback" + DateTime.Now.ToString("yyyyMMddHHmm");
                string dbBackUp = "DMMback_" + DateTime.Now.ToString("_yyyy_MM_dd_HHmm");
                var fullpath = folder.SelectedPath.ToString() + dbBackUp + ".bak";
                string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT,  NAME = N'DBMDD', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));
                
                return true;
            }
            catch
            {
                return false;

            }
        }

        private async void btn_restore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog folder = new OpenFileDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    pn_progress.Visible = true;

                    var result = await Task.Run(() => Restore(folder));
                    if (result == true)
                    {
                        pn_progress.Visible = false;
                        MessageBox.Show("تم اعادة النسخة الاحتياطية بنجاح");

                    }
                    else
                    {
                        pn_progress.Visible = false;
                        MessageBox.Show("خطأ , لايمكن استعادة النسخة الاحتياطية , قم بتجربة تشغيل البرنامج كمسؤول حتى تتمكن من اتمام العملية ");

                    }
                }
            }
            catch (Exception ex)
            {
                pn_progress.Visible = false;
                MessageBox.Show("خطأ , لايمكن استعادة النسخة الاحتياطية , قم بتجربة تشغيل البرنامج كمسؤول حتى تتمكن من اتمام العملية ");

            }
        }

        private bool Restore(OpenFileDialog folder)
        {
            try
            {
                db = new DBDMMEntities();

                string dbname = db.Database.Connection.Database;
                string sqlCommand = @"Use master;Restore DATABASE [{0}] From  DISK = '" + folder.FileName + "'";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}