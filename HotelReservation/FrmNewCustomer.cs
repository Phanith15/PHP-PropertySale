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
    
    public partial class FrmNewCustomer : Form
    {
        AllCustomers myCustomer = new AllCustomers();
        Boolean  isClicked = false;
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            txtBookingIDFK.Text = AllBookings.bookingReference;
            txtBookedRoom.Text = AllBookings.roomBookedID;
        }

        private void btnCreateCustomer1_Click(object sender, EventArgs e)
        {
            isClicked = true;
            myCustomer.customerID = txtGuestID.Text;
            myCustomer.bookedIDFK = txtBookingIDFK.Text;
            myCustomer.firstName = txtFname.Text;
            myCustomer.lastName = txtLname.Text;
            myCustomer.address = txtAddress.Text;
            myCustomer.phone = txtPhone.Text;
            myCustomer.licence = txtDriverLicense.Text;
            myCustomer.gender = txtGender.Text;
            myCustomer.city = txtCity.Text;
            myCustomer.country = txtCountry.Text;
            myCustomer.bookedFromDate = AllBookings.bookedFrom;
            myCustomer.bookedToDate  = AllBookings.bookedTo;
            myCustomer.balance = AllBookings.BookingCost(AllBookings.roomType);
            myCustomer.InsertCustomer();
            MessageBox.Show("CustomerID " + txtGuestID.Text + " is added.");

        }

        private void btnCloseCustForm_Click(object sender, EventArgs e)
        {
            string message = "Do you want to cancel creating cumstomer?";
            string caption = "Warning";
            MessageBoxButtons button = MessageBoxButtons.YesNo ;
            DialogResult result;
            if (isClicked == false)
            {
                result = MessageBox.Show(message, caption, button);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    txtGuestID.Focus();
                }
            }
            else
            {
                AllBookings.isbtnCreateCustomerClicked = true;
                this.Close();
            }
            //AllBookings.isbtnCreateCustomerClicked = true;
            //this.Close();
        }

        private void txtGuestID_Click(object sender, EventArgs e)
        {
            // Receive a random generated string from the class AllBookings
            txtGuestID.Text = AllBookings.GenerateRandomIDs();
        }

        private void txtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtLname.Focus();
            }
        }

        private void txtLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtGender.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys .Left)
            {
                txtFname.Focus();
            }
        }

        private void txtGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtAddress.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys .Left)
            {
                txtLname.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtPhone.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys .Left)
            {
                txtGender.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtDriverLicense.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys .Left )
            {
                txtAddress.Focus();
            }
        }

        private void txtDriverLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtCity.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                txtPhone.Focus();
            }
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtCountry.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left )
            {
                txtDriverLicense.Focus();
            }
        }

        private void txtCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                btnCreateCustomer1.Focus();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys .Left)
            {
                txtCity.Focus();
            }
        }

       

        private void txtGuestID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                txtFname.Focus();
            }
        }
    }
}
