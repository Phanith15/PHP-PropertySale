using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    class FormMediator
    {
        private FrmAllBookings frmAllBookings;
        private Form1 f1;

        public FormMediator(FrmAllBookings frmAllBookings, Form1 f1)
        {
            // TODO: Complete member initialization
            this.frmAllBookings = frmAllBookings;
            this.f1 = f1;
        }
        private Form frmMain { get; set; }
        private Form frmCheckIn { get; set; }

        public void InitializeMediator()
        {
            frmCheckIn.FormClosed += frmMain_FrmClosed;
        }
        public void frmMain_FrmClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Refresh();
        }
       

    }
}
