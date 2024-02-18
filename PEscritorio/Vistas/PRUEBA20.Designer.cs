namespace PEscritorio.Vistas
{
    partial class PRUEBA20
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
            this.R_VENTAS_DIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet1 = new PEscritorio.BDPinturaJuarezDataSet1();
            this.rVENTASDIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_VENTAS_DIATableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_DIATableAdapter();
            this.DTPINCIO = new System.Windows.Forms.DateTimePicker();
            this.DTPFINAL = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.R_VENTAS_DIA2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rVENTASDIA2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_VENTAS_DIA2TableAdapter = new PEscritorio.BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_DIA2TableAdapter();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_DIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASDIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_DIA2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASDIA2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // R_VENTAS_DIABindingSource
            // 
            this.R_VENTAS_DIABindingSource.DataMember = "R_VENTAS_DIA";
            this.R_VENTAS_DIABindingSource.DataSource = this.bDPinturaJuarezDataSet1;
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
            label6.Location = new System.Drawing.Point(21, 14);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 20);
            label6.TabIndex = 106;
            label6.Text = "FECHA INICIO";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(549, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(125, 20);
            label5.TabIndex = 102;
            label5.Text = "FECHA FINAL";
            // 
            // rVENTASDIABindingSource
            // 
            this.rVENTASDIABindingSource.DataMember = "R_VENTAS_DIA";
            this.rVENTASDIABindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // r_VENTAS_DIATableAdapter
            // 
            this.r_VENTAS_DIATableAdapter.ClearBeforeFill = true;
            // 
            // DTPINCIO
            // 
            this.DTPINCIO.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPINCIO.Location = new System.Drawing.Point(21, 37);
            this.DTPINCIO.Name = "DTPINCIO";
            this.DTPINCIO.Size = new System.Drawing.Size(302, 26);
            this.DTPINCIO.TabIndex = 105;
            // 
            // DTPFINAL
            // 
            this.DTPFINAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPFINAL.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFINAL.Location = new System.Drawing.Point(553, 37);
            this.DTPFINAL.Name = "DTPFINAL";
            this.DTPFINAL.Size = new System.Drawing.Size(302, 26);
            this.DTPFINAL.TabIndex = 104;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(148)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::PEscritorio.Properties.Resources.icons8_imprimir_50;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(682, 694);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 55);
            this.button8.TabIndex = 103;
            this.button8.Text = "GENERAR";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "VSEMANAL";
            reportDataSource1.Value = this.R_VENTAS_DIA2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.Vistas.RP_SEMANAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(880, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // R_VENTAS_DIA2BindingSource
            // 
            this.R_VENTAS_DIA2BindingSource.DataMember = "R_VENTAS_DIA2";
            this.R_VENTAS_DIA2BindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // rVENTASDIA2BindingSource
            // 
            this.rVENTASDIA2BindingSource.DataMember = "R_VENTAS_DIA2";
            this.rVENTASDIA2BindingSource.DataSource = this.bDPinturaJuarezDataSet1;
            // 
            // r_VENTAS_DIA2TableAdapter
            // 
            this.r_VENTAS_DIA2TableAdapter.ClearBeforeFill = true;
            // 
            // PRUEBA20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(881, 761);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.DTPINCIO);
            this.Controls.Add(this.DTPFINAL);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PRUEBA20";
            this.Text = "PRUEBA20";
            this.Load += new System.EventHandler(this.PRUEBA20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_DIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASDIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_VENTAS_DIA2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rVENTASDIA2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource R_VENTAS_DIABindingSource;
        private BDPinturaJuarezDataSet1 bDPinturaJuarezDataSet1;
        private System.Windows.Forms.BindingSource rVENTASDIABindingSource;
        private BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_DIATableAdapter r_VENTAS_DIATableAdapter;
        private System.Windows.Forms.DateTimePicker DTPINCIO;
        private System.Windows.Forms.DateTimePicker DTPFINAL;
        private System.Windows.Forms.Button button8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource R_VENTAS_DIA2BindingSource;
        private System.Windows.Forms.BindingSource rVENTASDIA2BindingSource;
        private BDPinturaJuarezDataSet1TableAdapters.R_VENTAS_DIA2TableAdapter r_VENTAS_DIA2TableAdapter;
    }
}