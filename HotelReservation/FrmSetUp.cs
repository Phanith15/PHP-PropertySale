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
    public partial class FrmSetUp : Form
    {
        AllRooms myRoom = new AllRooms();
        string strroomType;
        public FrmSetUp()
        {
            InitializeComponent();
        }

        private void btnXSetPrice_Click(object sender, EventArgs e)
        {
            try
            {
                myRoom.roomRate = Convert.ToInt32(txtXRoomPrice.Text);
                myRoom.UpdateRoomRate(strroomType);
                LoadRooms();
            }
            catch (Exception)
            {
                MessageBox.Show("Please entry new room cost !");
            }
            

        }
        private void LoadRooms()
        {
            myRoom.dgvAllRooms = DGVRoomSetUp;
            myRoom.GetAllRoomDetails();
        }

        private void FrmSetUp_Load(object sender, EventArgs e)
        {
            // Load room
            LoadRooms();
        }

        private void DGVRoomSetUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = DGVRoomSetUp.Rows[rowIndex];
                strroomType = Convert.ToString(row.Cells[1].Value);
                txtXRoomPrice.Text  = Convert.ToString(row.Cells[2].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select room type to set up new price !");
            }
        }

        
    }
}
