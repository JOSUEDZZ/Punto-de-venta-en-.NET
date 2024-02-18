namespace PEscritorio
{
    partial class COTIZACION
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
            this.bDPinturaJuarezDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CREARCOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet3 = new PEscritorio.BDPinturaJuarezDataSet3();
            this.bDPinturaJuarezDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREARCOTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cREARCOTTableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.CREARCOTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREARCOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREARCOTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDPinturaJuarezDataSet1BindingSource
            // 
            this.bDPinturaJuarezDataSet1BindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            this.bDPinturaJuarezDataSet1BindingSource.Position = 0;
            // 
            // bDPinturaJuarezDataSet1
            // 
            this.bDPinturaJuarezDataSet1.DataSetName = "BDPinturaJuarezDataSet1";
            this.bDPinturaJuarezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "COTIZACION";
            reportDataSource1.Value = this.cREARCOTBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.COTIZACION.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CREARCOTBindingSource
            // 
            this.CREARCOTBindingSource.DataMember = "CREARCOT";
            this.CREARCOTBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // bDPinturaJuarezDataSet3
            // 
            this.bDPinturaJuarezDataSet3.DataSetName = "BDPinturaJuarezDataSet3";
            this.bDPinturaJuarezDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDPinturaJuarezDataSet3BindingSource
            // 
            this.bDPinturaJuarezDataSet3BindingSource.DataSource = this.bDPinturaJuarezDataSet3;
            this.bDPinturaJuarezDataSet3BindingSource.Position = 0;
            // 
            // cREARCOTBindingSource1
            // 
            this.cREARCOTBindingSource1.DataMember = "CREARCOT";
            this.cREARCOTBindingSource1.DataSource = this.bDPinturaJuarezDataSet1BindingSource;
            // 
            // cREARCOTTableAdapter
            // 
            this.cREARCOTTableAdapter.ClearBeforeFill = true;
            // 
            // COTIZACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "COTIZACION";
            this.Text = "COTIZACION";
            this.Load += new System.EventHandler(this.COTIZACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREARCOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREARCOTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDPinturaJuarezDataSet1BindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private System.Windows.Forms.BindingSource CREARCOTBindingSource;
        private System.Windows.Forms.BindingSource bDPinturaJuarezDataSet3BindingSource;
        private BDPinturaJuarezDataSet3 bDPinturaJuarezDataSet3;
        private System.Windows.Forms.BindingSource cREARCOTBindingSource1;
        private BDPinturaJuarezDataSet1TableAdapters.CREARCOTTableAdapter cREARCOTTableAdapter;
    }
}