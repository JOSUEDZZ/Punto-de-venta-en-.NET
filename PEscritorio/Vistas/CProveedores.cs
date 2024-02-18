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
    public partial class CProveedores : Form
    {
        CN_Proveedor objetoCNProveedor = new CN_Proveedor();

        public CProveedores()
        {
            InitializeComponent();
        }

        private void CProveedores_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            button3.Visible = false;
        }
        private void MostrarClientes()
        {
            dgvProveedor.DataSource = objetoCNProveedor.MostrarProveedor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvProveedor.CurrentCell = null;
            string busquedaProveedores = textBox1.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaProveedores.ToLower()))
            {
                foreach (DataGridViewRow row in dgvProveedor.Rows)
                {
                    string RFC = row.Cells["PRORFC"].Value.ToString().ToLower();
                    string NOMBRE = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string DIRECCION = row.Cells["DIRECCION"].Value.ToString().ToLower();
                    string CORREO = row.Cells["CORREOELECTRONICO"].Value.ToString().ToLower();
                    string CONTACTO = row.Cells["CONTACTO"].Value.ToString().ToLower();
                    string TELEFONO = row.Cells["TELEFONO"].Value.ToString().ToLower();
                    if (RFC.Contains(busquedaProveedores) || NOMBRE.Contains(busquedaProveedores) || DIRECCION.Contains(busquedaProveedores) || CORREO.Contains(busquedaProveedores) || CONTACTO.Contains(busquedaProveedores) || TELEFONO.Contains(busquedaProveedores))
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
                foreach (DataGridViewRow row in dgvProveedor.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
