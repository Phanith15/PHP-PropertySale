using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
   public class AllRooms
    {
       public DataGridView dgvAllRooms = new DataGridView();
       public DataGridView dgvAllUncleanedRooms = new DataGridView();
        public string bookingIDFK { get; set; }
        public int roomRate { get; set; }

       /*
        * This function will return a checked out room type
        */
        public string GetCheckedOutRoomType(string booked_id)
        {
            string roomtype = "";
            using (var context = new HotelFinalProjectEntities1())
            {
                var room = context.Bookings.Where(t => t.BookedID == booked_id).Select(r => r.RoomType).ToList();
                foreach (var item in room)
                {
                    roomtype = item;
                }
            }
            return roomtype;
        }
       /*
        * Get all room details
        */
        public void GetAllRoomDetails()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var room = context.Rooms.Select(r => new { r.RoomID, r.RoomType, r.Rate });
                dgvAllRooms.DataSource = room.ToList();
            }
        }
       /*
        * This function below will update the room rate ,
        * If user wants to change the room cost
        */
        public void UpdateRoomRate(string room_Type)
        {
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var update = context.Rooms.Where(r => r.RoomType == room_Type);
                    foreach (var item in update)
                    {
                        item.Rate = roomRate;
                    }
                    
                    context.SaveChanges();
                    MessageBox.Show("Room " + room_Type + " has been updated !");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
       /*
        * Update room status after it was cleaned up
        */
        public void UpdateRoomStatus(string checkedout_roomID)
        {
            try
            {
                using (var context = new HotelFinalProjectEntities1())
                {
                    var update = context.Customers.Where(r => r.RoomBooked == checkedout_roomID);
                    foreach (var item in update)
                    {
                        item.RoomStatus = "Clean";
                    }
                    context.SaveChanges();
                    MessageBox.Show("Room " + checkedout_roomID + " is now clean !");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
       /*
        * Get all uncleaned rooms
        */
        public void GetUncleanedRooms()
        {
            using (var context = new HotelFinalProjectEntities1())
            {
                var room = context.Customers.Where(r => r.CheckOut == DateTime.Today && r.RoomStatus.Equals(null)).Select(o => new { o.RoomBooked, o.CheckIn, o.CheckOut });
                dgvAllUncleanedRooms.DataSource = room.ToList();
            }
        }
        
    }
}
