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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet1.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.myDataSet1.Customers);

            this.reportViewer1.RefreshReport();
        }
    }
}
