using CapaDatos;
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
    public partial class CCompras : Form
    {
        byte ce = 0, re = 0, ipm = 0;
        CD_Compras objCompras = new CD_Compras();
        public CCompras()
        {
            InitializeComponent();
           
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            
        }
        public void Desaparecer()
        {
           
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            
        }
        private void MostrarCompras()
        {
            dgvCompras.DataSource = objCompras.Mostrar();
        }


        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Factura PantallaFactura = new Factura();
            this.Close();
            PantallaFactura.ShowDialog();
        }

        private void BtnRProvee_Click_1(object sender, EventArgs e)
        {
            RProveedor PantallaRProveerdor = new RProveedor();
            this.Close();
            PantallaRProveerdor.ShowDialog();
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            CProveedores PantallaCProveedores = new CProveedores();
            this.Close();
            PantallaCProveedores.ShowDialog();
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            CClientes PantallaCClie = new CClientes();
            this.Close();
            PantallaCClie.ShowDialog();
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            this.Close();
            PantallasCCompra.ShowDialog();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CCorte PantallaCCorte = new CCorte();
            this.Close();
            PantallaCCorte.ShowDialog();
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            CUsuarios PantallaCUsuari = new CUsuarios();
            this.Close();
            PantallaCUsuari.ShowDialog();
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            RMateriales RMateria = new RMateriales();
            this.Close();
            RMateria.ShowDialog();
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            RUsuario PantallaRUsuario = new RUsuario();
            this.Close();
            PantallaRUsuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBalance PantallaCBalance = new CBalance();
            this.Close();
            PantallaCBalance.ShowDialog();
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
            RPintura PantallaRPintura = new RPintura();
            this.Close();
            PantallaRPintura.ShowDialog();
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
            RClientes PantallaRClie = new RClientes();
            this.Close();
            PantallaRClie.ShowDialog();
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            CPintura CPintura = new CPintura();
            this.Close();
            CPintura.ShowDialog();
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
            CMateriales CMateriales = new CMateriales();
            this.Close();
            CMateriales.ShowDialog();
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            CVentas CVentas = new CVentas();
            this.Close();
            CVentas.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ReprtesVentas PantallaReprtesVentas = new ReprtesVentas();
            this.Close();
            PantallaReprtesVentas.ShowDialog();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CCompras_Load(object sender, EventArgs e)
        {
            MostrarCompras();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCompras.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    string fac = row.Cells["CFACTURA"].Value.ToString().ToLower();
                    string fecha = row.Cells["FECHA"].Value.ToString().ToLower();
                    string total = row.Cells["TOTAL"].Value.ToString().ToLower();
                    string pro = row.Cells["FKPRORFC"].Value.ToString().ToLower();
                    string urfc = row.Cells["FKURFC"].Value.ToString().ToLower();

                    if (fac.Contains(searchText) || fecha.Contains(searchText) || total.Contains(searchText) || pro.Contains(searchText) || urfc.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
