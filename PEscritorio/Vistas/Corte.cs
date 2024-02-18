using CapaDatos;
using CapaNegocio;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

namespace PEscritorio
{
    public partial class Corte : Form
    {
        CN_Usuario objUsuario = new CN_Usuario();
        CN_Corte objCorte = new CN_Corte();
        CD_Balance objBalance = new CD_Balance();

        private CD_Conexion conexion1 = new CD_Conexion();
        private CD_Conexion conexion2 = new CD_Conexion();
        private CD_Conexion conexion3 = new CD_Conexion();
        private CD_Conexion conexion4 = new CD_Conexion();


        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
        string Usuario;  decimal ven = 0;decimal com;
        double Inicial = 0.0; string fe = "";

        public Corte(string usuario, double inicial)
        {
            InitializeComponent();
            Usuario = usuario;
            Inicial = inicial;
            DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
            DateTime fa = DateFechaNac.Value;
            conexion1.AbrirConexion();
            SqlCommand comando2 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando2.Connection = conexion1.AbrirConexion();
            comando2.CommandText = "select max(NOCORTE) +1 as NUMCORTE FROM CORTE";
            SqlDataReader leer2; //LEER FILAS DE LA TABLA
            leer2 = comando2.ExecuteReader();
            if (leer2.Read())
            {
                lblCorte.Text = leer2["NUMCORTE"].ToString();
            }
            conexion1.CerrarConexion();
            //FECHA
            conexion1.AbrirConexion();
            SqlCommand comando3 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando3.Connection = conexion1.AbrirConexion();
            comando3.CommandText = "select max(FECHA) as FACHA FROM CORTE";
            SqlDataReader leer3; //LEER FILAS DE LA TABLA
            leer3 = comando3.ExecuteReader();
            if (leer3.Read())
            {
                fa = Convert.ToDateTime(leer3["FACHA"].ToString());
            }
            conexion1.CerrarConexion();
            fe=fa.ToString();
            //jalar numero de venta
            //para la ultima venta realizada
            conexion1.AbrirConexion();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "select max(NOVENTA) as NUMP from VENTAS ";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                lbNoventa.Text = leer["NUMP"].ToString();
            }
            conexion1.CerrarConexion();

            conexion4.AbrirConexion();
            SqlCommand comando4 = new SqlCommand();
            comando4.Connection = conexion4.AbrirConexion();
            comando4.CommandText = "select max(CFACTURA)  as FAC from FCOMPRAS";
            SqlDataReader leer4; //LEER FILAS DE LA TABLA
            leer4 = comando4.ExecuteReader();
            if (leer4.Read())
            {
                lblfactura.Text = leer4["FAC"].ToString();
            }
            conexion4.CerrarConexion();
            dataGridView1.DataSource = objBalance.MostCuenta(fa);
            MostrarTotalCaja(Convert.ToDateTime(fa));
            txtTotalCorte.Text = ((ven + 1500) - com).ToString();
        }

        //METODO PARA QUE APAREZCA EL RFC DEL USUARIO
        public void BuscarCajaRFC(string NOMBRE)
        {
            try
            {
                conexion3.AbrirConexion();
                SqlCommand comando9 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
                comando9.Connection = conexion3.AbrirConexion();
                comando9.CommandText = "MostrarUsuarioCaja";
                comando9.CommandType = CommandType.StoredProcedure;
                comando9.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                SqlDataReader leer9; //LEER FILAS DE LA TABLA
                leer9 = comando9.ExecuteReader();


                if (leer9.Read())
                {
                    txtEncargadoCaja.Text = leer9["URFC"].ToString();

                }
                conexion3.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: " + ex);
            }
        }
        private void Corte_Load(object sender, EventArgs e)
        {

            BuscarCajaRFC(Usuario);
            lblFondoInicial.Text = Inicial.ToString();
            dataGridView1.DataSource = objBalance.MostCuenta(Convert.ToDateTime(fe));
            //txtTotalTarjeta.Text = "Total tarjeta";
            //txtTotalTarjeta.ForeColor = Color.Gray;

            txtMil.Text = "Mil";
            txtMil.ForeColor = Color.Gray;

            txtCien.Text = "Cien";
            txtCien.ForeColor = Color.Gray;

            txtQuinientos.Text = "Quinientos";
            txtQuinientos.ForeColor = Color.Gray;

            txtCincuenta.Text = "Cincuenta";
            txtCincuenta.ForeColor = Color.Gray;

            txtDoscientos.Text = "Doscientos";
            txtDoscientos.ForeColor = Color.Gray;


            txtVeinte.Text = "Veinte";
            txtVeinte.ForeColor = Color.Gray;


            txtdiez.Text = "Diez";
            txtdiez.ForeColor = Color.Gray;

            txtDos.Text = "Dos";
            txtDos.ForeColor = Color.Gray;

            txtCinco.Text = "Cinco";
            txtCinco.ForeColor = Color.Gray;

            txtUno.Text = "Uno";
            txtUno.ForeColor = Color.Gray;
        }
        private void txtTotalEfectivo_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tc = decimal.Parse(txtTotalCorte.Text);
                decimal tlc = decimal.Parse(txtTotalEfectivo.Text);
                if (tc > tlc)
                {

                    MessageBox.Show("Faltó " + (tc-tlc) + " en caja");
                }
                else
                {
                    MessageBox.Show("Sobro " + (tlc - tc) + " en caja");
                }
                if (txtTotalEfectivo.Text == "0")
                {
                    MessageBox.Show("no ha insertado los valores de caja");
                }
                else
                {
                    objCorte.InsertarRegistro(lblCorte.Text, DateFechaNac.Value, txtTotalCorte.Text, txtTotalEfectivo.Text, Inicial.ToString(), txtEncargadoCaja.Text, lbNoventa.Text, lblfactura.Text);
                    MessageBox.Show("Corte registrado");
                    decimal numeroCorte = Convert.ToDecimal(lblCorte.Text);
                    int Ncorte=Convert.ToInt32(lblCorte.Text);
                    F_CORTE Corte = new F_CORTE(Ncorte,DateTime.Parse(fe));
                    Corte.Show();
                    numeroCorte++;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MostrarTotalEfectivo()
        {
            double TotalEfectivo = 0;
            double Mil = 0;
            double Cien = 0;
            double Quinientos = 0;
            double Cincuenta = 0;
            double Doscientos = 0;
            double Veinte = 0;
            double Diez = 0;
            double Dos = 0;
            double Cinco = 0;
            double Uno = 0;

            double.TryParse(txtMil.Text, out Mil);
            double.TryParse(txtCien.Text, out Cien);
            double.TryParse(txtQuinientos.Text, out Quinientos);
            double.TryParse(txtCincuenta.Text, out Cincuenta);
            double.TryParse(txtDoscientos.Text, out Doscientos);
            double.TryParse(txtVeinte.Text, out Veinte);
            double.TryParse(txtdiez.Text, out Diez);
            double.TryParse(txtDos.Text, out Dos);
            double.TryParse(txtCinco.Text, out Cinco);
            double.TryParse(txtUno.Text, out Uno);

            TotalEfectivo = ((Mil * 1000) + (Cien * 100) + (Quinientos * 500) + (Cincuenta * 50) + (Doscientos * 200) + (Veinte * 20) + (Diez * 10) + (Dos * 2) + (Cinco * 5) + (Uno * 1));
            txtTotalEfectivo.Text = TotalEfectivo.ToString();
        }

        private void txtMil_Click(object sender, EventArgs e)
        {
            if (txtMil.Text == "Mil")
            {
                txtMil.Clear();
            }
        }

        private void txtQuinientos_Click(object sender, EventArgs e)
        {
            if (txtQuinientos.Text == "Quinientos")
            {
                txtQuinientos.Text = "0";
            }
        }

        private void txtCien_Click(object sender, EventArgs e)
        {
            if (txtCien.Text == "Cien")
            {
                txtCien.Text = "0";
            }
        }

        private void txtCincuenta_Click(object sender, EventArgs e)
        {
            if (txtCincuenta.Text == "Cincuenta")
            {
                txtCincuenta.Text = "0";
            }
        }

        private void txtDoscientos_Click(object sender, EventArgs e)
        {
            if (txtDoscientos.Text == "Doscientos")
            {
                txtDoscientos.Text = "0";
            }
        }

        private void txtVeinte_Click(object sender, EventArgs e)
        {
            if (txtVeinte.Text == "Veinte")
            {
                txtVeinte.Text = "0";
            }
        }

        private void txtdiez_Click(object sender, EventArgs e)
        {
            if (txtdiez.Text == "Diez")
            {
                txtdiez.Text = "0";
            }
        }

        private void txtDos_Click(object sender, EventArgs e)
        {
            if (txtDos.Text == "Dos")
            {
                txtDos.Text = "0";
            }
        }

        private void txtUno_Click(object sender, EventArgs e)
        {
            if (txtUno.Text == "Uno")
            {
                txtUno.Text = "0";
            }
        }

        private void txtCinco_Click(object sender, EventArgs e)
        {
            if (txtCinco.Text == "Cinco")
            {
                txtCinco.Text = "0";
            }
        }
        private void txtMil_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }
        private void txtQuinientos_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }
        private void txtCien_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }
        private void txtCincuenta_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }
        private void txtDoscientos_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }

        private void txtVeinte_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }

        private void txtdiez_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }

        private void txtDos_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }

        private void txtCinco_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }

        private void txtUno_TextChanged(object sender, EventArgs e)
        {
            MostrarTotalEfectivo();
        }

        private void txtEncargadoCaja_Click(object sender, EventArgs e)
        {
            if (txtEncargadoCaja.Text == "Encargado Caja")
            {
                txtEncargadoCaja.Clear();
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DateFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEncargadoCaja_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtEncargadoCaja_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtMil_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtMil.Text;
            if (enc.Equals("Mil"))
            {
                txtMil.Text = "Mil";
                txtMil.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtMil.Text = "Mil";
                    txtMil.ForeColor = Color.Gray;
                }
                else
                {
                    txtMil.Text = enc;
                    txtMil.ForeColor = Color.Black;
                }
            }
        }

        private void txtCien_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtCien.Text;
            if (enc.Equals("Cien"))
            {
                txtCien.Text = "Cien";
                txtCien.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtCien.Text = "Cien";
                    txtCien.ForeColor = Color.Gray;
                }
                else
                {
                    txtCien.Text = enc;
                    txtCien.ForeColor = Color.Black;
                }
            }
        }

        private void txtQuinientos_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtQuinientos.Text;
            if (enc.Equals("Quinientos"))
            {
                txtQuinientos.Text = "Quinientos";
                txtQuinientos.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtQuinientos.Text = "Quinientos";
                    txtQuinientos.ForeColor = Color.Gray;
                }
                else
                {
                    txtQuinientos.Text = enc;
                    txtQuinientos.ForeColor = Color.Black;
                }
            }
        }

        private void txtCincuenta_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtCincuenta.Text;
            if (enc.Equals("Cincuenta"))
            {
                txtCincuenta.Text = "Cincuenta";
                txtCincuenta.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtCincuenta.Text = "Cincuenta";
                    txtCincuenta.ForeColor = Color.Gray;
                }
                else
                {
                    txtCincuenta.Text = enc;
                    txtCincuenta.ForeColor = Color.Black;
                }
            }
        }

        private void txtDoscientos_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtDoscientos.Text;
            if (enc.Equals("Doscientos"))
            {
                txtDoscientos.Text = "Doscientos";
                txtDoscientos.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtDoscientos.Text = "Doscientos";
                    txtDoscientos.ForeColor = Color.Gray;
                }
                else
                {
                    txtDoscientos.Text = enc;
                    txtDoscientos.ForeColor = Color.Black;
                }
            }
        }

        private void txtVeinte_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtVeinte.Text;
            if (enc.Equals("Veinte"))
            {
                txtVeinte.Text = "Veinte";
                txtVeinte.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtVeinte.Text = "Veinte";
                    txtVeinte.ForeColor = Color.Gray;
                }
                else
                {
                    txtVeinte.Text = enc;
                    txtVeinte.ForeColor = Color.Black;
                }
            }
        }

        private void txtdiez_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtdiez.Text;
            if (enc.Equals("Diez"))
            {
                txtdiez.Text = "Diez";
                txtdiez.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtdiez.Text = "Diez";
                    txtdiez.ForeColor = Color.Gray;
                }
                else
                {
                    txtdiez.Text = enc;
                    txtdiez.ForeColor = Color.Black;
                }
            }
        }

        private void txtDos_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtDos.Text;
            if (enc.Equals("Dos"))
            {
                txtDos.Text = "Dos";
                txtDos.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtDos.Text = "Dos";
                    txtDos.ForeColor = Color.Gray;
                }
                else
                {
                    txtDos.Text = enc;
                    txtDos.ForeColor = Color.Black;
                }
            }
        }

        private void txtCinco_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtCinco.Text;
            if (enc.Equals("Cinco"))
            {
                txtCinco.Text = "Cinco";
                txtCinco.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtCinco.Text = "Cinco";
                    txtCinco.ForeColor = Color.Gray;
                }
                else
                {
                    txtCinco.Text = enc;
                    txtCinco.ForeColor = Color.Black;
                }
            }
        }

        private void txtUno_Leave(object sender, EventArgs e)
        {
            string enc = "";
            enc = txtUno.Text;
            if (enc.Equals("Uno"))
            {
                txtUno.Text = "Uno";
                txtUno.ForeColor = Color.Gray;
            }
            else
            {
                if (enc.Equals(""))
                {
                    txtUno.Text = "Uno";
                    txtUno.ForeColor = Color.Gray;
                }
                else
                {
                    txtUno.Text = enc;
                    txtUno.ForeColor = Color.Black;
                }
            }
        }

        private void txtMil_Enter(object sender, EventArgs e)
        {
            txtMil.Text = "";
            txtMil.ForeColor = Color.Black;
        }

        private void txtCien_Enter(object sender, EventArgs e)
        {
            txtCien.Text = "";
            txtCien.ForeColor = Color.Black;
        }

        private void txtQuinientos_Enter(object sender, EventArgs e)
        {

            txtQuinientos.Text = "";
            txtQuinientos.ForeColor = Color.Black;
        }

        private void txtCincuenta_Enter(object sender, EventArgs e)
        {
            txtCincuenta.Text = "";
            txtCincuenta.ForeColor = Color.Black;
        }

        private void txtDoscientos_Enter(object sender, EventArgs e)
        {
            txtDoscientos.Text = "";
            txtDoscientos.ForeColor = Color.Black;
        }

        private void txtVeinte_Enter(object sender, EventArgs e)
        {
            txtVeinte.Text = "";
            txtVeinte.ForeColor = Color.Black;
        }

        private void txtdiez_Enter(object sender, EventArgs e)
        {
            txtdiez.Text = "";
            txtdiez.ForeColor = Color.Black;
        }

        private void txtDos_Enter(object sender, EventArgs e)
        {
            txtDos.Text = "";
            txtDos.ForeColor = Color.Black;
        }

        private void txtCinco_Enter(object sender, EventArgs e)
        {
            txtCinco.Text = "";
            txtCinco.ForeColor = Color.Black;
        }

        private void txtUno_Enter(object sender, EventArgs e)
        {
            txtUno.Text = "";
            txtUno.ForeColor = Color.Black;
        }

        private void txtMil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuinientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCincuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDoscientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVeinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdiez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCinco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged( sender,  e);
        }

        private void txtTotalTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void MostrarTotalCaja(DateTime FECHA)
        {
            int po = dataGridView1.Rows.Count;
            string re = "";
            for(int i = 0; i < po; i++)
            {
                re = dataGridView1.Rows[i].Cells[1].Value.ToString();
                if (re == "VENTA")
                {
                    ven += decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                else
                {
                    com += decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
            }
        }

        private void txtEncargadoCaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFondoInicial_Click(object sender, EventArgs e)
        {

        }
    }
}
