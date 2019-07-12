namespace SuperMarket.Reports.cust
{
    partial class FrmCustPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PrintSingleCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuperMarket_DBDataSetCust = new SuperMarket.Reports.cust.SuperMarket_DBDataSetCust();
            this.PrintALLCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintSingleCustomerTableAdapter = new SuperMarket.Reports.cust.SuperMarket_DBDataSetCustTableAdapters.PrintSingleCustomerTableAdapter();
            this.PrintALLCustomerTableAdapter = new SuperMarket.Reports.cust.SuperMarket_DBDataSetCustTableAdapters.PrintALLCustomerTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PrintSingleCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMarket_DBDataSetCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintALLCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintSingleCustomerBindingSource
            // 
            this.PrintSingleCustomerBindingSource.DataMember = "PrintSingleCustomer";
            this.PrintSingleCustomerBindingSource.DataSource = this.SuperMarket_DBDataSetCust;
            // 
            // SuperMarket_DBDataSetCust
            // 
            this.SuperMarket_DBDataSetCust.DataSetName = "SuperMarket_DBDataSetCust";
            this.SuperMarket_DBDataSetCust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrintALLCustomerBindingSource
            // 
            this.PrintALLCustomerBindingSource.DataMember = "PrintALLCustomer";
            this.PrintALLCustomerBindingSource.DataSource = this.SuperMarket_DBDataSetCust;
            // 
            // PrintSingleCustomerTableAdapter
            // 
            this.PrintSingleCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // PrintALLCustomerTableAdapter
            // 
            this.PrintALLCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrintSingleCustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.cust.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(461, 218);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PrintALLCustomerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.cust.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(461, 218);
            this.reportViewer2.TabIndex = 1;
            // 
            // FrmCustPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 218);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة تقارير العملاء";
            this.Load += new System.EventHandler(this.FrmCustPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintSingleCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMarket_DBDataSetCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintALLCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource PrintSingleCustomerBindingSource;
        public SuperMarket_DBDataSetCust SuperMarket_DBDataSetCust;
        public SuperMarket_DBDataSetCustTableAdapters.PrintSingleCustomerTableAdapter PrintSingleCustomerTableAdapter;
        public System.Windows.Forms.BindingSource PrintALLCustomerBindingSource;
        public SuperMarket_DBDataSetCustTableAdapters.PrintALLCustomerTableAdapter PrintALLCustomerTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}