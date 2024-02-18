using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace PEscritorio
{
    public partial class CUsuarios : Form
    {
        byte ce = 0, re = 0, ipm = 0;

        CN_Usuario objetoCNUser = new CN_Usuario();
        


        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
           
        }
        public void Desaparecer()
        {
           
        }

        //METODO PARA MOSTRAR LA BASE DE DATOS EN EL DATA
        private void MostrarUsuarios()
        {
            dgvUsuario.DataSource = objetoCNUser.MostrarUsuario();
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Factura PantallaFactura = new Factura();
            this.Close();
            PantallaFactura.ShowDialog();
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
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

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            CCorte PantallaCCorte = new CCorte();
            this.Close();
            PantallaCCorte.ShowDialog();
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            Desaparecer();
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

        private void BtnCBalance_Click(object sender, EventArgs e)
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

        private void CUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvUsuario.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvUsuario.Rows)
                {
                    string rfc = row.Cells["URFC"].Value.ToString().ToLower();
                    string nombre = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string direccion = row.Cells["DIRECCION"].Value.ToString().ToLower();
                    string curp = row.Cells["CURP"].Value.ToString().ToLower();
                    string postal = row.Cells["CODIGOPOSTAL"].Value.ToString().ToLower();
                    string fecha = row.Cells["FECHANACI"].Value.ToString().ToLower();
                    string telefono = row.Cells["TELEFONO"].Value.ToString().ToLower();
                    string tipo = row.Cells["TIPO"].Value.ToString().ToLower();
                    string contraseña = row.Cells["PASWORD"].Value.ToString().ToLower();
                    string pregunta = row.Cells["PREGUNTA"].Value.ToString().ToLower();
                    string respuesta = row.Cells["RESPUESTA"].Value.ToString().ToLower();








                    if (rfc.Contains(searchText) || nombre.Contains(searchText) || direccion.Contains(searchText) || curp.Contains(searchText) || postal.Contains(searchText) || fecha.Contains(searchText) || telefono.Contains(searchText) || tipo.Contains(searchText) || contraseña.Contains(searchText) || pregunta.Contains(searchText) || respuesta.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvUsuario.Rows)
                {
                    row.Visible = true;
                }
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }

        public CUsuarios()
        {
            InitializeComponent();
           
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
           
        }
    }
}
