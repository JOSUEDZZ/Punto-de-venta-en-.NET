using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class FormSaldoInicial : Form
    {
        string Usuario;
        string Tipo;
        public FormSaldoInicial(string usuario, string tipo)
        {
            InitializeComponent();
            Usuario = usuario;
            Tipo = tipo;
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            try
            {
                double saldo = Convert.ToDouble(textBox1.Text);
                if (saldo < 0)
                {
                    MessageBox.Show("Ingrese un valor");
                }
                else
                {
                    double inicial = Convert.ToDouble(textBox1.Text);
                    Form1 Menuprincipal = new Form1(Usuario, Tipo, inicial);
                    Corte cort = new Corte(Usuario, inicial);
                    Menuprincipal.ShowDialog();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }
    }
}
