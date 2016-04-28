namespace GUI2
{
    partial class FrmNewCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseCustForm = new System.Windows.Forms.Button();
            this.txtBookingIDFK = new System.Windows.Forms.TextBox();
            this.txtBookedRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateCustomer1 = new System.Windows.Forms.Button();
            this.txtDriverLicense = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloseCustForm);
            this.groupBox1.Controls.Add(this.txtBookingIDFK);
            this.groupBox1.Controls.Add(this.txtBookedRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateCustomer1);
            this.groupBox1.Controls.Add(this.txtDriverLicense);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.txtGuestID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 406);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Information Form";
            // 
            // btnCloseCustForm
            // 
            this.btnCloseCustForm.Location = new System.Drawing.Point(181, 348);
            this.btnCloseCustForm.Name = "btnCloseCustForm";
            this.btnCloseCustForm.Size = new System.Drawing.Size(75, 31);
            this.btnCloseCustForm.TabIndex = 33;
            this.btnCloseCustForm.Text = "&Close";
            this.btnCloseCustForm.UseVisualStyleBackColor = true;
            this.btnCloseCustForm.Click += new System.EventHandler(this.btnCloseCustForm_Click);
            //this.btnCloseCustForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCloseCustForm_KeyDown);
            // 
            // txtBookingIDFK
            // 
            this.txtBookingIDFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingIDFK.Location = new System.Drawing.Point(116, 53);
            this.txtBookingIDFK.Name = "txtBookingIDFK";
            this.txtBookingIDFK.ReadOnly = true;
            this.txtBookingIDFK.Size = new System.Drawing.Size(140, 22);
            this.txtBookingIDFK.TabIndex = 10;
            // 
            // txtBookedRoom
            // 
            this.txtBookedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookedRoom.Location = new System.Drawing.Point(116, 78);
            this.txtBookedRoom.Name = "txtBookedRoom";
            this.txtBookedRoom.ReadOnly = true;
            this.txtBookedRoom.Size = new System.Drawing.Size(140, 22);
            this.txtBookedRoom.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Room-ID";
            // 
            // btnCreateCustomer1
            // 
            this.btnCreateCustomer1.Location = new System.Drawing.Point(32, 348);
            this.btnCreateCustomer1.Name = "btnCreateCustomer1";
            this.btnCreateCustomer1.Size = new System.Drawing.Size(119, 31);
            this.btnCreateCustomer1.TabIndex = 30;
            this.btnCreateCustomer1.Text = "&Create Customer";
            this.btnCreateCustomer1.UseVisualStyleBackColor = true;
            this.btnCreateCustomer1.Click += new System.EventHandler(this.btnCreateCustomer1_Click);
            //this.btnCreateCustomer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCreateCustomer1_KeyDown);
            // 
            // txtDriverLicense
            // 
            this.txtDriverLicense.Location = new System.Drawing.Point(116, 232);
            this.txtDriverLicense.Name = "txtDriverLicense";
            this.txtDriverLicense.Size = new System.Drawing.Size(140, 22);
            this.txtDriverLicense.TabIndex = 29;
            this.txtDriverLicense.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDriverLicense_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Driver License";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(116, 283);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(140, 22);
            this.txtCountry.TabIndex = 17;
            this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountry_KeyDown);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(116, 258);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(140, 22);
            this.txtCity.TabIndex = 16;
            this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(116, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 22);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 22);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(116, 154);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(140, 22);
            this.txtGender.TabIndex = 13;
            this.txtGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGender_KeyDown);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(116, 129);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(140, 22);
            this.txtLname.TabIndex = 12;
            this.txtLname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLname_KeyDown);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(116, 103);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(140, 22);
            this.txtFname.TabIndex = 11;
            this.txtFname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFname_KeyDown);
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(116, 28);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.ReadOnly = true;
            this.txtGuestID.Size = new System.Drawing.Size(140, 22);
            this.txtGuestID.TabIndex = 9;
            this.txtGuestID.Click += new System.EventHandler(this.txtGuestID_Click);
            this.txtGuestID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuestID_KeyDown);
            //this.txtGuestID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestID_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Phone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Gender";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Last Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "First Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Reference-ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Customer-ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Reservation";
            // 
            // FrmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 525);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewCustomer";
            this.ShowIcon = false;
            this.Text = "New Reservation";
            this.Load += new System.EventHandler(this.FrmNewCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateCustomer1;
        private System.Windows.Forms.TextBox txtDriverLicense;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtBookingIDFK;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBookedRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseCustForm;
    }
}