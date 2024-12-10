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
using System.Data.Entity.Migrations;
using System.Threading;

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


        // Add Debit Data Event
        private void btn_adddebit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txt_id.Text);
            var SupplierName = txt_name.Text;
            DMM.AddPage.Add_DebitSupplier add = new AddPage.Add_DebitSupplier();
            add.id = 0;
            add.btn_add.Text = "اضافة";
            add.btn_addclose.Text = " غلق +اضافة";
            add.page = this;
            add.SupplierID = id;
            add.SupplierName = SupplierName;
            add.Show();
        }

        // Edit Debit Data Event
        private void btn_edtdebit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    var supplierid = Convert.ToInt32(txt_id.Text);
                    var SupplierName = txt_name.Text;
                    DMM.AddPage.Add_DebitSupplier add = new AddPage.Add_DebitSupplier();
                    add.id = id;
                    add.btn_add.Text = "تعديل";
                    add.btn_addclose.Text = " غلق + تعديل";
                    add.page = this;
                    add.SupplierID = supplierid;
                    add.SupplierName = SupplierName;
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("FullName"));
                    add.edt_debit.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Debit"));
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

        // Delete Debit Data Event
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
                        tbAdd = db.Debit_Suppliers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadDebitData();
                        DebitPaymentCal();
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

        // Debit Data Print Event
        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        // Add Paymnet Data Event
        private void btn_paymentadd_Click(object sender, EventArgs e)
        {
            PaymnetValue = XtraInputBox.Show("اكتب المبلغ المراد دفعة","عمل دفعة","0");
            if(PaymnetValue!="0" && PaymnetValue != "")
            {
                // Make Payment

                AddPayemet();
                LoadPaymentsData();
                MessageBox.Show("تم عمل الدفعة بنجاح");


            }
            else
            {
                MessageBox.Show("اكتب المبلغ المراد دفعة اولا");
            }
        }

        // Add Payment Function
        private void AddPayemet()
        {
            try
            {
                db = new DBDMMEntities();
                SupplierID = Convert.ToInt32(txt_id.Text);
                var SupplierName = txt_name.Text;
                var tbpayment = new PaymentSupplier
                {
                    Payment = Convert.ToDouble(PaymnetValue),
                    SupplierName = SupplierName,
                    ID_Supplier = SupplierID,
                    DateT = DateTime.Now

                };
                db.Entry(tbpayment).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Edti Paymnet Event
        private void btn_paymentedit_Click(object sender, EventArgs e)
        {
            string CurrValue = Convert.ToString(gridView2.GetFocusedRowCellValue("Payment"));

            PaymnetValue = XtraInputBox.Show("اكتب المبلغ المراد دفعة", "عمل دفعة", CurrValue);
            if (PaymnetValue != "0" && PaymnetValue != "")
            {
                // Edit Payment

                EditPayemet();
                LoadPaymentsData();
                MessageBox.Show("تم عمل الدفعة بنجاح");


            }
            else
            {
                MessageBox.Show("اكتب المبلغ المراد دفعة اولا");
            }
        }

        // Edit Payment Function
        private void EditPayemet()
        {
            try
            {
                id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    SupplierID = Convert.ToInt32(txt_id.Text);
                    var SupplierName = txt_name.Text;
                    var tbpayment = new PaymentSupplier
                    {
                        ID = id,
                        Payment = Convert.ToDouble(PaymnetValue),
                        SupplierName = SupplierName,
                        ID_Supplier = SupplierID,
                        DateT = DateTime.Now

                    };
                    db.Set<PaymentSupplier>().AddOrUpdate(tbpayment);
                    db.SaveChanges();
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

        // Delete Payment Event
        private void btn_paymentdelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء, لايمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DBDMMEntities();
                        tbpayment = db.PaymentSuppliers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbpayment).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadPaymentsData();
                        DebitPaymentCal();
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

        // Print Payment Event
        private void btn_paymentprint_Click(object sender, EventArgs e)
        {
            gridControl2.ShowPrintPreview();

        }

        // Cal debit and payment
        private void DebitPaymentCal()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                // Get Debit 
                Debit = (double)db.Debit_Suppliers.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                Payment = (double)db.PaymentSuppliers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToArray().Sum();
                PaymentRs = Debit - Payment;
                // Set Data
                txt_debit.Text = "الديون :" + Debit.ToString();
                txt_payment.Text = "المدفوع :" + Payment.ToString();
                txt_paymentrs.Text = "المتبقي :" + PaymentRs.ToString();
            }
            catch { }
        }

        private void Log_Supplier_Activated(object sender, EventArgs e)
        {
            DebitPaymentCal();
        }

        private async void btn_logclear_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء, لايمكن استرجاع البيانات", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                // Loading .....
                this.Text = "الرجاء الانتظار بينما يتم تنظيف السجل...";
                Thread.Sleep(2000);
                // Clear Debit
                this.Text = "تنظيف سجل الديون ...";
                Thread.Sleep(1000);
                await Task.Run(() => LogDebitClearData());
                // Clear Payment
                this.Text = "تنظيف الدفعات  ...";
                Thread.Sleep(1000);
                await Task.Run(() => LogPaymentClearData());
                MessageBox.Show("تم تنظيف السجل بنجاح");
                this.Text = "سجل الموردين";
                LoadPaymentsData();
                LoadDebitData();
            }
               
        }

        // Clear Debit Data
        private void LogDebitClearData()
        {
            try
            {
                id = Convert.ToInt16(txt_id.Text);
                db = new DBDMMEntities();
                var Debit_List = db.Debit_Suppliers.Select(x => x.ID).ToArray();

                for(int i = 0; i < Debit_List.Length; i++)
                {
                    tbAdd = db.Debit_Suppliers.Where(x => x.ID_Supplier == id).FirstOrDefault();
                    db.Entry(tbAdd).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                

            }
            catch { }
        }

        // Clear Payment Data
        private void LogPaymentClearData()
        {
            try
            {
                id = Convert.ToInt16(txt_id.Text);
                db = new DBDMMEntities();
                var Debit_List = db.PaymentSuppliers.Select(x => x.ID).ToArray();

                for (int i = 0; i < Debit_List.Length; i++)
                {
                    tbpayment = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).FirstOrDefault();
                    db.Entry(tbpayment).State = EntityState.Deleted;
                    db.SaveChanges();
                }


            }
            catch { }
        }
    }
}