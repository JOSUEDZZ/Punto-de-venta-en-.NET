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
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class RMateriales : Form
    {
        CN_mercanciaM objMateriales = new CN_mercanciaM();
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
       
        public RMateriales()
        {
            InitializeComponent();
            CBUnidad.SelectedIndex = 0;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objMateriales.InsertarRegistro(txtCodigo.Text, txtMarca.Text, txtProducto.Text, CBUnidad.Text, "0", "0", "0", txtProveedor.Text);
                MessageBox.Show("Se inserto correctamente");
                Limpiar();
                MostrarMateriales();
                MostrarMarcaMateriales();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objMateriales.EditarMateriales(txtCodigo.Text, txtMarca.Text, txtProducto.Text, CBUnidad.Text, "0", "0", "0", txtProveedor.Text);
                MessageBox.Show("Se actualizo correctamente");
                Limpiar();
                MostrarMateriales();
                MostrarMarcaMateriales();

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                objMateriales.EliminarMaterial(txtCodigo.Text);
                MessageBox.Show("Se elimino correctamente");
                MostrarMateriales();
                MostrarMarcaMateriales();
                Limpiar();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string unidad = "";
            try
            {
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = " SELECT  MT.CODIGO, M.MARCA, MT.Producto, MT.Unidad, M.PRECIO, M.CANTIDAD, M.FKPRORFC FROM MERCANCIA M INNER JOIN MATERIALES MT ON  M.CODIGO = MT.CODIGO  WHERE MT.CODIGO = " + txtCodigo.Text + "";
                    
                leer = comando.ExecuteReader();


                if (leer.Read())
                {
                    txtCodigo.Text = leer["CODIGO"].ToString();
                    txtMarca.Text = leer["MARCA"].ToString();
                    txtProducto.Text = leer["Producto"].ToString();
                    unidad= leer["Unidad"].ToString();
                    txtProveedor.Text = leer["FKPRORFC"].ToString();
                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error");
            }
            switch (unidad)
            {
                case "Piezas":
                    CBUnidad.SelectedIndex = 0;
                    break;
                case "Litros":
                    CBUnidad.SelectedIndex = 1;
                    break;
                case "Metros":
                    CBUnidad.SelectedIndex = 2;
                    break;
                case "Galon":
                    CBUnidad.SelectedIndex = 3;
                    break;
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PbusProve.Visible = false;
            PaCodMat.Visible = false;
            Pbusqueda.Visible= true; 
            LabCosa.Text = "Marca";
            BtnAceptarmMarc.Visible= true;
            BtnAcepProdu.Visible= false;
        }
        private void BuscarProveedorMateriales()
        {
            DGVBusPro.DataSource = objMateriales.MostrarProveedoresMercancia();
            DGVBusPro.Refresh();
        }

        private void MostrarMarcaMateriales()
        {
            DGVBusMer.DataSource = objMateriales.MostrarMarcaMateriales();
        }
        private void MostrarMateriales()
        {
            DGVCodigoMer.DataSource = objMateriales.MostrarMercanciaM();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pbusqueda.Visible= false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int ro = Convert.ToInt32(DGVBusMer.SelectedRows[0].Index);
            txtMarca.Text = DGVBusMer.Rows[ro].Cells[1].Value.ToString();
            Pbusqueda.Visible = false;
        }

        private void RMateriales_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            MostrarMarcaMateriales();
            BuscarProveedorMateriales();
        }

        private void txtBusMer_TextChanged(object sender, EventArgs e)
        {
            DGVBusMer.CurrentCell = null;
            string searchText = txtBusMer.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in DGVBusMer.Rows)
                {
                    string Codig = row.Cells["CODIGO"].Value.ToString().ToLower();
                    string mark = row.Cells["MARCA"].Value.ToString().ToLower();
                    string product = row.Cells["Producto"].Value.ToString().ToLower();
                    if (Codig.Contains(searchText) || mark.Contains(searchText) || product.Contains(searchText))
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
                foreach (DataGridViewRow row in DGVBusMer.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DGVCodigoMer.CurrentCell = null;
            string searchText = textBox1.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in DGVCodigoMer.Rows)
                {
                    string Codig = row.Cells["CODIGO"].Value.ToString().ToLower();
                    string mark = row.Cells["MARCA"].Value.ToString().ToLower();
                    string product = row.Cells["Producto"].Value.ToString().ToLower();
                    string unity = row.Cells["Unidad"].Value.ToString().ToLower();
                    string price = row.Cells["PRECIO"].Value.ToString().ToLower();
                    if (Codig.Contains(searchText) || mark.Contains(searchText) || product.Contains(searchText) || unity.Contains(searchText) || price.Contains(searchText))
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
                foreach (DataGridViewRow row in DGVCodigoMer.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaCodMat.Visible = true;
            Pbusqueda.Visible = false;
            PbusProve.Visible = false;
        }

        private void BtnCanCod_Click(object sender, EventArgs e)
        {
            PaCodMat.Visible = false;
        }

        private void BtnCodAcep_Click(object sender, EventArgs e)
        {
            int ro = Convert.ToInt32(DGVCodigoMer.SelectedRows[0].Index);
            txtCodigo.Text = DGVCodigoMer.Rows[ro].Cells[0].Value.ToString();
            PaCodMat.Visible = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

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
            if(txtMarca.Text=="Marca")
                txtMarca.Clear();
        }

        private void txtProducto_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Producto")
                txtProducto.Clear()
;        }

        private void txtProveedor_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "Proveedor")
                txtProveedor.Clear();
        }

        private void BtnAcepProdu_Click(object sender, EventArgs e)
        {
            int ro = Convert.ToInt32(DGVBusMer.SelectedRows[0].Index);
            txtProducto.Text = DGVBusMer.Rows[ro].Cells[2].Value.ToString();
            Pbusqueda.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LabCosa.Text = "Producto";
            BtnAceptarmMarc.Visible = false;
            BtnAcepProdu.Visible = true;
            PaCodMat.Visible = false;
            Pbusqueda.Visible = true;
            PbusProve.Visible = false;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar();   
        }
        public void Limpiar()
        {
            txtCodigo.Text = "Código";
            txtMarca.Text = "Marca";
            txtProducto.Text = "Producto";
            txtProveedor.Text = "Proveedor";
            CBUnidad.SelectedIndex = 0;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, la tecla de retroceso (backspace) y la tecla de suprimir (delete)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Indicar que el evento fue manejado y no se necesita más procesamiento
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaCodMat.Visible = false;
            Pbusqueda.Visible = false;
            PbusProve.Visible = true;
        }

        private void BtnCanProv_Click(object sender, EventArgs e)
        {
            PbusProve.Visible = false;
        }

        private void txtbusProv_TextChanged(object sender, EventArgs e)
        {
            DGVBusPro.CurrentCell = null;
            string searchText = textBox1.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in DGVBusPro.Rows)
                {
                    string Codig = row.Cells["PRORFC"].Value.ToString().ToLower();
                    string mark = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string product = row.Cells["CONTACTO"].Value.ToString().ToLower();
                    if (Codig.Contains(searchText) || mark.Contains(searchText) || product.Contains(searchText))
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
                foreach (DataGridViewRow row in DGVBusPro.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void BtnAcepPro_Click(object sender, EventArgs e)
        {
            int ro = Convert.ToInt32(DGVBusPro.SelectedRows[0].Index);
            txtProveedor.Text = DGVBusPro.Rows[ro].Cells[0].Value.ToString();
            PbusProve.Visible = false;
        }
    }
}
