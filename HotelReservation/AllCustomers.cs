using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
   public  class AllCustomers
    {
        public DataGridView dgvGuests = new DataGridView();
        public DataGridView dgvBookedCustomers = new DataGridView();
        public DataGridView dgvTodayCheckInCustomers = new DataGridView();
        public DataGridView dgvCustomerToCheckOut = new DataGridView();
        public DataGridView dgvTodayCheckOutCustomers = new DataGridView();
        public DataGridView dgvInHouseCustomer = new DataGridView();
        
        public string  customerID { get; set; }
        public string bookedIDFK { get; set; }
        public string firstName { get; set; }
        public string lastName {get;set;}
        public string address { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string licence { get; set; }
        public int numOfGuest { get; set; }
        public string roomNumber { get; set; }
        public DateTime bookedFromDate { get; set; }
        public DateTime bookedToDate { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public double balance { get; set; }
        public string  customerSelectedIdFromDGV { get; set; }
        public string custCheckOutSelectedIdFromDGV { get; set; }

        private int getNumOfGuest()
        {
            numOfGuest = AllBookings.numOfGuest;
            return numOfGuest;
        }
        private string getRoomNumber()
        {
            roomNumber = AllBookings.roomBookedID;
            return roomNumber;
        }
        public void InsertCustomer()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var customer = new Customer();
                customer.CustomerID = customerID;
                customer.BookedIDFK = bookedIDFK;
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.Address = address;
                customer.Phone = phone;
                customer.City = city;
                customer.Country = country;
                customer.Licence = licence;
                customer.NumberOfGuest = getNumOfGuest();
                customer.RoomBooked = getRoomNumber();
                customer.BookedFromDate = bookedFromDate;
                customer.BookedToDate = bookedToDate;
                //customer.CheckIn = checkInDate;
                //customer.CheckOut = checkOutDate;
                customer.Balance = balance;
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
       /*
        * Get the detail of customer who is in the hotel
        */
        public void GetInHotelCustomerDetails(string room_ID)
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var detail = context.Customers.Where(c => c.RoomBooked == room_ID && c.CheckOut.Equals(null)&&c.BookedToDate>DateTime.Today ).Select(o => new { o.FirstName, o.LastName, o.BookedFromDate, o.BookedToDate }).ToList();
                dgvInHouseCustomer.DataSource = detail;
            }
            
        }
        /*
         * This will show all customers who check in today
         */
        public void TodayCheckInCustomers()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var customer = context.Customers.Where(c => c.CheckIn == DateTime.Today && c.CheckOut.Equals(null)).Select(c => new { c.FirstName, c.LastName, c.RoomBooked, c.Balance });
                dgvTodayCheckInCustomers.DataSource = customer.ToList();
            }
        }
        /*
         * This will show all customer who just checked out today
         */
        public void TodayCheckedOutCustomers()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var customer = context.Customers.Where(c => c.CheckOut == DateTime.Today).Select(c => new { c.FirstName, c.LastName, c.RoomBooked, c.Balance });
                dgvTodayCheckOutCustomers.DataSource = customer.ToList();
            }
        }
        /*
         * This will show all customers who will check in today
         */
        public void CustomerToCheckOut()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var customer = context.Customers.Where(c =>!(c.CheckIn.Equals(null)) && c.CheckOut.Equals(null)).Select(c => new { c.CustomerID, c.BookedIDFK, c.FirstName,c.RoomBooked ,c.BookedToDate, c.CheckIn, c.CheckOut });
                dgvCustomerToCheckOut.DataSource = customer.ToList();
            }
        }
       /*
        * This will show all customers who will check in today
        */
        public void CustomerToCheckIn()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var customer = context.Customers.Where(c => c.BookedFromDate == DateTime.Today && c.CheckOut.Equals(null)).Select(c => new { c.CustomerID,c.BookedIDFK, c.FirstName, c.LastName,c.BookedFromDate , c.CheckIn});
                dgvBookedCustomers.DataSource = customer.ToList();
            }
        }
      
        /*
         * Update customer table after checked in
         */
        public void UpdateAfterCheckedIn()
        {
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var update = context.Customers.Where(c => c.CustomerID == customerSelectedIdFromDGV).First();
                    if (update.CheckIn.Equals(null))
                    {
                        update.CheckIn = DateTime.Today;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("The customer has already checked in !");
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }
        /*
         * Update customer table after checked out
         */
        public void UpdateAfterCheckedOut()
        {
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var update = context.Customers.Where(c => c.CustomerID == custCheckOutSelectedIdFromDGV ).First();
                    if (update.CheckOut.Equals(null))
                    {
                        update.CheckOut = DateTime.Today;
                        // Set Balance to 0 atfter checked out
                        update.Balance = 0.0;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("The customer has already checked out !");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /*
         * Delete customer when the reservation was cancelled
         */
        public void DeleteCustomer(string ID)
        {
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var customer = (from c in context.Customers where c.BookedIDFK == ID select c).SingleOrDefault();
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                   // MessageBox.Show("Customer has been successfully removed.");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Please select customer to cancel the reservation.");
            }
        }
        /*
         * Count number of today checkin
         */
        public int GetNumOfTodayCheckIn()
        {
            int num_CheckIn = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var count = (from o in context.Customers
                             where o.CheckIn == DateTime.Today 
                             select o).Count();
                num_CheckIn = count;

            }
            return num_CheckIn;
        }
        /*
         * Count number of Today check out
         */
        public int GetNumOfTodayCheckOut()
        {
            int num_CheckOut = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var count = (from o in context.Customers
                             where o.CheckOut == DateTime.Today
                             select o).Count();
                num_CheckOut = count;
            }
            return num_CheckOut;
        }
       /*
        * Get the details of customer who didnt appear to check in
        */
        public string GetBookingIDOfCustomerNotAppearToCheckIN()
        {
            string ID = "";
            using (var context = new HotelFinalProjectEntities1())
            {
                var bookingID = context.Customers.Where(c => c.BookedToDate <= DateTime.Today && c.CheckIn.Equals(null) && c.CheckOut.Equals(null)).Select(r => r.BookedIDFK).ToList();
                foreach (var item in bookingID)
                {
                    ID = item.ToString();
                }
            }
            return ID;
        }

    }
}
