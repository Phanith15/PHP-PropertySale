namespace GUI2
{
    partial class FrmAllBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.DGVBookingCustomers = new System.Windows.Forms.DataGridView();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.labelItemCustomerID = new DevComponents.DotNetBar.LabelItem();
            this.btnXCheckInGuest = new DevComponents.DotNetBar.ButtonX();
            this.btnXCancelReservatino = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXClose = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBookingCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Location = new System.Drawing.Point(12, 56);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(650, 237);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.labelItemCustomerID});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.DGVBookingCustomers);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 34);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(650, 203);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // DGVBookingCustomers
            // 
            this.DGVBookingCustomers.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.DGVBookingCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBookingCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVBookingCustomers.Name = "DGVBookingCustomers";
            this.DGVBookingCustomers.Size = new System.Drawing.Size(644, 195);
            this.DGVBookingCustomers.TabIndex = 0;
            this.DGVBookingCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBookingCustomers_CellClick);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Image = global::GUI2.Resource1.checked_in;
            this.superTabItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Orange;
            this.superTabItem1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItem1.SymbolColor = System.Drawing.Color.Blue;
            this.superTabItem1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItem1.Text = "Customer to check in";
            // 
            // labelItemCustomerID
            // 
            this.labelItemCustomerID.Name = "labelItemCustomerID";
            this.labelItemCustomerID.Symbol = "";
            this.labelItemCustomerID.SymbolColor = System.Drawing.Color.Red;
            // 
            // btnXCheckInGuest
            // 
            this.btnXCheckInGuest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCheckInGuest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCheckInGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCheckInGuest.Location = new System.Drawing.Point(66, 323);
            this.btnXCheckInGuest.Name = "btnXCheckInGuest";
            this.btnXCheckInGuest.Size = new System.Drawing.Size(135, 38);
            this.btnXCheckInGuest.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXCheckInGuest.Symbol = "";
            this.btnXCheckInGuest.SymbolColor = System.Drawing.Color.Blue;
            this.btnXCheckInGuest.TabIndex = 4;
            this.btnXCheckInGuest.Text = "Check in Guest";
            this.btnXCheckInGuest.Click += new System.EventHandler(this.btnXCheckInGuest_Click);
            // 
            // btnXCancelReservatino
            // 
            this.btnXCancelReservatino.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCancelReservatino.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCancelReservatino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCancelReservatino.Location = new System.Drawing.Point(257, 323);
            this.btnXCancelReservatino.Name = "btnXCancelReservatino";
            this.btnXCancelReservatino.Size = new System.Drawing.Size(153, 38);
            this.btnXCancelReservatino.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXCancelReservatino.Symbol = "";
            this.btnXCancelReservatino.SymbolColor = System.Drawing.Color.Red;
            this.btnXCancelReservatino.TabIndex = 5;
            this.btnXCancelReservatino.Text = "Cancel Reservation";
            this.btnXCancelReservatino.Click += new System.EventHandler(this.btnXCancelReservatino_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(186, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(269, 29);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.Aqua;
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Wifi-Hotel Check-In";
            // 
            // btnXClose
            // 
            this.btnXClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXClose.Location = new System.Drawing.Point(493, 323);
            this.btnXClose.Name = "btnXClose";
            this.btnXClose.Size = new System.Drawing.Size(120, 38);
            this.btnXClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXClose.Symbol = "";
            this.btnXClose.SymbolColor = System.Drawing.Color.Red;
            this.btnXClose.TabIndex = 7;
            this.btnXClose.Text = "&Close";
            this.btnXClose.Click += new System.EventHandler(this.btnXClose_Click);
            // 
            // FrmAllBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 395);
            this.Controls.Add(this.btnXClose);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.btnXCancelReservatino);
            this.Controls.Add(this.btnXCheckInGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmAllBookings";
            this.ShowIcon = false;
            this.Text = "Booking Customers";
            this.Load += new System.EventHandler(this.FrmAllBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBookingCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.DataGridView DGVBookingCustomers;
        private DevComponents.DotNetBar.ButtonX btnXCheckInGuest;
        private DevComponents.DotNetBar.ButtonX btnXCancelReservatino;
        private DevComponents.DotNetBar.LabelItem labelItemCustomerID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnXClose;
    }
}