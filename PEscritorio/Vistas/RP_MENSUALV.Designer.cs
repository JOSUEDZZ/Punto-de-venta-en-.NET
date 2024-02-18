namespace PEscritorio.Vistas
{
    partial class RP_MENSUALV
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
            System.Windows.Forms.Label label1;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.R_VENTAS_DIA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rVENTASDIA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_VENTAS_DIA1TableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_DIA1TableAdapter();
            this.btn = new System.Windows.Forms.Button();
            this.DTPINCIO = new System.Windows.Forms.DateTimePicker();
            this.DTPFINAL = new System.Windows.Forms.DateTimePicker();
            this.R_VENTAS_MESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rVENTASMESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_VENTAS_MESTableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_MESTableAdapter();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_DIA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASDIA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_MESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASMESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // R_VENTAS_DIA1BindingSource
            // 
            this.R_VENTAS_DIA1BindingSource.DataMember = "R_VENTAS_DIA1";
            this.R_VENTAS_DIA1BindingSource.DataSource = this.bDPinturaJuarezDataSet1;
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
            label6.Location = new System.Drawing.Point(26, 8);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(288, 20);
            label6.TabIndex = 111;
            label6.Text = "SELECCIONA LA FECHA INICIAL:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(500, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(275, 20);
            label1.TabIndex = 113;
            label1.Text = "SELECCIONA LA FECHA FINAL:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "VMES";
            reportDataSource1.Value = this.R_VENTAS_MESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.Vistas.RP_MENSUAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(803, 319);
            this.reportViewer1.TabIndex = 0;
            // 
            // rVENTASDIA1BindingSource
            // 
            this.rVENTASDIA1BindingSource.DataMember = "R_VENTAS_DIA1";
            this.rVENTASDIA1BindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // r_VENTAS_DIA1TableAdapter
            // 
            this.r_VENTAS_DIA1TableAdapter.ClearBeforeFill = true;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(148)))));
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Image = global::PEscritorio.Properties.Resources.icons8_imprimir_50;
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.Location = new System.Drawing.Point(588, 388);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(187, 55);
            this.btn.TabIndex = 112;
            this.btn.Text = "GENERAR";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // DTPINCIO
            // 
            this.DTPINCIO.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Location = new System.Drawing.Point(30, 31);
            this.DTPINCIO.Name = "DTPINCIO";
            this.DTPINCIO.Size = new System.Drawing.Size(302, 26);
            this.DTPINCIO.TabIndex = 110;
            // 
            // DTPFINAL
            // 
            this.DTPFINAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPFINAL.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Location = new System.Drawing.Point(480, 31);
            this.DTPFINAL.Name = "DTPFINAL";
            this.DTPFINAL.Size = new System.Drawing.Size(308, 26);
            this.DTPFINAL.TabIndex = 115;
            // 
            // R_VENTAS_MESBindingSource
            // 
            this.R_VENTAS_MESBindingSource.DataMember = "R_VENTAS_MES";
            this.R_VENTAS_MESBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // rVENTASMESBindingSource
            // 
            this.rVENTASMESBindingSource.DataMember = "R_VENTAS_MES";
            this.rVENTASMESBindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // r_VENTAS_MESTableAdapter
            // 
            this.r_VENTAS_MESTableAdapter.ClearBeforeFill = true;
            // 
            // RP_MENSUALV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTPFINAL);
            this.Controls.Add(label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(label6);
            this.Controls.Add(this.DTPINCIO);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RP_MENSUALV";
            this.Text = "RP_MENSUALV";
            this.Load += new System.EventHandler(this.RP_MENSUALV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_DIA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASDIA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_MESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASMESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rVENTASDIA1BindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_DIA1TableAdapter r_VENTAS_DIA1TableAdapter;
        private System.Windows.Forms.BindingSource R_VENTAS_DIA1BindingSource;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DateTimePicker DTPINCIO;
        private System.Windows.Forms.DateTimePicker DTPFINAL;
        private System.Windows.Forms.BindingSource R_VENTAS_MESBindingSource;
        private System.Windows.Forms.BindingSource rVENTASMESBindingSource;
        private BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_MESTableAdapter r_VENTAS_MESTableAdapter;
    }
}