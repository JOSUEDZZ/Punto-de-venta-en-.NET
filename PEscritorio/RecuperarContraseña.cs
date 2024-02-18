using CapaDatos;
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
    public partial class RecuperarContraseña : Form
    {
        private CD_Conexion conexion1 = new CD_Conexion();
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            double tel = Convert.ToDouble(txtTelefono.Text);
            RecuperarContra(txtNombre.Text, tel, cbPregunta.Text, txtRespuesta.Text);
        }

        public void RecuperarContra(string NOMBRE, double TELEFONO, string PREGUNTA, string RESPUESTA)
        {
            try
            {
                SqlCommand comando1 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
                comando1.Connection = conexion1.AbrirConexion();
                comando1.CommandText = "BuscarUsuario";
                comando1.CommandType = CommandType.StoredProcedure;
                comando1.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                comando1.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                comando1.Parameters.AddWithValue("@PREGUNTA", PREGUNTA);
                comando1.Parameters.AddWithValue("@RESPUESTA", RESPUESTA);


                SqlDataReader leer; 
                leer = comando1.ExecuteReader();
                if (leer.Read())
                {
                    MessageBox.Show("Usuario encontrado");
                    this.Hide();
                    CambiarContra change = new CambiarContra(NOMBRE, TELEFONO, PREGUNTA, RESPUESTA);
                    change.Show();

                }
                else
                {
                    MessageBox.Show("No se encontró");
                }

                conexion1.CerrarConexion();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error");
            }


         
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
