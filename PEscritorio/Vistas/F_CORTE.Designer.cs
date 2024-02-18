namespace PEscritorio.Vistas
{
    partial class F_CORTE
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
            this.mostCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.mostrarCorteNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostCuentasTableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.MostCuentasTableAdapter();
            this.mostrarCorteNOTableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.MostrarCorteNOTableAdapter();
            this.CREARCOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarCorteNOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREARCOTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mostCuentasBindingSource
            // 
            this.mostCuentasBindingSource.DataMember = "MostCuentas";
            this.mostCuentasBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // bDPinturaJuarezDataSet1
            // 
            this.bDPinturaJuarezDataSet1.DataSetName = "BDPinturaJuarezDataSet1";
            this.bDPinturaJuarezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarCorteNOBindingSource
            // 
            this.mostrarCorteNOBindingSource.DataMember = "MostrarCorteNO";
            this.mostrarCorteNOBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CORTE";
            reportDataSource1.Value = this.mostCuentasBindingSource;
            reportDataSource2.Name = "DetalleCorte";
            reportDataSource2.Value = this.mostrarCorteNOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.Vistas.CORTE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // mostCuentasTableAdapter
            // 
            this.mostCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarCorteNOTableAdapter
            // 
            this.mostrarCorteNOTableAdapter.ClearBeforeFill = true;
            // 
            // CREARCOTBindingSource
            // 
            this.CREARCOTBindingSource.DataMember = "CREARCOT";
            this.CREARCOTBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // F_CORTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "F_CORTE";
            this.Text = "F_CORTE";
            this.Load += new System.EventHandler(this.F_CORTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarCorteNOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREARCOTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostCuentasBindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private System.Windows.Forms.BindingSource mostrarCorteNOBindingSource;
        private BDPinturaJuarezDataSet1TableAdapters.MostCuentasTableAdapter mostCuentasTableAdapter;
        private BDPinturaJuarezDataSet1TableAdapters.MostrarCorteNOTableAdapter mostrarCorteNOTableAdapter;
        private System.Windows.Forms.BindingSource CREARCOTBindingSource;
    }
}