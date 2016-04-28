namespace GUI2
{
    partial class FrmCheckOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.superTabControlCheckOut = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.DGVXCheckOut = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.lblItemCheckOutID = new DevComponents.DotNetBar.LabelItem();
            this.btnXCheckOut = new DevComponents.DotNetBar.ButtonX();
            this.btnXClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlCheckOut)).BeginInit();
            this.superTabControlCheckOut.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVXCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControlCheckOut
            // 
            this.superTabControlCheckOut.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControlCheckOut.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControlCheckOut.ControlBox.MenuBox.Name = "";
            this.superTabControlCheckOut.ControlBox.Name = "";
            this.superTabControlCheckOut.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControlCheckOut.ControlBox.MenuBox,
            this.superTabControlCheckOut.ControlBox.CloseBox});
            this.superTabControlCheckOut.Controls.Add(this.superTabControlPanel1);
            this.superTabControlCheckOut.Location = new System.Drawing.Point(37, 71);
            this.superTabControlCheckOut.Name = "superTabControlCheckOut";
            this.superTabControlCheckOut.ReorderTabsEnabled = true;
            this.superTabControlCheckOut.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControlCheckOut.SelectedTabIndex = 0;
            this.superTabControlCheckOut.Size = new System.Drawing.Size(656, 201);
            this.superTabControlCheckOut.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControlCheckOut.TabIndex = 0;
            this.superTabControlCheckOut.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.MultiLineFit;
            this.superTabControlCheckOut.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.lblItemCheckOutID});
            this.superTabControlCheckOut.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007;
            this.superTabControlCheckOut.Text = "Check Out Customers";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.DGVXCheckOut);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 34);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(656, 167);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // DGVXCheckOut
            // 
            this.DGVXCheckOut.BackgroundColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVXCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVXCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVXCheckOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVXCheckOut.EnableHeadersVisualStyles = false;
            this.DGVXCheckOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DGVXCheckOut.Location = new System.Drawing.Point(6, -2);
            this.DGVXCheckOut.Name = "DGVXCheckOut";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVXCheckOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVXCheckOut.Size = new System.Drawing.Size(647, 167);
            this.DGVXCheckOut.TabIndex = 0;
            this.DGVXCheckOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVXCheckOut_CellClick);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Image = global::GUI2.Resource1.checked_out;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItem1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabItem1.Text = "Check out customers";
            // 
            // lblItemCheckOutID
            // 
            this.lblItemCheckOutID.Name = "lblItemCheckOutID";
            this.lblItemCheckOutID.Symbol = "";
            this.lblItemCheckOutID.SymbolColor = System.Drawing.Color.Red;
            // 
            // btnXCheckOut
            // 
            this.btnXCheckOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCheckOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCheckOut.Location = new System.Drawing.Point(166, 322);
            this.btnXCheckOut.Name = "btnXCheckOut";
            this.btnXCheckOut.Size = new System.Drawing.Size(125, 38);
            this.btnXCheckOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXCheckOut.Symbol = "";
            this.btnXCheckOut.SymbolColor = System.Drawing.Color.Red;
            this.btnXCheckOut.TabIndex = 1;
            this.btnXCheckOut.Text = "Check-Out";
            this.btnXCheckOut.Click += new System.EventHandler(this.btnXCheckOut_Click);
            // 
            // btnXClose
            // 
            this.btnXClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXClose.Location = new System.Drawing.Point(343, 322);
            this.btnXClose.Name = "btnXClose";
            this.btnXClose.Size = new System.Drawing.Size(120, 38);
            this.btnXClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnXClose.Symbol = "";
            this.btnXClose.SymbolColor = System.Drawing.Color.Red;
            this.btnXClose.TabIndex = 2;
            this.btnXClose.Text = "&Close";
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
            this.labelX1.Location = new System.Drawing.Point(217, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(269, 29);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.Aqua;
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Wifi-Hotel Check-Out";
            // 
            // FrmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(722, 395);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnXClose);
            this.Controls.Add(this.btnXCheckOut);
            this.Controls.Add(this.superTabControlCheckOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCheckOut";
            this.ShowIcon = false;
            this.Text = "Check out customers";
            this.Load += new System.EventHandler(this.FrmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControlCheckOut)).EndInit();
            this.superTabControlCheckOut.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVXCheckOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControlCheckOut;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGVXCheckOut;
        private DevComponents.DotNetBar.LabelItem lblItemCheckOutID;
        private DevComponents.DotNetBar.ButtonX btnXCheckOut;
        private DevComponents.DotNetBar.ButtonX btnXClose;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}