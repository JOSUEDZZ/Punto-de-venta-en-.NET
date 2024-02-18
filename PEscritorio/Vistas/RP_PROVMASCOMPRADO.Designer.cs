namespace PEscritorio.Vistas
{
    partial class RP_PROVMASCOMPRADO
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DTPFINAL = new System.Windows.Forms.DateTimePicker();
            this.DTPINCIO = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.pROVEDORMASCOMPRADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEDORMASCOMPRADOTableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.PROVEDORMASCOMPRADOTableAdapter();
            this.BTNGENERAR = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORMASCOMPRADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPFINAL
            // 
            this.DTPFINAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPFINAL.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Location = new System.Drawing.Point(486, 31);
            this.DTPFINAL.Name = "DTPFINAL";
            this.DTPFINAL.Size = new System.Drawing.Size(302, 26);
            this.DTPFINAL.TabIndex = 122;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(12, 8);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 20);
            label6.TabIndex = 121;
            label6.Text = "FECHA INICIO";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(540, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(125, 20);
            label5.TabIndex = 119;
            label5.Text = "FECHA FINAL";
            // 
            // DTPINCIO
            // 
            this.DTPINCIO.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Location = new System.Drawing.Point(12, 31);
            this.DTPINCIO.Name = "DTPINCIO";
            this.DTPINCIO.Size = new System.Drawing.Size(302, 26);
            this.DTPINCIO.TabIndex = 120;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "PROVMASCOMPRA";
            reportDataSource1.Value = this.pROVEDORMASCOMPRADOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.Vistas.PR_PROVMASCOMPRA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(802, 313);
            this.reportViewer1.TabIndex = 123;
            // 
            // bDPinturaJuarezDataSet1
            // 
            this.bDPinturaJuarezDataSet1.DataSetName = "BDPinturaJuarezDataSet1";
            this.bDPinturaJuarezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVEDORMASCOMPRADOBindingSource
            // 
            this.pROVEDORMASCOMPRADOBindingSource.DataMember = "PROVEDORMASCOMPRADO";
            this.pROVEDORMASCOMPRADOBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // pROVEDORMASCOMPRADOTableAdapter
            // 
            this.pROVEDORMASCOMPRADOTableAdapter.ClearBeforeFill = true;
            // 
            // BTNGENERAR
            // 
            this.BTNGENERAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNGENERAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(148)))));
            this.BTNGENERAR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNGENERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGENERAR.ForeColor = System.Drawing.Color.White;
            this.BTNGENERAR.Image = global::PEscritorio.Properties.Resources.icons8_imprimir_50;
            this.BTNGENERAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGENERAR.Location = new System.Drawing.Point(590, 383);
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Size = new System.Drawing.Size(187, 55);
            this.BTNGENERAR.TabIndex = 124;
            this.BTNGENERAR.Text = "GENERAR";
            this.BTNGENERAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGENERAR.UseVisualStyleBackColor = false;
            this.BTNGENERAR.Click += new System.EventHandler(this.BTNGENERAR_Click);
            // 
            // RP_PROVMASCOMPRADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNGENERAR);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.DTPFINAL);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.DTPINCIO);
            this.Name = "RP_PROVMASCOMPRADO";
            this.Text = "RP_PROVMASCOMPRADO";
            this.Load += new System.EventHandler(this.RP_PROVMASCOMPRADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEDORMASCOMPRADOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPFINAL;
        private System.Windows.Forms.DateTimePicker DTPINCIO;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pROVEDORMASCOMPRADOBindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private BDPinturaJuarezDataSet1TableAdapters.PROVEDORMASCOMPRADOTableAdapter pROVEDORMASCOMPRADOTableAdapter;
        private System.Windows.Forms.Button BTNGENERAR;
    }
}