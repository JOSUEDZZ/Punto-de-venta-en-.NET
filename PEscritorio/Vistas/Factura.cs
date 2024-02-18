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
    public partial class Factura : Form
    {
        CD_FACTURA objetoCDFACTURAS = new CD_FACTURA();
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCapTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int Noticket = Convert.ToInt32(txtNoventa.Text);
                DgvDetalles.DataSource = objetoCDFACTURAS.Mostrar(Noticket);
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "BUSCARNOMCLIENTE";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@NOventa", Noticket);
                leer = comando.ExecuteReader();
                if (leer.Read()!= false)
                {
                    txtRFC.Text = leer["RFCCLIENTE"].ToString();
                    txtCORREO.Text = leer["CORREOELECTRONICO"].ToString();
                    txtDireccion.Text = leer["DIRECCION"].ToString();
                    txtCelular.Text = leer["TELEFONO"].ToString();
                    txtCP.Text = leer["CODIGOPOSTAL"].ToString();
                    LBTOTAL.Text = leer["TOTAL"].ToString();
                    TXTnOMBREC.Text = leer["CLIENTE"].ToString();
                }
                else
                {
                    MessageBox.Show("El ticket no existe");
                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo pinches salio mal" + ex);
            }
        }
        public void mostrardetalles()
        {
           
        }
        public Factura()
        {
            InitializeComponent();
            //para la ultimaventa
            conexion1.AbrirConexion();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "select max(NOVENTA) as NUMP from VENTAS ";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtNoventa.Text = leer["NUMP"].ToString();
            }
            conexion1.CerrarConexion();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNoventa.Text == "" || txtRFC.Text == "")
            {
                MessageBox.Show("INGRESA UNA FACTURA");
            }
            else
            {
                int Noventa = Convert.ToInt32(txtNoventa.Text);
                FRMJOS NuevoFRM = new FRMJOS(Noventa);
                NuevoFRM.ShowDialog();
            }
            
        }
    }
}
