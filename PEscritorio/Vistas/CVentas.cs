using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class CVentas : Form
    {

        CN_Ventas objVentas = new CN_Ventas();
        private void btnVentas_Click(object sender, EventArgs e)
        {

        }
        public void Desaparecer()
        {
           
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Factura PantallaFactura = new Factura();
            this.Close();
            PantallaFactura.ShowDialog();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            Desaparecer();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void CVentas_Load(object sender, EventArgs e)
        {
            MostrarVentas();
        }
        private void MostrarVentas()
        {
            dgvVentas.DataSource = objVentas.MostrarVentas();
        }

        public CVentas()
        {
            InitializeComponent();
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvVentas.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    string noventa = row.Cells["NOVENTA"].Value.ToString().ToLower();
                    string fecha = row.Cells["FECHA"].Value.ToString().ToLower();
                    string total = row.Cells["TOTAL"].Value.ToString().ToLower();
                    string fkurfc = row.Cells["USUARIO"].Value.ToString().ToLower();
                    string fkclirfc = row.Cells["CLIENTE"].Value.ToString().ToLower();



                    if (noventa.Contains(searchText) || fecha.Contains(searchText) || total.Contains(searchText) || fkurfc.Contains(searchText) || fkclirfc.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }
    }
}
