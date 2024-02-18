using PEscritorio.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CapaDatos;

namespace PEscritorio
{
    public partial class Login : Form
    {
        private CD_Conexion conexion1 = new CD_Conexion();
        private CD_Conexion conexion2 = new CD_Conexion();

        string user = "";
        string pass = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Logear();
                //this.Hide();
                //Form1 Menuprincipal = new Form1();
                //Menuprincipal.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        public void Logear()
        {

            //LOGEAR EL ADMINISTRADOR
            SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "SELECT  U.NOMBRE, U.PASWORD FROM USUARIOS U WHERE U.NOMBRE ='" + txtUsuario.Text + "' AND U.PASWORD = '" + txtContraseña.Text + "' AND U.TIPO = 'Administrador'";
            SqlDataReader leer; //LEER FILAS DE LA TABLA
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido admin");
                this.Hide();
                Form1 Menuprincipal = new Form1(txtUsuario.Text, "Administrador", 0);
                Corte cort = new Corte(txtUsuario.Text, 0);
                Ventas ven = new Ventas(txtUsuario.Text);
                FormSaldoInicial abrircaja = new FormSaldoInicial(txtUsuario.Text, "Administrador");
                abrircaja.Show();
            }

            conexion1.CerrarConexion();

            //LOGEAR EL EMPLEADO
            SqlCommand comando1 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando1.Connection = conexion2.AbrirConexion();
            comando1.CommandText = "SELECT  U.NOMBRE, U.PASWORD FROM USUARIOS U WHERE U.NOMBRE ='" + txtUsuario.Text + "' AND U.PASWORD = '" + txtContraseña.Text + "' AND U.TIPO = 'Empleado'";
            SqlDataReader leer1; //LEER FILAS DE LA TABLA
            leer1 = comando1.ExecuteReader();
            if (leer1.Read())
            {
                MessageBox.Show("Bienvenido Empleado");
                this.Hide();
                Form1 Menuprincipal = new Form1(txtUsuario.Text, "Empleado", 0);
                Corte cort = new Corte(txtUsuario.Text, 0);
                Ventas ven = new Ventas(txtUsuario.Text);
                FormSaldoInicial abrircaja = new FormSaldoInicial(txtUsuario.Text, "Empleado");
                abrircaja.Show();


            }

            conexion2.CerrarConexion();


        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "introduzca el usuario";
            txtUsuario.ForeColor = Color.Gray;
            txtContraseña.PasswordChar = '\0';
            txtContraseña.Text = "introduzca la contraseña";
            txtContraseña.ForeColor = Color.Gray;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            user = txtUsuario.Text;
            if (user.Equals("introduzca el usuario"))
            {
                txtUsuario.Text = "introduzca el usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    txtUsuario.Text = "introduzca el usuario";
                    txtUsuario.ForeColor = Color.Gray;
                }
                else
                {
                    txtUsuario.Text = user;
                    txtUsuario.ForeColor = Color.Black;
                }
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.PasswordChar= '*';
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            pass = txtContraseña.Text;
            if (pass.Equals("introduzca la contraseña"))
            {
                txtContraseña.Text = "introduzca la contraseña";
                txtContraseña.ForeColor = Color.Gray;
            }
            else
            {
                if (pass.Equals(""))
                {
                    txtContraseña.PasswordChar = '\0'; 
                    txtContraseña.Text = "introduzca la contraseña";
                    txtContraseña.ForeColor = Color.Gray;
                }
                else
                {
                    txtContraseña.PasswordChar = '*';
                    txtContraseña.Text = pass;
                    txtContraseña.ForeColor = Color.Black;
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperarContraseña RecuperarContra = new RecuperarContraseña();
            RecuperarContra.Show();
        }
    }
}
