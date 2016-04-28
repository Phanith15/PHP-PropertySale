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
    public partial class FrmAllBookedCustomers : Form
    {
        AllCustomers myCustomer = new AllCustomers();
        string bookingSelectedID;
        string strCustID;
        public FrmAllBookedCustomers()
        {
            InitializeComponent();
            strCustID = "";
        }
        private void LoadAllBookingCustomersNotYetCheckedIn()
        {
            AllBookings.dgvBookingCustomersNotYetCheckIn = DGVAllbookedCustomers;
            
            DGVAllbookedCustomers.BackgroundColor = Color.Goldenrod;
            AllBookings.BookingCustomersNotYetCheckIn();
        }

        private void FrmAllBookedCustomers_Load(object sender, EventArgs e)
        {
            LoadAllBookingCustomersNotYetCheckedIn();
        }

        private void btnXDeleteReservation_Click(object sender, EventArgs e)
        {
            string message = "Do you want to cancel the booking?";
            string caption = "Confirmation!";
            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            DialogResult result;

            if (strCustID == "")
            {
                MessageBox.Show("No booking customer has been selected !");
            }
            else
            {
                result = MessageBox.Show(message, caption, button);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    myCustomer.DeleteCustomer(bookingSelectedID);
                    AllBookings.DeleteBooking(bookingSelectedID);
                    MessageBox.Show("Booking has been canceled !");
                    LoadAllBookingCustomersNotYetCheckedIn();
                }
                
            }

            
        }

        private void DGVAllbookedCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = DGVAllbookedCustomers.Rows[rowIndex];
                myCustomer.customerSelectedIdFromDGV = Convert.ToString(row.Cells[0].Value);
                strCustID = Convert.ToString(row.Cells[0].Value);
                bookingSelectedID = Convert.ToString(row.Cells[2].Value);
                this.Text = strCustID;

            }
            catch (Exception)
            {

                MessageBox.Show("Please select customer !"); 
            }
        }

        private void btnXClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
