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
    public partial class FrmUncleanedRooms : Form
    {
        AllRooms myRoom = new AllRooms();
        string strRoomCheckedOutID;
        public FrmUncleanedRooms()
        {
            InitializeComponent();
        }

        private void LoadUncleandedRooms()
        {
            myRoom.dgvAllUncleanedRooms = DGVUncleanedRooms;
            myRoom.GetUncleanedRooms();
        }

        private void FrmUncleanedRooms_Load(object sender, EventArgs e)
        {
            LoadUncleandedRooms();
        }

        private void DGVUncleanedRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = DGVUncleanedRooms.Rows[rowIndex];
                strRoomCheckedOutID = Convert.ToString(row.Cells[0].Value);
            }
            catch (Exception)
            {

                MessageBox.Show("No room selected !");
            }

        }

        private void DGVUncleanedRooms_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                string message = "The room is dirty.Do you want to get it cleaned up?";
                string caption = "Room Status";
                MessageBoxButtons button = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show(message, caption, button);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    myRoom.UpdateRoomStatus(strRoomCheckedOutID);
                    LoadUncleandedRooms();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please select room to clean !");
            }
        }
    }
}
