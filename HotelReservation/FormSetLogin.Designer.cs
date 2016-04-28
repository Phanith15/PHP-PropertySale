namespace GUI2
{
    partial class FormSetLogin
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
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUsername.Location = new System.Drawing.Point(251, 64);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(170, 22);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewUsername_KeyDown);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Image = global::GUI2.Resource1.LoginImage;
            this.labelX1.Location = new System.Drawing.Point(51, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 33);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Name : ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Image = global::GUI2.Resource1.LoginKey;
            this.labelX2.Location = new System.Drawing.Point(51, 90);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(134, 33);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Password : ";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Image = global::GUI2.Resource1.LoginKey;
            this.labelX3.Location = new System.Drawing.Point(51, 122);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(186, 33);
            this.labelX3.Symbol = "";
            this.labelX3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Confirm password : ";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(251, 95);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(170, 22);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPass.Location = new System.Drawing.Point(251, 125);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '*';
            this.txtConfirmNewPass.Size = new System.Drawing.Size(170, 22);
            this.txtConfirmNewPass.TabIndex = 5;
            this.txtConfirmNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmNewPass_KeyDown);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(307, 168);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 5);
            this.panel1.TabIndex = 7;
            // 
            // FormSetLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI2.Resource1.loginbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 209);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtConfirmNewPass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtNewUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetLogin";
            this.ShowIcon = false;
            this.Text = "New Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewUsername;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
    }
}