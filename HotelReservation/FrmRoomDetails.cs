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
    public partial class FrmRoomDetails : Form
    {
        AllRooms myRoom = new AllRooms();
        public FrmRoomDetails()
        {
            InitializeComponent();
        }
        private void  LoadRoomInfo(){
            myRoom.dgvAllRooms = DGVRoomDetails;
            myRoom.GetAllRoomDetails ();
        }

        private void FrmRoomDetails_Load(object sender, EventArgs e)
        {
            LoadRoomInfo();
        }
    }
}
