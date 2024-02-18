using CapaNegocio;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class RUsuario : Form
    {
        CN_Usuario objetoCNUser = new CN_Usuario();
        string nombre = "";
        string rfc = "";
        private void BuscarUsuario()
        {
            dgvBuscarUsuario.DataSource = objetoCNUser.MostrarUsuario();
            dgvBuscarUsuario.Refresh();
        }
        private void btnRFC_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvBuscarUsuario.SelectedRows[0].Index);
                txtRFC.Text = dgvBuscarUsuario.Rows[ro].Cells[0].Value.ToString();
                txtNobre.Text = dgvBuscarUsuario.Rows[ro].Cells[1].Value.ToString();
                txtDirección.Text = dgvBuscarUsuario.Rows[ro].Cells[2].Value.ToString();
                txtCurp.Text = dgvBuscarUsuario.Rows[ro].Cells[3].Value.ToString();
                txtCodigoPostal.Text = dgvBuscarUsuario.Rows[ro].Cells[4].Value.ToString();
                txtCiudad.Text = dgvBuscarUsuario.Rows[ro].Cells[5].Value.ToString();
                DateFechaNac.Value = Convert.ToDateTime(dgvBuscarUsuario.Rows[ro].Cells[6].Value.ToString());
                txtTelefono.Text = dgvBuscarUsuario.Rows[ro].Cells[7].Value.ToString();

                if (rbAdmin.Text == dgvBuscarUsuario.Rows[ro].Cells[8].Value.ToString())
                {
                    rbAdmin.Checked = true;
                }
                if (rbEmpleado.Text == dgvBuscarUsuario.Rows[ro].Cells[8].Value.ToString())
                {
                    
                    rbEmpleado.Checked = true;

                }
                txtContraseña.Text = dgvBuscarUsuario.Rows[ro].Cells[9].Value.ToString();
                txtPregunta.Text = dgvBuscarUsuario.Rows[ro].Cells[10].Value.ToString();
                txtRespueta.Text = dgvBuscarUsuario.Rows[ro].Cells[11].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            Pbusqueda.Visible = false;
        }

        private void RUsuario_Load(object sender, EventArgs e)
        {
            DateFechaNac.Focus();

            txtNobre.Text = "Nombre";
            txtNobre.ForeColor = Color.Gray;

            txtRFC.Text = "RFC";
            txtRFC.ForeColor = Color.Gray;


            txtDirección.Text = "Dirección";
            txtDirección.ForeColor = Color.Gray;

            txtCodigoPostal.Text = "Código postal";
            txtCodigoPostal.ForeColor = Color.Gray;

            txtCurp.Text = "CURP";
            txtCurp.ForeColor = Color.Gray;

            txtCiudad.Text = "Ciudad";
            txtCiudad.ForeColor = Color.Gray;

            txtTelefono.Text = "Telefono";
            txtTelefono.ForeColor = Color.Gray;

            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.Gray;

            txtPregunta.Text = "Pregunta de seguridad";
            txtPregunta.ForeColor = Color.Gray;

            txtRespueta.Text = "Respuesta";
            txtRespueta.ForeColor = Color.Gray;
        }
        private void btnBuscarRFCEmpleado_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
            Pbusqueda.Visible = true;
            btnRFC.Visible = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Pbusqueda.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCNUser.EliminarUsuario(txtRFC.Text);
                MessageBox.Show("Se elimino correctamente");
                BuscarUsuario();
                Limpiar();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo al eliminar");
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbAdmin.Checked == true)
                {
                    objetoCNUser.EditarUsuario(txtRFC.Text, txtNobre.Text, txtDirección.Text, txtCurp.Text, txtCodigoPostal.Text, txtCiudad.Text, DateFechaNac.Value, Convert.ToDecimal(txtTelefono.Text), rbAdmin.Text, txtContraseña.Text, txtPregunta.Text, txtRespueta.Text);
                    MessageBox.Show("Se actualizo correctamente");
                }
                if (rbEmpleado.Checked == true)
                {
                    objetoCNUser.EditarUsuario(txtRFC.Text, txtNobre.Text, txtDirección.Text, txtCurp.Text, txtCodigoPostal.Text, txtCiudad.Text, DateFechaNac.Value, Convert.ToDecimal(txtTelefono.Text), rbEmpleado.Text, txtContraseña.Text, txtPregunta.Text, txtRespueta.Text);
                    MessageBox.Show("Se actualizo correctamente");
                }
                BuscarUsuario();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos");
            }
        }

        private void Pbusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNobre_Click(object sender, EventArgs e)
        {
            if (txtNobre.Text == "Nombre")
            {
                txtNobre.Clear();
            }
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRFC_Click(object sender, EventArgs e)
        {

            if (txtRFC.Text == "RFC")
            {
                txtRFC.Clear();
            }
        }

        private void txtNobre_Leave(object sender, EventArgs e)
        {
            //nombre = txtNobre.Text;
            //if (nombre.Equals("Nombre"))
            //{
            //    txtNobre.Text = "Nombre";
            //    txtNobre.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    if (nombre.Equals(""))
            //    {
            //        txtNobre.Text = "Nombre";
            //        txtNobre.ForeColor = Color.Gray;
            //    }
            //    else
            //    {
            //        txtNobre.Text = nombre;
            //        txtNobre.ForeColor = Color.Black;
            //    }
            //}
        }

        private void txtNobre_Enter(object sender, EventArgs e)
        {
            //txtNobre.Text = "";
            //txtNobre.ForeColor = Color.Black;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvBuscarUsuario.CurrentCell = null;
            string busquedaClientes = txtBuscar.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaClientes.ToLower()))
            {
                foreach (DataGridViewRow row in dgvBuscarUsuario.Rows)
                {
                    string rfc = row.Cells["URFC"].Value.ToString().ToLower();
                    string nombre = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string direccion = row.Cells["DIRECCION"].Value.ToString().ToLower();
                    string curp = row.Cells["CURP"].Value.ToString().ToLower();
                    string codigopostal = row.Cells["CODIGOPOSTAL"].Value.ToString().ToLower();
                    string ciudad = row.Cells["CIUDAD"].Value.ToString().ToLower();
                    string fecha = row.Cells["FECHANACI"].Value.ToString().ToLower();
                    string tel = row.Cells["TELEFONO"].Value.ToString().ToLower();
                    string tipo = row.Cells["TIPO"].Value.ToString().ToLower();
                    string pass = row.Cells["PASWORD"].Value.ToString().ToLower();
                    string pregunta = row.Cells["PREGUNTA"].Value.ToString().ToLower();
                    string respuesta = row.Cells["RESPUESTA"].Value.ToString().ToLower();
                    if (rfc.Contains(busquedaClientes) || nombre.Contains(busquedaClientes) || direccion.Contains(busquedaClientes) || curp.Contains(busquedaClientes) || codigopostal.Contains(busquedaClientes) || ciudad.Contains(busquedaClientes) || fecha.Contains(busquedaClientes) || tel.Contains(busquedaClientes) || tipo.Contains(busquedaClientes) || pass.Contains(busquedaClientes) || pregunta.Contains(busquedaClientes) || respuesta.Contains(busquedaClientes))
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
                foreach (DataGridViewRow row in dgvBuscarUsuario.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged(sender,  e);
        }
        public void Limpiar()
        {
            txtCiudad.Text = "";
            txtRFC.Text = "";
            txtNobre.Text = "";
            txtDirección.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            txtContraseña.Text = "";
            txtPregunta.Text = "";
            txtRespueta.Text = "";
            txtCurp.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var d = DateFechaNac.Value.ToString("dd/MM/yyyy");

                if (rbAdmin.Checked == true)
                {
                    objetoCNUser.InsertarRegistro(txtRFC.Text, txtNobre.Text, txtDirección.Text, txtCurp.Text, txtCodigoPostal.Text, txtCiudad.Text, DateFechaNac.Value, Convert.ToDecimal(txtTelefono.Text), rbAdmin.Text, txtContraseña.Text, txtPregunta.Text, txtRespueta.Text);
                    MessageBox.Show("Se inserto correctamente");

                }
                if (rbEmpleado.Checked == true)
                {
                    objetoCNUser.InsertarRegistro(txtRFC.Text, txtNobre.Text, txtDirección.Text, txtCurp.Text, txtCodigoPostal.Text, txtCiudad.Text, DateFechaNac.Value, Convert.ToDecimal(txtTelefono.Text), rbEmpleado.Text, txtContraseña.Text, txtPregunta.Text, txtRespueta.Text);
                    MessageBox.Show("Se inserto correctamente");
                }
                BuscarUsuario();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }            
        }
        public RUsuario()
        {
            InitializeComponent();            
        }

        private void txtNobre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDirección_Click(object sender, EventArgs e)
        {
            if (txtDirección.Text == "Dirección")
            {
                txtDirección.Clear();
            }
        }

        private void txtCurp_Click(object sender, EventArgs e)
        {

            if (txtCurp.Text == "CURP")
            {
                txtCurp.Clear();
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Clear();
            }
        }

        private void txtPregunta_Click(object sender, EventArgs e)
        {
            if (txtPregunta.Text == "Pregunta de seguridad")
            {
                
            }
        }

        private void txtCodigoPostal_Click(object sender, EventArgs e)
        {
            if (txtCodigoPostal.Text == "Código postal")
            {
                txtCodigoPostal.Clear();
            }
        }

        private void txtCiudad_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "Ciudad")
            {
                txtCiudad.Clear();
            }
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Clear();
            }
        }

        private void txtRespueta_Click(object sender, EventArgs e)
        {
            if (txtRespueta.Text == "Respuesta")
            {
                txtRespueta.Clear();
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
