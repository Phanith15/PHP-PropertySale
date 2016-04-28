namespace GUI2
{
    partial class FrmSetUp
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
            this.DGVRoomSetUp = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXSetPrice = new DevComponents.DotNetBar.ButtonX();
            this.txtXRoomPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRoomSetUp)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVRoomSetUp
            // 
            this.DGVRoomSetUp.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRoomSetUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRoomSetUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRoomSetUp.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRoomSetUp.EnableHeadersVisualStyles = false;
            this.DGVRoomSetUp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DGVRoomSetUp.Location = new System.Drawing.Point(29, 34);
            this.DGVRoomSetUp.Name = "DGVRoomSetUp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRoomSetUp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRoomSetUp.Size = new System.Drawing.Size(369, 458);
            this.DGVRoomSetUp.TabIndex = 0;
            this.DGVRoomSetUp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRoomSetUp_CellClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(41, 160);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(162, 42);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Room\'s Price / night ";
            // 
            // btnXSetPrice
            // 
            this.btnXSetPrice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXSetPrice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXSetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXSetPrice.Location = new System.Drawing.Point(57, 261);
            this.btnXSetPrice.Name = "btnXSetPrice";
            this.btnXSetPrice.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnXSetPrice.Size = new System.Drawing.Size(124, 35);
            this.btnXSetPrice.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnXSetPrice.Symbol = "";
            this.btnXSetPrice.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXSetPrice.TabIndex = 3;
            this.btnXSetPrice.Text = "Set New Price";
            this.btnXSetPrice.TextColor = System.Drawing.Color.Black;
            this.btnXSetPrice.Click += new System.EventHandler(this.btnXSetPrice_Click);
            // 
            // txtXRoomPrice
            // 
            // 
            // 
            // 
            this.txtXRoomPrice.Border.Class = "TextBoxBorder";
            this.txtXRoomPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtXRoomPrice.ButtonCustom.Tooltip = "";
            this.txtXRoomPrice.ButtonCustom2.Tooltip = "";
            this.txtXRoomPrice.Location = new System.Drawing.Point(57, 214);
            this.txtXRoomPrice.Name = "txtXRoomPrice";
            this.txtXRoomPrice.PreventEnterBeep = true;
            this.txtXRoomPrice.Size = new System.Drawing.Size(124, 20);
            this.txtXRoomPrice.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(17, 103);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(210, 38);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Setting Room Price";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnXSetPrice);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.txtXRoomPrice);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(418, 34);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(237, 458);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            this.panelEx1.Text = "panelEx1";
            // 
            // FrmSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 538);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.DGVRoomSetUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSetUp";
            this.ShowIcon = false;
            this.Text = "Setting Rooms";
            this.Load += new System.EventHandler(this.FrmSetUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRoomSetUp)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVRoomSetUp;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnXSetPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtXRoomPrice;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}