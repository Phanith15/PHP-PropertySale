namespace GUI2
{
    partial class FrmInvoice
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookedName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookedID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdPaymentTypes = new System.Windows.Forms.ComboBox();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXPay = new DevComponents.DotNetBar.ButtonX();
            this.btnXPrintReceipt = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(298, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 37);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolColor = System.Drawing.Color.Blue;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Invoice";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(12, 101);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(182, 75);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Phone : 123-456789\r\nEmail : wifi_hotel@hotel.co.nz\r\nWebsite: www.wifi_hotel.com";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Booked by : ";
            // 
            // lblBookedName
            // 
            this.lblBookedName.AutoSize = true;
            this.lblBookedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedName.Location = new System.Drawing.Point(107, 207);
            this.lblBookedName.Name = "lblBookedName";
            this.lblBookedName.Size = new System.Drawing.Size(41, 15);
            this.lblBookedName.TabIndex = 4;
            this.lblBookedName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Booking # : ";
            // 
            // lblBookedID
            // 
            this.lblBookedID.AutoSize = true;
            this.lblBookedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedID.Location = new System.Drawing.Point(589, 179);
            this.lblBookedID.Name = "lblBookedID";
            this.lblBookedID.Size = new System.Drawing.Size(64, 15);
            this.lblBookedID.TabIndex = 8;
            this.lblBookedID.Text = "Reference";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room : ";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.Location = new System.Drawing.Point(589, 197);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(52, 15);
            this.lblRoomID.TabIndex = 10;
            this.lblRoomID.Text = "Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Room Type : ";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(588, 215);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(33, 15);
            this.lblRoomType.TabIndex = 12;
            this.lblRoomType.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Check In Date : ";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(590, 233);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(33, 15);
            this.lblCheckInDate.TabIndex = 14;
            this.lblCheckInDate.Text = "Date";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(91, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(522, 49);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(480, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Balance : ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(580, 394);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(52, 15);
            this.lblBalance.TabIndex = 17;
            this.lblBalance.Text = "Balance";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(590, 252);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(33, 15);
            this.lblCheckOutDate.TabIndex = 20;
            this.lblCheckOutDate.Text = "Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(480, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "Check Out Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date : ";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(107, 228);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(33, 15);
            this.lblPaymentDate.TabIndex = 22;
            this.lblPaymentDate.Text = "Date";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(185, 307);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 23;
            this.txtTaxRate.TextChanged += new System.EventHandler(this.txtTaxRate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tax Rate : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Payment Type :";
            // 
            // cmdPaymentTypes
            // 
            this.cmdPaymentTypes.FormattingEnabled = true;
            this.cmdPaymentTypes.Location = new System.Drawing.Point(416, 305);
            this.cmdPaymentTypes.Name = "cmdPaymentTypes";
            this.cmdPaymentTypes.Size = new System.Drawing.Size(121, 21);
            this.cmdPaymentTypes.TabIndex = 26;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.Location = new System.Drawing.Point(580, 372);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(40, 15);
            this.lblTaxAmount.TabIndex = 28;
            this.lblTaxAmount.Text = "Taxes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(477, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "TaxAmount :";
            // 
            // btnXPay
            // 
            this.btnXPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPay.Location = new System.Drawing.Point(188, 493);
            this.btnXPay.Name = "btnXPay";
            this.btnXPay.Size = new System.Drawing.Size(134, 35);
            this.btnXPay.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXPay.Symbol = "";
            this.btnXPay.SymbolColor = System.Drawing.Color.Red;
            this.btnXPay.TabIndex = 29;
            this.btnXPay.Text = "Pay Now";
            this.btnXPay.Click += new System.EventHandler(this.btnXPay_Click);
            // 
            // btnXPrintReceipt
            // 
            this.btnXPrintReceipt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXPrintReceipt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXPrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPrintReceipt.Image = global::GUI2.Resource1.print;
            this.btnXPrintReceipt.Location = new System.Drawing.Point(416, 493);
            this.btnXPrintReceipt.Name = "btnXPrintReceipt";
            this.btnXPrintReceipt.Size = new System.Drawing.Size(134, 35);
            this.btnXPrintReceipt.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXPrintReceipt.TabIndex = 18;
            this.btnXPrintReceipt.Text = "Print Receipt";
            this.btnXPrintReceipt.Click += new System.EventHandler(this.btnXPrint_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Image = global::GUI2.Resource1.Wifi;
            this.labelX1.Location = new System.Drawing.Point(12, 77);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(242, 18);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.Aqua;
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Wifi-Hotel New Zealand ";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(105, 187);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(75, 15);
            this.lblCustomerID.TabIndex = 31;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Customer ID : ";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(694, 558);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXPay);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdPaymentTypes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnXPrintReceipt);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBookedID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBookedName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInvoice";
            this.ShowIcon = false;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookedName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookedID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBalance;
        private DevComponents.DotNetBar.ButtonX btnXPrintReceipt;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmdPaymentTypes;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.ButtonX btnXPay;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label9;
    }
}