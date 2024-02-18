namespace PEscritorio
{
    partial class CambiarContra
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmarCoontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(148)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.Location = new System.Drawing.Point(78, 218);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(155, 56);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Aceptar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nueva contraseña";
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContra.Location = new System.Drawing.Point(37, 83);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(222, 29);
            this.txtNuevaContra.TabIndex = 18;
            this.txtNuevaContra.TextChanged += new System.EventHandler(this.txtNuevaContra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirmar contraseña";
            // 
            // txtConfirmarCoontra
            // 
            this.txtConfirmarCoontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarCoontra.Location = new System.Drawing.Point(37, 164);
            this.txtConfirmarCoontra.Name = "txtConfirmarCoontra";
            this.txtConfirmarCoontra.Size = new System.Drawing.Size(222, 29);
            this.txtConfirmarCoontra.TabIndex = 20;
            this.txtConfirmarCoontra.TextChanged += new System.EventHandler(this.txtConfirmarCoontra_TextChanged);
            // 
            // CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmarCoontra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevaContra);
            this.Controls.Add(this.btnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarContra";
            this.Text = "CambiarContra";
            this.Load += new System.EventHandler(this.CambiarContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmarCoontra;
    }
}