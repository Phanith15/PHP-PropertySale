using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    public static class AllBookings
    {
        //public static string custSelectedId_fromDgv;
        public static DataGridView dgvAvailableRooms = new DataGridView ();
        public static  DataGridView dgvBookingCustomersNotYetCheckIn = new DataGridView();
        public static DateTime bookedFrom { get; set; }
        public static DateTime bookedTo { get; set; }
        public static int numOfGuest { get; set; }
        public static int numOfBookingDays { get; set; }
        public static  string roomBookedID { get; set; }
        public static  string bookingReference { get; set; }
        public static  double roomCost { get; set; }
        public static string roomType { get; set; }
        // This property is used to determined if a form is closed
        public static Boolean isFrmCustomerClosed { get; set; }
        // This property is used to determinded if a button createcustomer is clicked
        public static Boolean isbtnCreateCustomerClicked { get; set; }
        public static List<string> AllRoomIDs;
        // This function is to generate a random string with size of 6
        public static string GenerateRandomIDs()
        {
            string strHolds = "ABCDEFGHIJKLMNOPQRSTVUWXYZ0123456789";
            int size = 6;
            Random rnd = new Random();
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                strBuild.Append(strHolds.Substring(rnd.Next(strHolds.Length), 1));
            }
            return strBuild.ToString();
        }
        public static Boolean InsertBooking()
        {
            string message = "Cannot add the same reference number!";
            string caption = "Error";
            MessageBoxButtons button = MessageBoxButtons.OK;
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var booking = new Booking();
                    booking.BookedID = bookingReference;
                    booking.RoomIDFK = roomBookedID;
                    booking.RoomType = roomType;
                    booking.FromDate = bookedFrom;
                    booking.ToDate = bookedTo;
                    booking.Cost = roomCost;
                    context.Bookings.Add(booking);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(message, caption, button);
                return false;
            }     
        }
        public static List<string> GetTodayFreeRoomIDs()
        {
            List<string> allToday_FreeRooms;
            using (var context = new HotelFinalProjectEntities1())
            {
                // Get all bookedrooms
                var allBookedRooms = context.Bookings.Where(b => b.FromDate == DateTime.Today || b.FromDate <DateTime.Today && DateTime .Today <b.ToDate)
                   .Select(r => new { r.RoomIDFK, r.FromDate, r.ToDate }).ToList();
                // Get all rooms
                var allRooms = context.Rooms.Select(r => r.RoomID);
                allToday_FreeRooms = new List<string>(allRooms.ToList());
                AllRoomIDs = new List<string>(allRooms.ToList());
                // Remove bookedroom from all rooms
                foreach (var bookedroom in allBookedRooms )
                {
                    //if (allToday_FreeRooms.Contains(Convert .ToString(bookedroom.RoomIDFK )) || bookedroom.FromDate<=DateTime.Today && DateTime.Today<=bookedroom.ToDate){
                    if (allToday_FreeRooms.Contains(Convert .ToString(bookedroom.RoomIDFK ))){
                        allToday_FreeRooms .Remove (Convert.ToString (bookedroom .RoomIDFK));
                    }
                }
                return allToday_FreeRooms;
            }
        }
        /*
         * Get all room types
         */
        public static HashSet<string> GetRoomTypes()
        {
            // Use HashSet as it stores no duplicate items
            HashSet<string> allRoomTypes;
            using (var context = new HotelFinalProjectEntities1())
            {
                var type = context.Rooms.Select(t => t.RoomType);
                allRoomTypes = new HashSet<string>(type.ToList());
            }
            return allRoomTypes;
        }
        /*
         * Return room rate for room type SingleBed
         */
        private static int SingleBed_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where (t=>t.RoomType =="Single").Select(r => r.Rate).ToList ();
                foreach (var item in rate )
                {
                    roomrate = item.Value ;
                }
                
                return roomrate;
            }    
        }
        /*
        * Return room rate for room type DoubleBed
        */
        private static int DoubleBed_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where(t => t.RoomType == "Double").Select(r => r.Rate).ToList();

                foreach (var item in rate )
                {
                    roomrate = item.Value;
                }
                return roomrate;
            }
        }
        /*
       * Return room rate for room type Twin
       */
        private static int Twin_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where(t => t.RoomType == "Twin").Select(r => r.Rate).ToList();
                foreach (var item in rate)
                {
                    roomrate = item.Value;
                }
                return roomrate;
            }
        }
        /*
       * Return room rate for room type Quad
       */
        private static int Quad_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where(t => t.RoomType == "Quad").Select(r => r.Rate).ToList();

                foreach (var item in rate )
                {
                    roomrate = item.Value;
                }
                return roomrate;
            }
        }
        /*
       * Return room rate for room type QueenBed
       */
        private static int Queen_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where(t => t.RoomType == "Queen").Select(r => r.Rate).ToList();
                
                foreach (var item in rate)
                {
                    roomrate = item.Value;
                }
                return roomrate;
            }
        }
        /*
       * Return room rate for room type Studio
       */
        private static int Studio_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where(t => t.RoomType == "Studio").Select(r => r.Rate).ToList();
                
                foreach (var item in rate)
                {
                    roomrate = item.Value;
                }
                return roomrate;
            }
        }
        /*
       * Return room rate for room type Suite
       */
        private static int Suite_Rate()
        {
            int roomrate = 0;
            using (var context = new HotelFinalProjectEntities1())
            {
                var rate = context.Rooms.Where(t => t.RoomType == "Suite").Select(r => r.Rate).ToList();
                
                foreach (var item in rate)
                {
                    roomrate = item.Value;
                }
                return roomrate;
            }
        }
        public static  List<string> GetFreeRoomIDs()
        {
            List<string> allFreeRooms;
            using (var context = new HotelFinalProjectEntities1())
            {
                // Get all bookedrooms
                var allBookedRooms = context.Bookings.Where(b => b.FromDate >= DateTime.Today || b.FromDate <= DateTime.Today && DateTime.Today <= b.ToDate)
                    .Select(r => new { r.RoomIDFK, r.FromDate, r.ToDate });
                // Get all rooms
                var allRooms = context.Rooms.Select(r => r.RoomID);
                //Create a list of all free rooms
                allFreeRooms = new List<string>(allRooms.ToList());
                foreach (var bookedroom in allBookedRooms )
                {
                    // Remove unavailable room from all rooms
                    if ((bookedroom.FromDate <= bookedFrom && bookedFrom < bookedroom.ToDate) || (bookedFrom > bookedroom.FromDate && bookedTo <= bookedroom.ToDate || bookedFrom < bookedroom.FromDate && bookedTo >= bookedroom.ToDate)||(bookedroom.FromDate <bookedFrom && bookedFrom <bookedroom.ToDate && bookedroom .ToDate <bookedTo))
                    {
                        if (allFreeRooms.Contains(Convert.ToString(bookedroom.RoomIDFK)))
                        {
                            allFreeRooms.Remove(Convert.ToString(bookedroom.RoomIDFK));
                        }
                    }
                }
                return allFreeRooms;
            }
        }
        public static int TotalNumberFreeRooms()
        {
            int numOfRooms;
            List<string> FreeRooms = new List<string>();
            FreeRooms = GetFreeRoomIDs();
            numOfRooms = FreeRooms.Count;
            return numOfRooms;
        }
        /*
         * This function will return the number of booking days
         */
        public static int Num_BookingDays()
        {
            TimeSpan  diffDays;
            double   differentInDays;
            int Days;

            diffDays = bookedTo - bookedFrom;
            differentInDays = diffDays.TotalDays ;
            Days = Convert.ToInt32( Math.Round(differentInDays, 0));
            if (Days < 0)
            {
                return Days * (-1);
            }
            else if (Days == 0)
            {
                return 1;
            }

            else
            {
                return Days;
            }

            
        }
        public static void AvailableRooms()
        {
            //dgvAvailableRooms = new DataGridView();
            List<string> allRoomsIDs = new List<string>();
            allRoomsIDs = GetFreeRoomIDs();
            using (var context = new HotelFinalProjectEntities1())
            {
                var freeroom = context.Rooms.Where(r => allRoomsIDs.Contains(r.RoomID))
                    .Select(l => new { l.RoomID, l.RoomType, l.Rate });
                dgvAvailableRooms.DataSource = freeroom.ToList();    
            }
        }
        /*
         * This function will return booking cost
         */
        public static double BookingCost(string bookedroomtype)
        {
            double chargingPrice = 0;
            int numberOfStayingDays = Num_BookingDays();
          
            bookedroomtype = roomType;
            switch (bookedroomtype)
            {
                case "Single":
                    chargingPrice = numOfGuest*(numberOfStayingDays * SingleBed_Rate());
                    break;
                case "Double":
                    chargingPrice = numOfGuest *(numberOfStayingDays * DoubleBed_Rate());
                    break;
                case "Twin":
                    chargingPrice = numOfGuest *(numberOfStayingDays * Twin_Rate());
                    break;
                case "Quad":
                    chargingPrice = numOfGuest *(numberOfStayingDays * Quad_Rate());
                    break;
                case "Queen":
                    chargingPrice = numOfGuest *(numberOfStayingDays * Queen_Rate());
                    break;
                case "Studio":
                    chargingPrice = numOfGuest *(numberOfStayingDays * Studio_Rate());
                    break;
                case "Suite":
                    chargingPrice = numOfGuest *(numberOfStayingDays * Suite_Rate());
                    break;
            }
            return chargingPrice;
        }

        public  static void DeleteBooking(string booking_id)
        {
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var booking = (from b in context.Bookings where b.BookedID == booking_id select b).SingleOrDefault();
                    context.Bookings.Remove(booking);
                    context.SaveChanges();
                   // MessageBox.Show("Booking with ID " + booking_id + " has been successfully removed.");
                }
            }
            catch (Exception)
            {

               // MessageBox.Show("Please select Booking Id to cancel the reservation!");
            }
        }
        /*
        * This will show all booking customers who made the booking 
        */
        public static void BookingCustomersNotYetCheckIn()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var customer = context.Customers.Where(c => c.BookedFromDate >= DateTime.Today && c.CheckIn.Equals(null)).Select(c => new { c.CustomerID, c.FirstName, c.BookedIDFK, c.BookedFromDate, c.BookedToDate });
                dgvBookingCustomersNotYetCheckIn.DataSource = customer.ToList();
            }
        }
    }
}
