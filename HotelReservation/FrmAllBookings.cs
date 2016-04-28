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
   
    public partial class FrmAllBookings : Form
    {
        //Form1 f1 = new Form1();
        AllCustomers myCustomer = new AllCustomers();
        string bookingSelectedID;
        string strcheckIn;
        string strCustID;

        //private FormMediator _frmMediator;
        // Delegate
        public delegate void OnUpdateData();
        //public event OnUpdateData UpdateData;

        Form1 mainFrm;
       // public FrmAllBookings()
       // {
           // InitializeComponent();
           // strCustID = "";
       // }
        //-------------------------------------------------------------------------------------------------------
        public FrmAllBookings(Form1 incomingForm)
        {
            mainFrm = incomingForm;
            InitializeComponent();
            strCustID = "";
        }
        //-------------------------------------------------------------------------------------------------------
        

        //-------------------------------------------------------------------------------------------------------
        private void LoadBookedCustomers()
        {
            myCustomer.dgvBookedCustomers = DGVBookingCustomers;
            myCustomer.CustomerToCheckIn();
        }
        private void FrmAllBookings_Load(object sender, EventArgs e)
        {
            LoadBookedCustomers();
        }
        private void btnXCheckInGuest_Click(object sender, EventArgs e)
        {
            
            string message = "Do you want to check in ?";
            string caption = "Confirmation!";

            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //if (UpdateData != null) UpdateData();
              //  _callingInstance.RefreshRooms();

                myCustomer.UpdateAfterCheckedIn();
                LoadBookedCustomers();
                //mainFrm.strTest = "Im testing";
                //mainFrm.populate();
                mainFrm.RefreshRooms();
                
            }
            
        }
        private void DGVBookingCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = DGVBookingCustomers.Rows[rowIndex];
                myCustomer.customerSelectedIdFromDGV = Convert.ToString(row.Cells[0].Value);
                strCustID = Convert.ToString(row.Cells[0].Value);
                bookingSelectedID  = Convert.ToString(row.Cells[1].Value);
                labelItemCustomerID.Text = "ID " + Convert.ToString(row.Cells[1].Value);
                strcheckIn = Convert.ToString(row.Cells[5].Value);
            }
            catch (Exception)
            {

                MessageBox.Show("Please select customer!");
            }
        }

        private void btnXCancelReservatino_Click(object sender, EventArgs e)
        {
            string message = "Do you want to cancel the reservation?";
            string caption = "Confirmation!";
            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            DialogResult result;
            if (strCustID == "")
            {
                MessageBox.Show("No check in customer !");
            }
            else
            {
                if (strcheckIn == "")
                {
                    result = MessageBox.Show(message, caption, button);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        myCustomer.DeleteCustomer(bookingSelectedID);
                        AllBookings.DeleteBooking(bookingSelectedID);
                        MessageBox.Show("Booking has been canceled !");
                        LoadBookedCustomers();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot cancel the reservation.The customer is currently staying in the hotel.");
                }
            }
            // Only cancel the booking if customer hasnt yet checked in
            //if (strcheckIn == "")
            //{
            //    result = MessageBox.Show(message, caption, button);
            //    if (result == System.Windows.Forms.DialogResult.OK)
            //    {
            //        myCustomer.DeleteCustomer(bookingSelectedID);
            //        AllBookings.DeleteBooking(bookingSelectedID);
            //        LoadBookedCustomers();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Cannot cancel the reservation.The customer is currently staying in the hotel.");
            //}
        }

        private void btnXClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
