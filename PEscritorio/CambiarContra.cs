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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PEscritorio
{
    public partial class CambiarContra : Form
    {
        private CD_Conexion conexion1 = new CD_Conexion();

        string NOMBRE ;
        double TELEFONO;
        string PREGUNT;
        string RESPUESTA;
        public CambiarContra(string NOMBRE, double TELEFONO, string PREGUNT, string RESPUESTA)
        {
            InitializeComponent();
            this.NOMBRE = NOMBRE;
            this.TELEFONO = TELEFONO;
            this.PREGUNT = PREGUNT;
            this.RESPUESTA = RESPUESTA;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            string PASWORD = txtConfirmarCoontra.Text;
            try
            {
                if (txtConfirmarCoontra.Text != txtNuevaContra.Text)
                {
                    MessageBox.Show("No son iguales las contraseñas, vuelve a intentar");
                }
                else if (txtNuevaContra.Text.Length < 5 && txtNuevaContra.Text.Length < 5)
                {
                    MessageBox.Show("Debe tener al menos 5 caracteres");
                }
                else
                {
                    SqlCommand comando1 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
                    comando1.Connection = conexion1.AbrirConexion();
                    comando1.CommandText = "CambiarContra";
                    comando1.CommandType = CommandType.StoredProcedure;
                    comando1.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                    comando1.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                    comando1.Parameters.AddWithValue("@PREGUNTA", PREGUNT);
                    comando1.Parameters.AddWithValue("@RESPUESTA", RESPUESTA);
                    comando1.Parameters.AddWithValue("@PASWORD", PASWORD);

                    SqlDataReader leer; //LEER FILAS DE LA TABLA
                    leer = comando1.ExecuteReader();
                    if (!leer.Read())
                    {
                        MessageBox.Show("Cambio exitoso");
                        this.Hide();
                        Login log = new Login();
                        log.Show();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar");
                    }

                    conexion1.CerrarConexion();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNuevaContra_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text.Length < 5)
            {
                txtNuevaContra.BackColor = Color.Red;
            }
            else
            {
                txtNuevaContra.BackColor = Color.White;
            }
        }
        private void txtConfirmarCoontra_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarCoontra.Text.Length < 5)
            {
                txtConfirmarCoontra.BackColor = Color.Red;
            }
            else
            {
                txtConfirmarCoontra.BackColor = Color.White;
            }
        }

        private void CambiarContra_Load(object sender, EventArgs e)
        {

        }
    }
}
