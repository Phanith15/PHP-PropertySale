using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI2
{
    public static class Invoices
    {
        public static string name { get; set; }
        public static string empIDFK { get; set; }
        public static string custIDFK { get; set; }
        public static string bookingReference { get; set; }
        public static string roomBooked_ID { get; set; }
        public static string roomBooked_Type { get; set; }
        public static DateTime paymentDate { get; set; }
        public static DateTime firstDateOccupied { get; set; }
        public static DateTime lastDateOccupied { get; set; }
        public static string paymentType { get; set; }
        public static int totalDays { get; set; }
        public static double taxRate { get; set; }
        public static double taxAmount { get; set; }
        public static double paymentTotal { get; set; }
        public static double balance_beforeTax { get; set; }

        public static DateTime GetCheckedInDate(string cust_ID)
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                DateTime date = new DateTime ();
                var checkIn_dates = context.Customers.Where(c => c.CustomerID == cust_ID).Select(o => o.CheckIn).ToList();
                foreach (var item in checkIn_dates)
                {
                    date = Convert.ToDateTime(item);
                }
                return date;
            }
        }
        // Maybe dont need this

        public static  DateTime GetCheckedOutDate(string cust_ID)
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                DateTime date = new DateTime();
                var checkIn_dates = context.Customers.Where(c => c.CustomerID == cust_ID).Select(o => o.CheckOut).ToList();
                foreach (var item in checkIn_dates)
                {
                    date = Convert.ToDateTime(item);
                }
                return date;
            }
        }
        public static  double GetCheckedOutBalance(string cust_id)
        {
            double checkedout_balance = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var balance = context.Customers.Where(c => c.CustomerID == cust_id).Select(b => b.Balance).ToList();
                foreach (var item in balance)
                {
                    checkedout_balance = Convert.ToDouble(item);
                }
            } return checkedout_balance;
        }
        public static  void InsertPayment()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                Payment payment = new Payment();
                payment.CustomerIDFK = custIDFK;
                payment.PaymentDate = DateTime.Today;
                payment.FirstDateOccupied = firstDateOccupied;
                payment.LastDateOccupied = lastDateOccupied;
                payment.PaymentType = paymentType;
                payment.TotalDays = totalDays;
                payment.TaxRate = taxRate;
                payment.TaxAmount = taxAmount;
                payment.PaymentTotal = paymentTotal;
                context.Payments.Add(payment);
                context.SaveChanges();
                
            }
            
        }
       
    }
}
