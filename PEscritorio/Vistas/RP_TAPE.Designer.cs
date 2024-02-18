namespace PEscritorio.Vistas
{
    partial class RP_TAPE
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
            this.mATERIALTAPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mATERIALTAPETableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.MATERIALTAPETableAdapter();
            this.DTPFINAL = new System.Windows.Forms.DateTimePicker();
            this.DTPINCIO = new System.Windows.Forms.DateTimePicker();
            this.BTNGENERAR = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALTAPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mATERIALTAPEBindingSource
            // 
            this.mATERIALTAPEBindingSource.DataMember = "MATERIALTAPE";
            this.mATERIALTAPEBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // bDPinturaJuarezDataSet1
            // 
            this.bDPinturaJuarezDataSet1.DataSetName = "BDPinturaJuarezDataSet1";
            this.bDPinturaJuarezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(12, 14);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 20);
            label6.TabIndex = 113;
            label6.Text = "FECHA INICIO";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(540, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(125, 20);
            label5.TabIndex = 111;
            label5.Text = "FECHA FINAL";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "TAPEMASV";
            reportDataSource1.Value = this.mATERIALTAPEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.Vistas.RP_TAPErdlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // mATERIALTAPETableAdapter
            // 
            this.mATERIALTAPETableAdapter.ClearBeforeFill = true;
            // 
            // DTPFINAL
            // 
            this.DTPFINAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPFINAL.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Location = new System.Drawing.Point(486, 37);
            this.DTPFINAL.Name = "DTPFINAL";
            this.DTPFINAL.Size = new System.Drawing.Size(302, 26);
            this.DTPFINAL.TabIndex = 114;
            // 
            // DTPINCIO
            // 
            this.DTPINCIO.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Location = new System.Drawing.Point(12, 37);
            this.DTPINCIO.Name = "DTPINCIO";
            this.DTPINCIO.Size = new System.Drawing.Size(302, 26);
            this.DTPINCIO.TabIndex = 112;
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
            this.BTNGENERAR.Location = new System.Drawing.Point(572, 465);
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Size = new System.Drawing.Size(187, 55);
            this.BTNGENERAR.TabIndex = 115;
            this.BTNGENERAR.Text = "GENERAR";
            this.BTNGENERAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGENERAR.UseVisualStyleBackColor = false;
            this.BTNGENERAR.Click += new System.EventHandler(this.BTNGENERAR_Click);
            // 
            // RP_TAPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.BTNGENERAR);
            this.Controls.Add(this.DTPFINAL);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.DTPINCIO);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RP_TAPE";
            this.Text = "RP_TAPE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RP_TAPE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mATERIALTAPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mATERIALTAPEBindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private BDPinturaJuarezDataSet1TableAdapters.MATERIALTAPETableAdapter mATERIALTAPETableAdapter;
        private System.Windows.Forms.DateTimePicker DTPFINAL;
        private System.Windows.Forms.DateTimePicker DTPINCIO;
        private System.Windows.Forms.Button BTNGENERAR;
    }
}