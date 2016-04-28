using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public string strTest;
        int imgIndex = 0; // index of images
        string strRoomID; // get RoomID when click on button represents room
        Button [] array_buttons;
        AllCustomers myCustomer = new AllCustomers();
        public Form1()
        {
            InitializeComponent();
            array_buttons = new Button[24] { btnR1, btnR2, btnR3, btnR4, btnR5, btnR6, btnR7, btnR8, btnR9, btnR10, btnR11, btnR12, btnR13, btnR14, btnR15, btnR16, btnR17, btnR18, btnR19, btnR20, btnR21, btnR22, btnR23, btnR24 };
        }
        public void populate()
        {
            MessageBox.Show(strTest + "This is testing");
        }
        //-------------------------------------------------------------------------------------------------------
        private void LoadTodayCheckInCustomers()
        {
            myCustomer.dgvTodayCheckInCustomers = DGVXTodayCheckInGuests;
            DGVXTodayCheckInGuests.BackgroundColor = Color.Goldenrod;
          //  myCustomer.dgvTodayCheckInCustomers = DGVTodayCheckIn;
            myCustomer.TodayCheckInCustomers();
        }
        //-------------------------------------------------------------------------------------------------------
        private void LoadTodayCheckOutCustomers()
        {
            myCustomer.dgvTodayCheckOutCustomers = DGVXTodayCheckOut;
            DGVXTodayCheckOut.BackgroundColor = Color.Goldenrod;
            DGVCustomerInHouse.BackgroundColor = Color.Goldenrod;
            myCustomer.TodayCheckedOutCustomers();
        }
        //-------------------------------------------------------------------------------------------------------
        private void NumOfTodayCheckIn()
        {
            lblXTodayCheckInGuest.Text = "Today Check in " + "(" + myCustomer.GetNumOfTodayCheckIn() + ")";
        }
        //-------------------------------------------------------------------------------------------------------
        private void NumOfTodayCheckOut()
        {
            lblTodayCheckOutGuest.Text = "Today Check out " + "(" + myCustomer.GetNumOfTodayCheckOut() + ")";
        }
        //-------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check all customer in the system who didnt appear to check in , then remove from the system
            string BookingID = myCustomer.GetBookingIDOfCustomerNotAppearToCheckIN();
            myCustomer.DeleteCustomer(BookingID);
            AllBookings.DeleteBooking(BookingID);

            // Get admin name display on form
            this.Text = "Wifi-Hotel Management System " + " Admin by : " + UserLogin.username;

            // Load today checkin customers
            //LoadTodayCheckInCustomers();
            //LoadTodayCheckOutCustomers();
            //NumOfTodayCheckIn();
            //NumOfTodayCheckOut();

            // Setting
            timer1.Enabled = true;
            //LoadRoomStatus();
            //Load everythings
            RefreshRooms();

        }
        //-------------------------------------------------------------------------------------------------------
        private void LoadRoomStatus(){
           
            int i =0;   
            var RoomDictionary = new Dictionary<string, int>();
            List<string> All_Rooms = new List<string>();
            List<string> Available_Rooms = new List<string>();

            Available_Rooms = AllBookings.GetTodayFreeRoomIDs(); 
            //Available_Rooms = AllBookings.GetFreeRoomIDs();
            All_Rooms = AllBookings.AllRoomIDs;

            // Add all available rooms into a dictionary
            foreach (var room in Available_Rooms)
            {
                RoomDictionary.Add(room.ToString(), 1);
            }
            //foreach (var item in RoomDictionary.Keys)
            //{
               // MessageBox.Show("Room are" + item);  
           // }
            // Iterate through all Rooms and set backcolor to greed if free for today
            // And set backcolor to red if it is being occupied.
            foreach (var  id in All_Rooms)
               {
                   
                   if (RoomDictionary.ContainsKey(id))
                    {
                       // MessageBox.Show("id is " + id);
                        array_buttons[i].BackColor = Color.Green ;
                        array_buttons[i].Text = id;
                    }
                    else
                    {
                        array_buttons[i].BackColor = Color.Red;
                        array_buttons[i].Text = id;
                    }
                    i++;
               }
        }
        //-------------------------------------------------------------------------------------------------------
        public void ActivateLoadingRoomStatus()
        {
            LoadRoomStatus();
        }
        //-------------------------------------------------------------------------------------------------------
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetLogin f3 = new FormSetLogin();
            f3.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemNewLogin_Click(object sender, EventArgs e)
        {
            FormSetLogin f3 = new FormSetLogin();
            f3.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemNewReservation_Click(object sender, EventArgs e)
        {
            FrmNewReservation f4 = new FrmNewReservation();
            f4.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemAllBookings_Click(object sender, EventArgs e)
        {
            FrmAllBookings frmbooking = new FrmAllBookings(this); //Test original is ();
            frmbooking.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Display image slices
            if (imgIndex  == 12)
            {
                imgIndex = 0;
                pictureBoxImages.Image = imageListRooms.Images[imgIndex];
                imgIndex++;    
            }
            else
            {
                pictureBoxImages.Image = imageListRooms.Images[imgIndex];
                imgIndex++;        
            }    
        }
        //-------------------------------------------------------------------------------------------------------
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshRooms();
        }
        //-------------------------------------------------------------------------------------------------------
        
        //-------------------------------------------------------------------------------------------------------
        public void RefreshRooms()
        {
            //MessageBox.Show("Start refreshing");
            LoadRoomStatus();
            LoadTodayCheckInCustomers();
            LoadTodayCheckOutCustomers();
            NumOfTodayCheckIn();
            NumOfTodayCheckOut();
            

        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemNewWalkIn_Click(object sender, EventArgs e)
        {
            FrmAllBookings frmbooking = new FrmAllBookings(this) ; // test , original is ();
            //frmbooking.UpdateData += RefreshRooms;
            frmbooking.ShowDialog(this);
            
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemCheckOut_Click(object sender, EventArgs e)
        {
            FrmCheckOut  frmOut = new FrmCheckOut(this); //Testing, oringinal is ();
            frmOut.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void colorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = colorPickerButton1.SelectedColor;
        }
        //-------------------------------------------------------------------------------------------------------
        
        private void buttonItemReport_Click(object sender, EventArgs e)
        {
            FrmReport frmreport = new FrmReport();
            frmreport.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItem17_Click(object sender, EventArgs e)
        {
            
            frmLogIn frmlogin = new frmLogIn();
            this.Visible = false;
            frmlogin.ShowDialog(this);
            this.Close();
            
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemSetUp_Click(object sender, EventArgs e)
        {
            FrmSetUp frmsetup = new FrmSetUp();
            frmsetup.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemRoomDetails_Click(object sender, EventArgs e)
        {
            FrmRoomDetails frmroomdetail = new FrmRoomDetails();
            frmroomdetail.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void buttonItemUcleanedRooms_Click(object sender, EventArgs e)
        {
            FrmUncleanedRooms frmuncleanedroom = new FrmUncleanedRooms();
            frmuncleanedroom.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void LoadInHouseCustomer()
        {
            myCustomer.dgvInHouseCustomer = DGVCustomerInHouse;
            DGVCustomerInHouse.BackgroundColor = Color.Goldenrod;
            myCustomer.GetInHotelCustomerDetails(strRoomID);
        }
        //-------------------------------------------------------------------------------------------------------
        private void allButtons_Click(object sender, EventArgs e)
        {
            List<string> ListCustomerDetail = new List<string>();
            Button fakebutton = (Button)sender;
            strRoomID = fakebutton.Text;
            LoadInHouseCustomer();
        }
        //-------------------------------------------------------------------------------------------------------
        private void btnItemAllBookedCustomers_Click(object sender, EventArgs e)
        {
            FrmAllBookedCustomers frmAllbookingCusts = new FrmAllBookedCustomers();
            frmAllbookingCusts.ShowDialog(this);
        }
        //-------------------------------------------------------------------------------------------------------
        private void Form1OnResize(object sender, EventArgs e)
        {
            ResizeAllComponents();
        }
        //-------------------------------------------------------------------------------------------------------
        private void ResizeAllComponents()
        {
            double toolStripRatio = 0.13;
            double panel1HeightRatio = 0.58;
            double panel1WidthRatio = 0.33;
            double panel2HeightRatio = 0.58;
            double panel2WidthRatio = 0.38;
            double gridHeightRatio = 0.12;
            double gridWidthRatio = 0.38;
            double picBoxWidthRatio = 0.13;
            double picBoxHeightRatio = 0.25;
            double labelWidthRatio = 0.5;
            double labelHeightRatio = 0.09;
            int formWidth, formHeight;

            formWidth = Form1.ActiveForm.Width;
            formHeight = Form1.ActiveForm.Height;

            toolStrip1.Width = Convert.ToInt32(toolStripRatio * formWidth);
            //Panel1
            panel1.Width = Convert.ToInt32(panel1WidthRatio * formWidth);
            panel1.Height = Convert.ToInt32(panel1HeightRatio * formHeight);
            panel1.Location = new Point(toolStrip1.Width + 1, 132);
            //Panel2
            panel2.Width = Convert.ToInt32(panel2WidthRatio * formWidth);
            panel2.Height = Convert.ToInt32(panel2HeightRatio * formHeight);
            panel2.Location = new Point(160 + toolStrip1.Width + panel1.Width, 133);
            //Grid
            //DGVXTodayCheckInGuests.Height = Convert.ToInt32(gridHeightRatio * formHeight);
            DGVXTodayCheckInGuests.Width = Convert.ToInt32(gridWidthRatio * formWidth);

            //DGVXTodayCheckOut.Height = Convert.ToInt32(gridHeightRatio * formHeight);
            DGVXTodayCheckOut.Width = Convert.ToInt32(gridWidthRatio * formWidth);

            //DGVCustomerInHouse.Height = Convert.ToInt32(gridHeightRatio * formHeight);
            DGVCustomerInHouse.Width = Convert.ToInt32(gridWidthRatio * formWidth);
            //picturebox
            pictureBoxImages.Height = Convert.ToInt32(picBoxHeightRatio * formHeight);
            pictureBoxImages.Width = Convert.ToInt32(picBoxWidthRatio * formWidth);
            //Labels
            //lblXTodayCheckInGuest.Height = Convert.ToInt32(labelHeightRatio * panel2.Height);
            lblXTodayCheckInGuest.Width = Convert.ToInt32(labelWidthRatio * panel2.Width);

           // lblTodayCheckOutGuest.Height = Convert.ToInt32(labelHeightRatio * panel2.Height);
            lblTodayCheckOutGuest.Width = Convert.ToInt32(labelWidthRatio * panel2.Width);
           // lblRoomOccupier.Height = Convert.ToInt32(labelHeightRatio * panel2.Height);
            lblRoomOccupier.Width = Convert.ToInt32(labelWidthRatio * panel2.Width);

            //All Buttons
        }
        //-------------------------------------------------------------------------------------------------------
        private void allbuttons_click(object sender, EventArgs e)
        {
            Button fakebutton = (Button)sender;
            switch (fakebutton.Text)
            {
                case "ROOM1":
                case "ROOM2":
                case "ROOM3":
                case "ROOM4":
                case "ROOM5":
                case "ROOM6":
                case "ROOM7":
                case "ROOM8":
                case "ROOM9":
                case "ROOM10":
                case "ROOM11":
                case "ROOM12":
                case "ROOM13":
                case "ROOM14":
                case "ROOM15":
                case "ROOM16":
                case "ROOM17":
                case "ROOM18":
                case "ROOM19":
                case "ROOM20":
                case "ROOM21":
                case "ROOM22":
                case "ROOM23":
                case "ROOM24":
                
                default: 
                    break ;

            }
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
