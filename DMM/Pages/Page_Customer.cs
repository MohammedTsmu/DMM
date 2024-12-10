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
using System.Data.Entity;

namespace DMM.Pages
{
    public partial class Page_Customer : DevExpress.XtraEditors.XtraUserControl
    {
        // DataBase and Tables
        DBDMMEntities db;
        TB_Customers tbAdd;
        int id;
        public Page_Customer()
        {
            InitializeComponent();
            LoadData();

        }



        // Load Data

        public void LoadData()
        {
            DMM.DBDMMEntities dbContext = new DMM.DBDMMEntities();
            dbContext.TB_Customers.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Customers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DMM.AddPage.Add_Customer add = new AddPage.Add_Customer();
            add.id = 0;
            add.btn_add.Text = "اضافة";
            add.btn_addclose.Text = " غلق +اضافة";
            add.page = this;
            add.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    tbAdd = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                    DMM.AddPage.Add_Customer add = new AddPage.Add_Customer();
                    add.id = id;
                    add.btn_add.Text = "تعديل";
                    add.btn_addclose.Text = " غلق +تعديل";
                    add.edt_name.Text = tbAdd.FullName;
                    add.edt_address.Text = tbAdd.Address;
                    add.edt_phone.Text = tbAdd.Phone;
                    add.page = this;
                    add.Show();

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء, لايمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DBDMMEntities();
                        tbAdd = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                        db.TB_Customers.Remove(tbAdd);
                        db.SaveChanges();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    tbAdd = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                    DMM.AddPage.Log_Customer add = new AddPage.Log_Customer();
                    add.txt_id.Text = id.ToString();
                    add.txt_name.Text = tbAdd.FullName.ToString();
                    add.Show();

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}