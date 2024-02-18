using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class RProveedor : Form
    {
        private CN_Proveedor objProvee = new CN_Proveedor();
        private CD_Conexion conexion1 = new CD_Conexion();
        public RProveedor()
        {
            InitializeComponent();
            MostrarProveedor();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                objProvee.InsertarRegistro(txtRFCp.Text, txtNomCop.Text, txtDirec.Text, txtCorElecp.Text, txtContacto.Text, decimal.Parse(txtTelp.Text));
                MessageBox.Show("Se inserto correctamente");
                MostrarProveedor();
                limpiar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error por: ");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            txtRFCp.Clear();
            txtContacto.Clear();
            txtCorElecp.Clear();
            txtDirec.Clear();
            txtNomCop.Clear();
            txtTelp.Clear();
        }

        private void BtnBusPro_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = " SELECT P.NOMBRE, P.DIRECCION, P.CORREOELECTRONICO, P.CONTACTO, P.TELEFONO FROM PROVEEDORES P WHERE P.PRORFC = '" + txtRFCp.Text + "'";
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtNomCop.Text = leer["NOMBRE"].ToString();
                    txtContacto.Text = leer["CONTACTO"].ToString();
                    txtDirec.Text = leer["DIRECCION"].ToString();
                    txtCorElecp.Text = leer["CORREOELECTRONICO"].ToString();
                    txtTelp.Text = leer["TELEFONO"].ToString();
                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: ");
            }
        }

        private void BtnEdPro_Click(object sender, EventArgs e)
        {
            try
            {
                objProvee.EditarProveedores(txtRFCp.Text, txtNomCop.Text, txtDirec.Text, txtCorElecp.Text, txtContacto.Text, decimal.Parse(txtTelp.Text));
                MessageBox.Show("Se actualizo correctamente");
                MostrarProveedor();
                limpiar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error por: " );
            }
        }

        private void BtnElimp_Click(object sender, EventArgs e)
        {
            try
            {
                objProvee.EliminarProveedor(txtRFCp.Text);
                MessageBox.Show("Se elimino correctamente");
                MostrarProveedor();
                limpiar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error por: ");
            }
        }
        private void MostrarProveedor()
        {
            DGVProvee.DataSource = objProvee.MostrarProveedor();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pbusqueda.Visible = true;
            btnRFCp.Visible = true;
            btnAcepDirec.Visible = false;
            btnAcepNomCom.Visible = false;
        }

        private void btnRFCp_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(DGVProvee.SelectedRows[0].Index);
                txtRFCp.Text = DGVProvee.Rows[ro].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            Pbusqueda.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Pbusqueda.Visible = false;
        }

        private void BtnBusNomCom_Click(object sender, EventArgs e)
        {
            Pbusqueda.Visible = true;
            btnAcepNomCom.Visible = true;
            btnAcepDirec.Visible = false;
            btnRFCp.Visible = false;
        }

        private void btnAcepNomCom_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(DGVProvee.SelectedRows[0].Index);
                txtNomCop.Text = DGVProvee.Rows[ro].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            Pbusqueda.Visible = false;
        }

        private void BtnBusDirec_Click(object sender, EventArgs e)
        {
            Pbusqueda.Visible = true;
            btnAcepDirec.Visible = true;
            btnAcepNomCom.Visible = false;
            btnRFCp.Visible = false;
        }

        private void btnAcepDirec_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(DGVProvee.SelectedRows[0].Index);
                txtDirec.Text = DGVProvee.Rows[ro].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            Pbusqueda.Visible = false;
        }

        private void txtRFCp_TextChanged(object sender, EventArgs e)
        {
            if (txtRFCp.Text == "RFC")
            {
                txtRFCp.Clear();
            }
        }

        private void txtNomCop_TextChanged(object sender, EventArgs e)
        {
            if (txtNomCop.Text == "Nombre Comercial")
            {
                txtNomCop.Clear();
            }
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "Nombre del contacto")
            {
                txtContacto.Clear();
            }
        }

        private void txtDirec_TextChanged(object sender, EventArgs e)
        {
            if (txtDirec.Text == "Dirección")
            {
                txtDirec.Clear();
            }
        }

        private void txtTelp_TextChanged(object sender, EventArgs e)
        {
            if (txtTelp.Text == "Teléfono")
            {
                txtTelp.Clear();
            }
        }

        private void txtCorElecp_TextChanged(object sender, EventArgs e)
        {
            if (txtCorElecp.Text == "Correo Electrónico")
            {
                txtCorElecp.Clear();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DGVProvee.CurrentCell = null;
            string busquedaProveedores = txtBuscar.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaProveedores.ToLower()))
            {
                foreach (DataGridViewRow row in DGVProvee.Rows)
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
                foreach (DataGridViewRow row in DGVProvee.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtRFCp_Click(object sender, EventArgs e)
        {
            if (txtRFCp.Text == "RFC")
            {
                txtRFCp.Clear();
            }
        }

        private void txtNomCop_Click(object sender, EventArgs e)
        {
            if (txtNomCop.Text == "Nombre Comercial")
            {
                txtNomCop.Clear();
            }
        }

        private void txtContacto_Click(object sender, EventArgs e)
        {
            if (txtContacto.Text == "Nombre del contacto")
            {
                txtContacto.Clear();
            }
        }

        private void txtDirec_Click(object sender, EventArgs e)
        {
            if (txtDirec.Text == "Dirección")
            {
                txtDirec.Clear();
            }
        }

        private void txtTelp_Click(object sender, EventArgs e)
        {
            if (txtTelp.Text == "Telefono")
            {
                txtTelp.Clear();
            }
        }

        private void txtCorElecp_Click(object sender, EventArgs e)
        {
            if (txtCorElecp.Text == "Correo Electrónico")
            {
                txtCorElecp.Clear();
            }
        }

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
} 
 

