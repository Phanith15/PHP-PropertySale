using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    public partial class FrmInvoice : Form
    {
        AllPayments myPayment = new AllPayments();
        double balance;
        double taxamount;
        public FrmInvoice()
        {
            InitializeComponent();
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            // Disable Print button
            btnXPrintReceipt.Enabled = false;
            // Setting Payment types
            cmdPaymentTypes.Items.Add("Cash");
            cmdPaymentTypes.Items.Add("Eftpos");
            cmdPaymentTypes.Items.Add("Credit");
            cmdPaymentTypes.Items.Add("VISA");
            cmdPaymentTypes.Items.Add("Cheque");
            //Display all info
            lblCustomerID.Text = Invoices.custIDFK;
            lblBookedName.Text = Invoices.name;
            lblPaymentDate.Text  = Convert.ToString( DateTime.Today.ToShortDateString());
            lblBookedID.Text  = Invoices.bookingReference;
            lblRoomID.Text = Invoices.roomBooked_ID;
            lblRoomType.Text = Invoices.roomBooked_Type;
            lblCheckInDate.Text = Convert.ToString( Invoices.firstDateOccupied.ToShortDateString());
            lblCheckOutDate.Text = Convert.ToString( Invoices.lastDateOccupied.ToShortDateString());
            lblBalance.Text ="$ "+ Convert.ToString(Invoices.balance_beforeTax) ;

        }
        private void btnXPrint_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        private void txtTaxRate_TextChanged(object sender, EventArgs e)
        {
            double taxrate;
            try
            {
                taxrate = Convert.ToDouble(txtTaxRate.Text);
                balance = Invoices.balance_beforeTax;
                taxamount = taxrate * balance;
                lblTaxAmount.Text = "$ " + Convert.ToString(taxamount);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input type !");
            }
           
        }

        private void btnXPay_Click(object sender, EventArgs e)
        {
            try
            {
                double totalpayment;
                totalpayment = balance + taxamount;
                Invoices.paymentType = cmdPaymentTypes.SelectedItem.ToString();
                Invoices.taxRate = Convert.ToDouble(txtTaxRate.Text);
                Invoices.taxAmount = taxamount;
                Invoices.paymentTotal = totalpayment;
                Invoices.InsertPayment();
                // Enable Print button
                btnXPrintReceipt.Enabled = true;
                btnXPay.Enabled = false;
                MessageBox.Show("Payment has been saved !");
            }
            catch (Exception)
            {
                MessageBox.Show("Missing data !");
            }
           
        }
        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler (printDocument_PrintPage);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            Font font2 = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Wifi-Hotel New Zealand".PadRight(30), new Font("Courier New", 20), new SolidBrush(Color.Black), startX, startY);
            // Call which payment based on given customer ID
            myPayment.GetPaymentDetail(lblCustomerID.Text);

            // Pass all properties from Payments class to strings
            string strCustomerIDFK = myPayment.custIDFK;
            string strPaymentDate = myPayment.paymentDate.ToShortDateString();
            string strFirstDateOccupied = myPayment.firstdateOccupied.ToShortDateString();
            string strLastDateOccupied = myPayment.lastdateOccupied.ToShortDateString();
            string strPaymentType = myPayment.paymentType;
            string strTotalDay = myPayment.totalDay.ToString();
            string strTaxRate = myPayment.taxRate.ToString();
            string strTaxAmount = string.Format ("{0:c}", myPayment.taxAmount);
            string strPaymentTotal = string.Format("{0:c}", myPayment.paymentTotal);

            List<string> listpayments = new List<string>();
            listpayments.Add(" ");
            listpayments.Add(" ");
            listpayments.Add("CustomerID : " + strCustomerIDFK);
            listpayments.Add("Payment Date : " + strPaymentDate);
            listpayments.Add("First date occupied : " + strFirstDateOccupied );
            listpayments.Add("Last date occupied : " + strLastDateOccupied);
            listpayments.Add("Total day : " + strTotalDay);
            listpayments.Add("--------------------------------------------");
            listpayments.Add("Payment type : " + strPaymentType);
            listpayments.Add("Tax rate : " + strTaxRate);
            listpayments.Add("Tax amount : " + strTaxAmount);
            listpayments.Add("Total payment : " + strPaymentTotal);
            listpayments.Add("--------------------------------------------");
            listpayments.Add(" ");

            //Iterate through the list and print out
            foreach (var item in listpayments)
            {
                graphic.DrawString(item.PadRight(30), font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;
            graphic.DrawString("Total to pay : ".PadRight(30) + string.Format("{0:c}",strPaymentTotal),font2 ,new SolidBrush (Color.Black ),startX ,startY+offset);
        }
    }
}
