using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI2
{
    class AllPayments
    {
        public string empIDFK { get; set; }
        public string custIDFK { get; set; }
        public DateTime paymentDate { get; set; }
        public DateTime firstdateOccupied { get; set; }
        public DateTime lastdateOccupied { get; set; }
        public string paymentType { get; set; }
        public int totalDay { get; set; }
        public double taxRate { get; set;}
        public double taxAmount { get; set; }
        public double paymentTotal { get; set; }

        /*
         * This method is get the payment details based on customer ID
         */
        public void GetPaymentDetail(string cust_ID)
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var payment = (from o in context.Payments
                               where o.CustomerIDFK == cust_ID
                               select o).ToList();
                foreach (var item in payment)
                {
                    custIDFK = item.CustomerIDFK;
                    paymentDate = Convert.ToDateTime(item.PaymentDate);
                    firstdateOccupied = Convert.ToDateTime(item.FirstDateOccupied);
                    lastdateOccupied = Convert.ToDateTime(item.LastDateOccupied);
                    paymentType = item.PaymentType;
                    totalDay = Convert.ToInt32(item.TotalDays);
                    taxRate = Convert.ToDouble(item.TaxRate);
                    taxAmount = Convert.ToDouble(item.TaxAmount);
                    paymentTotal = Convert.ToDouble(item.PaymentTotal);
                }
            }
        }

    }
}
