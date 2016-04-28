using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    public partial class FrmCheckOut : Form
    {
        AllCustomers myCustomer = new AllCustomers();
        AllRooms myRoom = new AllRooms();

        string bookingIDFK;

        Form1 mainFrm;
        public FrmCheckOut(Form1 callingForm)
        {
            mainFrm = callingForm;
            InitializeComponent();
        }
        private void LoadCustomersToCheckOut()
        {
            myCustomer.dgvCustomerToCheckOut = DGVXCheckOut;
            myCustomer.CustomerToCheckOut();
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            LoadCustomersToCheckOut();
        }

        private void DGVXCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = DGVXCheckOut.Rows[rowIndex];
                myCustomer.custCheckOutSelectedIdFromDGV = Convert.ToString(row.Cells[0].Value);
                bookingIDFK = Convert.ToString(row.Cells[1].Value);
                lblItemCheckOutID.Text = "ID " + Convert.ToString(row.Cells[0].Value);
                // Pass data from datagridview to invoice class
                Invoices.custIDFK = Convert.ToString(row.Cells[0].Value);
                Invoices.bookingReference = Convert.ToString(row.Cells[1].Value); 
                Invoices.firstDateOccupied = Invoices.GetCheckedInDate(Convert.ToString(row.Cells[0].Value));
                Invoices.lastDateOccupied = DateTime.Today;
                Invoices.name = Convert.ToString(row.Cells[2].Value);
                Invoices.roomBooked_Type = myRoom.GetCheckedOutRoomType(Convert.ToString(row.Cells[1].Value));
                Invoices.roomBooked_ID = Convert.ToString(row.Cells[3].Value);
                Invoices.balance_beforeTax = Invoices.GetCheckedOutBalance(Convert.ToString(row.Cells[0].Value));
                Invoices.totalDays = AllBookings.Num_BookingDays();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please select customer to check out !");
            }
           

        }

        private void btnXCheckOut_Click(object sender, EventArgs e)
        {
            string message = "Do you want to check out ?";
            string caption = "Confirmation!";
            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                myCustomer.UpdateAfterCheckedOut();
                AllBookings.DeleteBooking(bookingIDFK);
                LoadCustomersToCheckOut();
                // Open Invoice
                FrmInvoice frmInvoice = new FrmInvoice();
                frmInvoice.ShowDialog(this);
            }       
        }

        private void btnXClose_Click(object sender, EventArgs e)
        {
            mainFrm.RefreshRooms();
            this.Close();
        }
    }
}
