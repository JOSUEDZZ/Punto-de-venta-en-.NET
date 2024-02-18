using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class RPintura : Form
    {
        CN_mercanciaP objPinturas = new CN_mercanciaP();
        private CD_Conexion conexion1 = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
        public RPintura()
        {
            InitializeComponent();
            CBUnidad.SelectedIndex = 0;
            CBTipoPin.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objPinturas.InsertarRegistro(txtCodigo.Text, txtMarca.Text, txtColor.Text, "0", "0", "0",CBTipoPin.Text, CBUnidad.Text, txtProveedor.Text);
                MessageBox.Show("Se inserto correctamente");
                LimpiarTxt();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error por: " + Ex);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objPinturas.EditarPintura(txtCodigo.Text, txtMarca.Text, txtColor.Text, "0", "0", "0", CBTipoPin.Text, CBUnidad.Text, txtProveedor.Text);
                MessageBox.Show("Se actualizo correctamente");
                LimpiarTxt();


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
                objPinturas.EliminarMaterial(txtCodigo.Text);
                MessageBox.Show("Se elimino correctamente");
                LimpiarTxt();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error por: " + Ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Tipo = "", Unidad = "";
            try
            {
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = " SELECT M.CODIGO, M.MARCA, M.PRECIO, M.CANTIDAD, M.FKPRORFC,P.CODIGO, P.COLOR, P.TIPO, P.UNIDADDEMEDIDA FROM MERCANCIA M INNER JOIN PINTURA P ON M.CODIGO = P.CODIGO WHERE M.CODIGO = " + txtCodigo.Text + "";
               
                leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtCodigo.Text = leer["CODIGO"].ToString();
                    txtMarca.Text = leer["MARCA"].ToString();
                    txtColor.Text = leer["COLOR"].ToString();
                    Tipo = leer["TIPO"].ToString();
                    Unidad = leer["UNIDADDEMEDIDA"].ToString();
                    txtProveedor.Text = leer["FKPRORFC"].ToString();
                }
                conexion1.CerrarConexion();
                switch (Unidad)
                {
                    case "Litro":
                        CBUnidad.SelectedIndex = 0;
                        break;
                    case "Medio Litro":
                        CBUnidad.SelectedIndex = 1;
                        break;
                    case "Galon":
                        CBUnidad.SelectedIndex = 2;
                        break;
                }
                switch (Tipo)
                {
                    case "Bicapa":
                        CBUnidad.SelectedIndex = 0;
                        break;
                    case "Esmalte acrílicoo":
                        CBUnidad.SelectedIndex = 1;
                        break;
                    case "Esmalte de poliuretano":
                        CBUnidad.SelectedIndex = 2;
                        break;
                    case "smalte secado rápido":
                        CBUnidad.SelectedIndex = 3;
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: " + ex);
            }            
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BuscarProveedorPinturas()
        {
            dgvBuscarPinturas.DataSource = objPinturas.MostrarProveedores();
            dgvBuscarPinturas.Refresh();
        }
        private void BuscarMarcaPinturas()
        {
            dgvBuscarPinturas.DataSource = objPinturas.MostrarMarca();
            dgvBuscarPinturas.Refresh();
        }
        private void BuscarCodigo()
        {
            dgvBuscarPinturas.DataSource = objPinturas.MostrarCodigo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCodigo();
            btnCodigo.Visible = true;
            btnAceptarProvedor.Visible = false;
            btnMarca.Visible = false;
            Pbusqueda.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BuscarMarcaPinturas();
            Pbusqueda.Visible = true;
            btnMarca.Visible = true;
            btnAceptarProvedor.Visible = false;
            btnCodigo.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarProveedorPinturas();
            Pbusqueda.Visible = true;
            btnAceptarProvedor.Visible = true;
            btnCodigo.Visible = false;
            btnMarca.Visible = false;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvBuscarPinturas.SelectedRows[0].Index);
                txtMarca.Text = dgvBuscarPinturas.Rows[ro].Cells[0].Value.ToString();
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
            txtBuscar.Clear();
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "Código")
            {
                txtCodigo.Clear();
            }
        }

        private void txtMarca_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Clear();
            }
        }

        private void txtColor_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "Color")
            {
                txtColor.Clear();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvBuscarPinturas.CurrentCell = null;
            string busquedaProveedores = txtBuscar.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaProveedores.ToLower()))
            {
                foreach (DataGridViewRow row in dgvBuscarPinturas.Rows)
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
                foreach (DataGridViewRow row in dgvBuscarPinturas.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void btnAceptarProvedor_Click(object sender, EventArgs e)
        {
            int ro = Convert.ToInt32(dgvBuscarPinturas.SelectedRows[0].Index);
            txtProveedor.Text = dgvBuscarPinturas.Rows[ro].Cells[0].Value.ToString();
            Pbusqueda.Visible = false;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            int ro = Convert.ToInt32(dgvBuscarPinturas.SelectedRows[0].Index);
            txtCodigo.Text = dgvBuscarPinturas.Rows[ro].Cells[0].Value.ToString();
            Pbusqueda.Visible = false;
        }
        public void LimpiarTxt()
        {
            txtCodigo.Text = "Código";
            txtMarca.Text = "Marca";
            CBTipoPin.SelectedIndex = 0;
            txtColor.Text = "Color";
            CBUnidad.SelectedIndex = 0;
            txtProveedor.Text = "Proveedor";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }

        private void Pbusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBuscarPinturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RPintura_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
