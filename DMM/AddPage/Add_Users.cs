using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.AddPage
{
    public partial class Add_Users : DevExpress.XtraEditors.XtraForm
    {
        // DataBase and Tables
        DBDMMEntities db;
        TB_Users tbAdd;
       public DMM.Pages.Page_Users page;
        // other var
        public int id;
        public Add_Users()
        {
            InitializeComponent();
        }
        

        // Add Function

        private void Add()
        {
            // Check Empty value
            if (edt_name.Text == "" || edt_username.Text == "" || edt_password.Text == "" || edt_role.SelectedItem==null  )
            { 
                MessageBox.Show("بعض الحقول مطلوبة","بعض الحقول مطلوبة",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                // Check if Add or Edit
                if (id == 0)
                {
                    // Add
                    AddData();
                    ClearData();
                }
                else
                {
                    // Edit
                    EditData();
                }

                // Update Data
                page.LoadData();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_Users
                {
                    FullName = edt_name.Text,
                    UserName = edt_username.Text,
                    Password = edt_password.Text,
                    Role = edt_role.SelectedItem.ToString(),
                    DateT=DateTime.Now
                   
                    
                };
                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("d2186d70-b540-4a5d-ae3e-d7d1d732b6eb");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Edit Data
        private void EditData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_Users
                {
                    ID=id,
                    FullName = edt_name.Text,
                    UserName = edt_username.Text,
                    Password = edt_password.Text,
                    Role = edt_role.SelectedItem.ToString(),
                    DateT = DateTime.Now


                };
                db.Set<TB_Users>().AddOrUpdate(tbAdd);
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("c3041638-7de3-4554-b82a-7ce25b2029e3");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Add void
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
           
        }

        // Add and Close void
        private void btn_addclose_Click(object sender, EventArgs e)
        {
            if(btn_addclose.Text== "اعادة التشغيل +اضافة")
            {
                Add();
                Application.Restart();
            }
            else
            {
                Add();
                Close();
            }
           
        }

        // Clear Value 
        private void ClearData()
        {
            edt_password.Text = edt_name.Text = edt_name.Text = "";
        }

        private void Add_Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btn_addclose.Text == "اعادة التشغيل +اضافة")
            {
              
                Application.Exit();
            }
        }
    }
}