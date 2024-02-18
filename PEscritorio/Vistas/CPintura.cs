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
    public partial class CPintura : Form
    {
        CN_mercanciaP objetoCNPinturas = new CN_mercanciaP();
        private CD_Conexion conexion1 = new CD_Conexion();

        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados

        public CPintura()
        {
            InitializeComponent();
        }
     
        private void CPintura_Load(object sender, EventArgs e)
        {
            MostrarPintura();
        }

        private void MostrarPintura()
        {
            dgvPinturas.DataSource = objetoCNPinturas.MostrarPintura();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvPinturas.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvPinturas.Rows)
                {
                    string codigo = row.Cells["CODIGO"].Value.ToString().ToLower();
                    string marca = row.Cells["MARCA"].Value.ToString().ToLower();
                    string tipo = row.Cells["TIPO"].Value.ToString().ToLower();
                    string color = row.Cells["COLOR"].Value.ToString().ToLower();
                    string unidadmedida = row.Cells["UNIDADDEMEDIDA"].Value.ToString().ToLower();
                    string precio = row.Cells["PRECIO"].Value.ToString().ToLower();


                    if (codigo.Contains(searchText) || marca.Contains(searchText) || tipo.Contains(searchText) || color.Contains(searchText) || unidadmedida.Contains(searchText) || precio.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvPinturas.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
