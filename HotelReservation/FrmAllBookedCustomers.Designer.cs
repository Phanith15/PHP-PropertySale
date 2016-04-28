namespace GUI2
{
    partial class FrmAllBookedCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVAllbookedCustomers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXDeleteReservation = new DevComponents.DotNetBar.ButtonX();
            this.btnXClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllbookedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAllbookedCustomers
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAllbookedCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVAllbookedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAllbookedCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVAllbookedCustomers.EnableHeadersVisualStyles = false;
            this.DGVAllbookedCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DGVAllbookedCustomers.Location = new System.Drawing.Point(57, 68);
            this.DGVAllbookedCustomers.Name = "DGVAllbookedCustomers";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAllbookedCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVAllbookedCustomers.Size = new System.Drawing.Size(534, 150);
            this.DGVAllbookedCustomers.TabIndex = 0;
            this.DGVAllbookedCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAllbookedCustomers_CellClick);
            // 
            // btnXDeleteReservation
            // 
            this.btnXDeleteReservation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXDeleteReservation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXDeleteReservation.Location = new System.Drawing.Point(162, 243);
            this.btnXDeleteReservation.Name = "btnXDeleteReservation";
            this.btnXDeleteReservation.Size = new System.Drawing.Size(120, 38);
            this.btnXDeleteReservation.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXDeleteReservation.Symbol = "";
            this.btnXDeleteReservation.SymbolColor = System.Drawing.Color.Red;
            this.btnXDeleteReservation.TabIndex = 1;
            this.btnXDeleteReservation.Text = "Delete";
            this.btnXDeleteReservation.Click += new System.EventHandler(this.btnXDeleteReservation_Click);
            // 
            // btnXClose
            // 
            this.btnXClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXClose.Location = new System.Drawing.Point(342, 243);
            this.btnXClose.Name = "btnXClose";
            this.btnXClose.Size = new System.Drawing.Size(120, 38);
            this.btnXClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXClose.Symbol = "";
            this.btnXClose.SymbolColor = System.Drawing.Color.Red;
            this.btnXClose.TabIndex = 2;
            this.btnXClose.Text = "Close";
            this.btnXClose.Click += new System.EventHandler(this.btnXClose_Click);
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
            this.labelX1.Location = new System.Drawing.Point(164, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(335, 29);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.Aqua;
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Wifi-Hotel Booking Customers";
            // 
            // FrmAllBookedCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 329);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnXClose);
            this.Controls.Add(this.btnXDeleteReservation);
            this.Controls.Add(this.DGVAllbookedCustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAllBookedCustomers";
            this.Text = "All Booking Customers";
            this.Load += new System.EventHandler(this.FrmAllBookedCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllbookedCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVAllbookedCustomers;
        private DevComponents.DotNetBar.ButtonX btnXDeleteReservation;
        private DevComponents.DotNetBar.ButtonX btnXClose;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}