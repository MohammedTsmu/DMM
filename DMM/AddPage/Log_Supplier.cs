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

namespace DMM.AddPage
{
    public partial class Log_Supplier : DevExpress.XtraEditors.XtraForm
    {

        // DataBase and Tables
        DBDMMEntities db;
        Debit_Suppliers tbAdd;
        PaymentSupplier tbpayment;
        // other varaibles
        int id;
        int SupplierID;
        string PaymnetValue;

        double Payment;
        double Debit;
        double PaymentRs;

        public Log_Supplier()
        {
            InitializeComponent();



        }

        // Load Debit Data
        public void LoadDebitData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl1.DataSource = db.Debit_Suppliers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }
        }

        // Load Payments
        private void LoadPaymentsData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl2.DataSource = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }
        }


        // Load From Page
        private void Log_Supplier_Load(object sender, EventArgs e)
        {
            LoadPaymentsData();
            LoadDebitData();
        }

        private void btn_adddebit_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_edtdebit_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_paymentadd_Click(object sender, EventArgs e)
        {

        }

        private void btn_paymentdelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_paymentedit_Click(object sender, EventArgs e)
        {

        }

        private void btn_paymentprint_Click(object sender, EventArgs e)
        {

        }

        private void btn_logclear_Click(object sender, EventArgs e)
        {

        }

    }
}