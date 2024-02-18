using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class RClientes : Form
    {
        CN_Clientes objetoCNCliente = new CN_Clientes();

        private CD_Conexion conexion1 = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados

        public RClientes()
        {
            InitializeComponent();            
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCNCliente.InsertarRegistro(txtRFC.Text, txtNombre.Text, txtDireccion.Text, txtCorreo.Text, txtCodigoPostal.Text, txtTelefono.Text);
                MessageBox.Show("Se inserto correctamente");
                Limpiar();
            }
            catch 
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void RClientes_Load(object sender, EventArgs e)
        {

        }
        
        public void Limpiar()
        {
            txtCorreo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                objetoCNCliente.ActualizarCliente(txtRFC.Text, txtNombre.Text, txtDireccion.Text, txtCorreo.Text, txtCodigoPostal.Text, txtTelefono.Text);
                MessageBox.Show("Se actualizo el cliente:" + txtRFC.Text);
                txtRFC.Focus();
                Limpiar();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error por: " + Ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                
                objetoCNCliente.EliminarCliente(txtRFC.Text);
                MessageBox.Show("Se elimino el cliente:" + txtRFC.Text);
                txtRFC.Focus();
                Limpiar();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error por: " + Ex);
            }
          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "SELECT * FROM CLIENTES Where CLIRFC = " + txtRFC.Text + "";
                leer = comando.ExecuteReader();


                if (leer.Read())
                {
                    txtRFC.Text = leer["CLIRFC"].ToString();
                    txtNombre.Text = leer["NOMBRE_C"].ToString();
                    txtDireccion.Text = leer["DIRECCION_C"].ToString();
                    txtCorreo.Text = leer["CORREOELECTRONICO_C"].ToString();
                    txtCodigoPostal.Text = leer["CODIGOPOSTAL_C"].ToString();
                    txtTelefono.Text = leer["TELEFONO_C"].ToString();
                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: " + ex);
            }
           

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BuscarRFC()
        {
            dgvBuscarClientes.DataSource = objetoCNCliente.MostrarRFC();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BuscarRFC();
            Pbusqueda.Visible = true;
            btnAceptarRFC.Visible = true;
        }

        private void btnAceptarProvedor_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvBuscarClientes.SelectedRows[0].Index);
                txtRFC.Text = dgvBuscarClientes.Rows[ro].Cells[0].Value.ToString();
                txtNombre.Text = dgvBuscarClientes.Rows[ro].Cells[1].Value.ToString();
                txtDireccion.Text = dgvBuscarClientes.Rows[ro].Cells[2].Value.ToString();
                txtCorreo.Text = dgvBuscarClientes.Rows[ro].Cells[3].Value.ToString();
                txtCodigoPostal.Text = dgvBuscarClientes.Rows[ro].Cells[4].Value.ToString();
                txtTelefono.Text = dgvBuscarClientes.Rows[ro].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            Pbusqueda.Visible = false;
        }
        private void btnNombreCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvBuscarClientes.SelectedRows[0].Index);
                txtRFC.Text = dgvBuscarClientes.Rows[ro].Cells[0].Value.ToString();
                txtNombre.Text = dgvBuscarClientes.Rows[ro].Cells[1].Value.ToString();
                txtDireccion.Text = dgvBuscarClientes.Rows[ro].Cells[2].Value.ToString();
                txtCorreo.Text = dgvBuscarClientes.Rows[ro].Cells[3].Value.ToString();
                txtCodigoPostal.Text = dgvBuscarClientes.Rows[ro].Cells[4].Value.ToString();
                txtTelefono.Text = dgvBuscarClientes.Rows[ro].Cells[5].Value.ToString();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRFC_Click(object sender, EventArgs e)
        {
            if (txtRFC.Text == "RFC")
            {
                txtRFC.Clear();
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Clear();
            }
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Clear();
            }
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electronico")
            {
                txtCorreo.Clear();
            }
        }

        private void txtCodigoPostal_Click(object sender, EventArgs e)
        {
            if (txtCodigoPostal.Text == "Código postal")
            {
                txtCodigoPostal.Clear();
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Clear();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
