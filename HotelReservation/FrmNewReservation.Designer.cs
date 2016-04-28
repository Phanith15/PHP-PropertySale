namespace GUI2
{
    partial class FrmNewReservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookingReference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindRoom = new System.Windows.Forms.Button();
            this.txtNumOfGuest = new System.Windows.Forms.TextBox();
            this.cmbRoomTypes = new System.Windows.Forms.ComboBox();
            this.dateTPBookTo = new System.Windows.Forms.DateTimePicker();
            this.dateTPBookFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVAvailablesRooms = new System.Windows.Forms.DataGridView();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumOfFreeRooms = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailablesRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBookingReference);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnFindRoom);
            this.panel1.Controls.Add(this.txtNumOfGuest);
            this.panel1.Controls.Add(this.cmbRoomTypes);
            this.panel1.Controls.Add(this.dateTPBookTo);
            this.panel1.Controls.Add(this.dateTPBookFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 250);
            this.panel1.TabIndex = 0;
            // 
            // txtBookingReference
            // 
            this.txtBookingReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingReference.Location = new System.Drawing.Point(131, 21);
            this.txtBookingReference.Name = "txtBookingReference";
            this.txtBookingReference.ReadOnly = true;
            this.txtBookingReference.Size = new System.Drawing.Size(100, 20);
            this.txtBookingReference.TabIndex = 10;
            this.txtBookingReference.Click += new System.EventHandler(this.txtBookingReference_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "#Booking Reference";
            // 
            // btnFindRoom
            // 
            this.btnFindRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindRoom.Location = new System.Drawing.Point(111, 202);
            this.btnFindRoom.Name = "btnFindRoom";
            this.btnFindRoom.Size = new System.Drawing.Size(121, 32);
            this.btnFindRoom.TabIndex = 8;
            this.btnFindRoom.Text = "Find Room";
            this.btnFindRoom.UseVisualStyleBackColor = true;
            this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
            // 
            // txtNumOfGuest
            // 
            this.txtNumOfGuest.Location = new System.Drawing.Point(110, 150);
            this.txtNumOfGuest.Name = "txtNumOfGuest";
            this.txtNumOfGuest.Size = new System.Drawing.Size(121, 20);
            this.txtNumOfGuest.TabIndex = 7;
           // this.txtNumOfGuest.TextChanged += new System.EventHandler(this.txtNumOfGuest_TextChanged);
            this.txtNumOfGuest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumOfGuest_KeyDown);
            this.txtNumOfGuest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOfGuest_KeyPress);
            // 
            // cmbRoomTypes
            // 
            this.cmbRoomTypes.FormattingEnabled = true;
            this.cmbRoomTypes.Location = new System.Drawing.Point(110, 119);
            this.cmbRoomTypes.Name = "cmbRoomTypes";
            this.cmbRoomTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomTypes.TabIndex = 6;
            this.cmbRoomTypes.SelectedIndexChanged += new System.EventHandler(this.cmbRoomTypes_SelectedIndexChanged);
            // 
            // dateTPBookTo
            // 
            this.dateTPBookTo.Location = new System.Drawing.Point(110, 86);
            this.dateTPBookTo.Name = "dateTPBookTo";
            this.dateTPBookTo.Size = new System.Drawing.Size(180, 20);
            this.dateTPBookTo.TabIndex = 5;
            // 
            // dateTPBookFrom
            // 
            this.dateTPBookFrom.Location = new System.Drawing.Point(110, 58);
            this.dateTPBookFrom.Name = "dateTPBookFrom";
            this.dateTPBookFrom.Size = new System.Drawing.Size(180, 20);
            this.dateTPBookFrom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Num of Guest ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book-To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book-From";
            // 
            // DGVAvailablesRooms
            // 
            this.DGVAvailablesRooms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGVAvailablesRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAvailablesRooms.Location = new System.Drawing.Point(329, 55);
            this.DGVAvailablesRooms.Name = "DGVAvailablesRooms";
            this.DGVAvailablesRooms.Size = new System.Drawing.Size(364, 207);
            this.DGVAvailablesRooms.TabIndex = 1;
            this.DGVAvailablesRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAvailablesRooms_CellClick);
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(12, 275);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(142, 32);
            this.btnCreateNewCustomer.TabIndex = 2;
            this.btnCreateNewCustomer.Text = "Create New Customer";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.Location = new System.Drawing.Point(12, 333);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(142, 32);
            this.btnCreateReservation.TabIndex = 3;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(191, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of Free Rooms";
            // 
            // txtNumOfFreeRooms
            // 
            this.txtNumOfFreeRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOfFreeRooms.Location = new System.Drawing.Point(446, 29);
            this.txtNumOfFreeRooms.Name = "txtNumOfFreeRooms";
            this.txtNumOfFreeRooms.ReadOnly = true;
            this.txtNumOfFreeRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfFreeRooms.TabIndex = 6;
            // 
            // FrmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 417);
            this.Controls.Add(this.txtNumOfFreeRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.btnCreateNewCustomer);
            this.Controls.Add(this.DGVAvailablesRooms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNewReservation";
            this.ShowIcon = false;
            this.Text = "New Reservation";
            this.Load += new System.EventHandler(this.FrmNewReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailablesRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOfGuest;
        private System.Windows.Forms.ComboBox cmbRoomTypes;
        private System.Windows.Forms.DateTimePicker dateTPBookTo;
        private System.Windows.Forms.DateTimePicker dateTPBookFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVAvailablesRooms;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindRoom;
        private System.Windows.Forms.TextBox txtBookingReference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumOfFreeRooms;

    }
}