namespace GUI2
{
    partial class FrmReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.myDataSet1 = new GUI2.myDataSet1();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomersTableAdapter = new GUI2.myDataSet1TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustomersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 423);
            this.reportViewer1.TabIndex = 0;
            // 
            // myDataSet1
            // 
            this.myDataSet1.DataSetName = "myDataSet1";
            this.myDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.myDataSet1;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private myDataSet1 myDataSet1;
        private myDataSet1TableAdapters.CustomersTableAdapter CustomersTableAdapter;
    }
}