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
    public partial class FrmNewReservation : Form
    {
       // AllCustomers myCustomer;
        string roomIDFK;
        // Selected room type from the comboBox
        string room_Type;
        public FrmNewReservation()
        {
            InitializeComponent();
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Enable button create new reservation
                btnCreateReservation.Enabled = true;
                // set isbtnCreateCustomerClicked to true, this mean this button was Clicked
                AllBookings.isbtnCreateCustomerClicked = true;

                // Pass BookingRef and RoomID to AllBooking class
                if (txtBookingReference.Text == "" || txtNumOfGuest.Text == "")
                {
                    MessageBox.Show("Please enter requred fields !");
                }
                else
                {
                    AllBookings.bookingReference = txtBookingReference.Text;
                    AllBookings.roomBookedID = roomIDFK;
                    AllBookings.numOfGuest = Convert.ToInt32(txtNumOfGuest.Text);
                    FrmNewCustomer frmCustomer = new FrmNewCustomer();
                    frmCustomer.ShowDialog(this);
                    btnCreateNewCustomer.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input type !");
            }
             
        }
        public void AllAvailabeRooms()
        {
            AllBookings.dgvAvailableRooms  = DGVAvailablesRooms;
            AllBookings.AvailableRooms();
        }

        private void btnFindRoom_Click(object sender, EventArgs e)
        {
            string message = "Booking to-date must be greater than booking from-date !";
            string caption = "Error";
            MessageBoxButtons button = MessageBoxButtons.OK;
            AllBookings.bookedFrom = dateTPBookFrom.Value;
            AllBookings.bookedTo = dateTPBookTo.Value ;

            // Testing to find days diff
            this.Text = Convert.ToString(AllBookings.Num_BookingDays());

            if (dateTPBookTo.Value.ToShortDateString () == dateTPBookFrom.Value.ToShortDateString())
            {
                MessageBox.Show(message ,caption ,button );
            }
            else
            {
                int differentDays = dateTPBookTo.Value.Day - dateTPBookFrom.Value.Day ;
                AllAvailabeRooms();
                // Set isbtnCreateCustomerClicked to false
                AllBookings.isbtnCreateCustomerClicked = false;
                txtNumOfFreeRooms.Text = Convert.ToString(AllBookings.TotalNumberFreeRooms());
            }
            
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            Boolean insertedSuccess;
            string message = "Please create new customer first!";
            string caption = "Reservation Failed";
            MessageBoxButtons button = MessageBoxButtons.OK;
            if (AllBookings .isbtnCreateCustomerClicked == true  )
            {
                //AllBookings.roomType = Convert.ToString(cmbRoomTypes.SelectedItem);
                AllBookings.bookedFrom = dateTPBookFrom.Value;
                AllBookings.bookedTo = dateTPBookTo.Value;
                AllBookings.roomCost = AllBookings.BookingCost(room_Type);
                insertedSuccess = AllBookings.InsertBooking();
                if (insertedSuccess == true)
                {
                    AllBookings.isbtnCreateCustomerClicked = false; // Reset button create customer to false
                    txtBookingReference.Text = "";
                    txtNumOfGuest.Text = "";
                    txtNumOfFreeRooms.Text = "";
                    cmbRoomTypes.SelectedItem = "";
                    MessageBox.Show("Booking Reference " + txtBookingReference.Text + " is added.");
                }
                else
                {
                    AllBookings.isbtnCreateCustomerClicked = false; // Reset button create customer to false
                    txtBookingReference.Text = "";
                    txtNumOfGuest.Text = "";
                    txtNumOfFreeRooms.Text = "";
                    cmbRoomTypes.SelectedItem = "";
                    MessageBox.Show("Insert booking failed");
                }
                
            }
            else
            {
                MessageBox.Show(message, caption, button);
            }
            
           
        }

        private void FrmNewReservation_Load(object sender, EventArgs e)
        {
            //Disable some buttons
            btnCreateNewCustomer.Enabled = false;
            btnCreateReservation.Enabled = false;
            // Get all room types from the table
            HashSet<string> room_types = new HashSet<string>();
            room_types = AllBookings.GetRoomTypes();
            // Add room types into the combobox
            foreach (var type in room_types)
            {
                cmbRoomTypes.Items.Add(type);
            }
            
        }

        private void DGVAvailablesRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int count = 0;
                int rowIndex = e.RowIndex;
                DataGridViewRow  row = DGVAvailablesRooms.Rows[rowIndex];
                roomIDFK = Convert.ToString(row.Cells[0].Value);
                this.Text = Convert.ToString(roomIDFK );
                //Enable button create new customer
                btnCreateNewCustomer.Enabled = true;
                for (count = 0; count < DGVAvailablesRooms.RowCount; count++)
                {
                    if (DGVAvailablesRooms.Rows[count].Cells[1].FormattedValue .Equals (room_Type ))
                    {
                        DGVAvailablesRooms.Rows[count].DefaultCellStyle.BackColor = Color.LawnGreen;
                    }
                }
                    
            }
            catch (Exception)
            {

                MessageBox.Show("Please select room number to book !");
            }
        }

        private void cmbRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get room type based on the selection from the comboBox
            room_Type = Convert.ToString (cmbRoomTypes .SelectedItem ) ;
            AllBookings.roomType = room_Type;
            this.Text = room_Type;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.ActivateLoadingRoomStatus();
            this.Close();
        }

        private void txtBookingReference_Click(object sender, EventArgs e)
        {
            // Receive a random generated string from the class AllBookings
            txtBookingReference.Text = AllBookings.GenerateRandomIDs();
        }

        private void txtNumOfGuest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindRoom.Focus();
            }
        }

        // Allow user to enter numerical numbers only and Backspace key
        private void txtNumOfGuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >='0' && e.KeyChar <='9' || e.KeyChar == (char)Keys.Back  ){
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
