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
    public partial class Add_DebitSupplier : DevExpress.XtraEditors.XtraForm
    {
        // DataBase and Tables
        DBDMMEntities db;
        Debit_Suppliers tbAdd;
       public DMM.AddPage.Log_Supplier page;
        // other var
        public int id;
        public int SupplierID;
        public string SupplierName;
        public Add_DebitSupplier()
        {
            InitializeComponent();
        }
        

        // Add Function

        private void Add()
        {
            // Check Empty value
            if (edt_name.Text == "" || edt_debit.Text=="")
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
                page.LoadDebitData();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new Debit_Suppliers
                {
                    FullName=edt_name.Text,
                    Debit=Convert.ToDouble(edt_debit.Text),
                    SupplierName=SupplierName,
                    ID_Supplier=SupplierID,
                    DateT = DateTime.Now
                    
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
                tbAdd = new Debit_Suppliers
                {
                    ID=id,
                    FullName = edt_name.Text,
                    Debit = Convert.ToDouble(edt_debit.Text),
                    SupplierName = SupplierName,
                    ID_Supplier = SupplierID,
                    DateT = DateTime.Now

                };
                db.Set<Debit_Suppliers>().AddOrUpdate(tbAdd);
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
            Add();
            Close();
        }

        // Clear Value 
        private void ClearData()
        {
            edt_name.Text = edt_name.Text = "";
        }
    }
}