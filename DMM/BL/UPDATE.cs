using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMM.BL
{
  public class UPDATE
    {
        // Database and Tables
        DBDMMEntities db;
        TB_Suppliers tBSuppliers;
        PaymentSupplier tbpayment;
        Debit_Suppliers tbdebit;
        // 
        int id;
        double Payment;
        double Debit;
        double PaymentRs;


        public void SupplierDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();
                var SupplierIDList = db.TB_Suppliers.Select(x => x.ID).ToArray();
                for(int i=0;i< SupplierIDList.Length; i++)
                {
                    id = SupplierIDList[i];          
                        // Get Debit 
                        Debit = (double)db.Debit_Suppliers.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                        Payment = (double)db.PaymentSuppliers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToArray().Sum();
                        PaymentRs = Debit - Payment;
                    tBSuppliers = db.TB_Suppliers.Where(x => x.ID == id).FirstOrDefault();
                    tBSuppliers.Debit = PaymentRs;
                    db.Entry(tBSuppliers).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                      
                    
                }

            }
            catch { }
        }

        public void CustomerDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();
                var SupplierIDList = db.TB_Customers.Select(x => x.ID).ToArray();
                for (int i = 0; i < SupplierIDList.Length; i++)
                {
                    id = SupplierIDList[i];
                    // Get Debit 
                    Debit = (double)db.Debit_Customer.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                    //Payment = (double)db.PyamnetCustomers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToArray().Sum();
                    Payment = (double)db.PaymentCustomers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToArray().Sum();
                    PaymentRs = Debit - Payment;
                    var tBcustomer = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                    tBcustomer.Debit = PaymentRs;
                    db.Entry(tBcustomer).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();


                }

            }
            catch { }
        }
    }
}
