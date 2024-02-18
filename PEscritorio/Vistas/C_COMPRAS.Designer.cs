namespace PEscritorio.Vistas
{
    partial class C_COMPRAS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.cOMCOMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMCOMPRATableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.COMCOMPRATableAdapter();
            this.dATOSPROVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATOSPROVTableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.DATOSPROVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMCOMPRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSPROVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "compradoc";
            reportDataSource5.Value = this.cOMCOMPRABindingSource;
            reportDataSource6.Name = "DETPROV";
            reportDataSource6.Value = this.dATOSPROVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.Vistas.COMPRA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPinturaJuarezDataSet1
            // 
            this.bDPinturaJuarezDataSet1.DataSetName = "BDPinturaJuarezDataSet1";
            this.bDPinturaJuarezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMCOMPRABindingSource
            // 
            this.cOMCOMPRABindingSource.DataMember = "COMCOMPRA";
            this.cOMCOMPRABindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // cOMCOMPRATableAdapter
            // 
            this.cOMCOMPRATableAdapter.ClearBeforeFill = true;
            // 
            // dATOSPROVBindingSource
            // 
            this.dATOSPROVBindingSource.DataMember = "DATOSPROV";
            this.dATOSPROVBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // dATOSPROVTableAdapter
            // 
            this.dATOSPROVTableAdapter.ClearBeforeFill = true;
            // 
            // C_COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "C_COMPRAS";
            this.Text = "C_COMPRAS";
            this.Load += new System.EventHandler(this.C_COMPRAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMCOMPRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATOSPROVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cOMCOMPRABindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private System.Windows.Forms.BindingSource dATOSPROVBindingSource;
        private BDPinturaJuarezDataSet1TableAdapters.COMCOMPRATableAdapter cOMCOMPRATableAdapter;
        private BDPinturaJuarezDataSet1TableAdapters.DATOSPROVTableAdapter dATOSPROVTableAdapter;
    }
}