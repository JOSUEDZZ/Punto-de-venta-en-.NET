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
    public partial class CCorte : Form
    {
        CN_Corte objCorte = new CN_Corte();
        public CCorte()
        {
            InitializeComponent();
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
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

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Desaparecer()
        {
            
        }

        private void CCorte_Load(object sender, EventArgs e)
        {
            MostrarCortes();
        }
        private void MostrarCortes()
        {
            dgvCorte.DataSource = objCorte.MostrarCorte();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCorte.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvCorte.Rows)
                {
                    string noventa = row.Cells["NOCORTE"].Value.ToString().ToLower();
                    string fecha = row.Cells["FECHA"].Value.ToString().ToLower();
                    string total = row.Cells["TOTAL"].Value.ToString().ToLower();
                    string tocaja = row.Cells["TOTALCAJA"].Value.ToString().ToLower();
                    string fondo = row.Cells["FONDOINICIAL"].Value.ToString().ToLower();
                    string urfc = row.Cells["NOMBRE"].Value.ToString().ToLower();




                    if (noventa.Contains(searchText) || fecha.Contains(searchText) || total.Contains(searchText) || tocaja.Contains(searchText) || fondo.Contains(searchText) || urfc.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvCorte.Rows)
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
