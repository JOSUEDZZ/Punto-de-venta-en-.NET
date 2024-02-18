using CapaDatos;
using CapaNegocio;
using PEscritorio.Vistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PEscritorio
{
    public partial class CClientes : Form
    {
      
        CN_Clientes objetoCNCliente = new CN_Clientes();


        private CD_Conexion conexion1 = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados


        public void Desaparecer()
        {
          
        }
        private void MostrarClientes()
        {
            dgvClientes.DataSource = objetoCNCliente.MostrarCliente();
        }


       

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            Desaparecer();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void BtnCCompras_Click_1(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            this.Close();
            PantallasCCompra.ShowDialog();
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

        public CClientes()
        {
            InitializeComponent();
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

       
        private void CClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //PENDIENTE
            if (dgvClientes.SelectedRows.Count > 0)
            {
                RClientes pantallaClientesRegistro = new RClientes();
                pantallaClientesRegistro.Show();

            }
        }
        private void MostrarNombre()
        {
            dgvClientes.DataSource = BuscarClienteNombre(txtBuscar.Text);
            dgvClientes.Refresh();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
          
        }

        public DataTable BuscarClienteNombre(string NOMBRE_C)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "BuscarNombreCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_C", NOMBRE_C);
            leer = comando.ExecuteReader();

            tabla.Load(leer);
            conexion1.CerrarConexion();

            return tabla;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {

            //txtBuscar_TextChanged(sender, e);
            
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            dgvClientes.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    string rfc = row.Cells["CLIRFC"].Value.ToString().ToLower();
                    string nombre = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string direccion = row.Cells["DIRECCION"].Value.ToString().ToLower();
                    string correo = row.Cells["CORREOELECTRONICO"].Value.ToString().ToLower();
                    string postal = row.Cells["CODIGOPOSTAL"].Value.ToString().ToLower();
                    string telefono = row.Cells["TELEFONO"].Value.ToString().ToLower();
                    if (rfc.Contains(searchText) || nombre.Contains(searchText) || direccion.Contains(searchText) || correo.Contains(searchText) || postal.Contains(searchText) || telefono.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    row.Visible = true;
                }
            }

        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged_1(sender, e);

        }
    }
}
