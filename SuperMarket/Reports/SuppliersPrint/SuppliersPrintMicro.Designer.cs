namespace SuperMarket.Reports.SuppliersPrint
{
    partial class SuppliersPrintMicro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersPrintMicro));
            this.PrintSingleSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuperMarket_DBDataSet = new SuperMarket.Reports.SuppliersPrint.SuperMarket_DBDataSet();
            this.PrintALLSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrintSingleSuppliersTableAdapter = new SuperMarket.Reports.SuppliersPrint.SuperMarket_DBDataSetTableAdapters.PrintSingleSuppliersTableAdapter();
            this.PrintALLSuppliersTableAdapter = new SuperMarket.Reports.SuppliersPrint.SuperMarket_DBDataSetTableAdapters.PrintALLSuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PrintSingleSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMarket_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintALLSuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintSingleSuppliersBindingSource
            // 
            this.PrintSingleSuppliersBindingSource.DataMember = "PrintSingleSuppliers";
            this.PrintSingleSuppliersBindingSource.DataSource = this.SuperMarket_DBDataSet;
            // 
            // SuperMarket_DBDataSet
            // 
            this.SuperMarket_DBDataSet.DataSetName = "SuperMarket_DBDataSet";
            this.SuperMarket_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrintALLSuppliersBindingSource
            // 
            this.PrintALLSuppliersBindingSource.DataMember = "PrintALLSuppliers";
            this.PrintALLSuppliersBindingSource.DataSource = this.SuperMarket_DBDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrintSingleSuppliersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.SuppliersPrint.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(385, 284);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PrintALLSuppliersBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SuperMarket.Reports.SuppliersPrint.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(385, 284);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // PrintSingleSuppliersTableAdapter
            // 
            this.PrintSingleSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // PrintALLSuppliersTableAdapter
            // 
            this.PrintALLSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // SuppliersPrintMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 284);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuppliersPrintMicro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الموردين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuppliersPrintMicro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintSingleSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMarket_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintALLSuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource PrintSingleSuppliersBindingSource;
        public SuperMarket_DBDataSet SuperMarket_DBDataSet;
        public SuperMarket_DBDataSetTableAdapters.PrintSingleSuppliersTableAdapter PrintSingleSuppliersTableAdapter;
        public System.Windows.Forms.BindingSource PrintALLSuppliersBindingSource;
        public SuperMarket_DBDataSetTableAdapters.PrintALLSuppliersTableAdapter PrintALLSuppliersTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}