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
    public partial class CMateriales : Form
    {
        CN_mercanciaM objMateriales = new CN_mercanciaM();
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
        public CMateriales()
        {
            InitializeComponent();
        }

        private void CMateriales_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            textBox2.Visible = false;
            textBox3.Visible = false;

        }
        private void MostrarMateriales()
        {
            dgvMateriales.DataSource = objMateriales.MostrarMercanciaM();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            dgvMateriales.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvMateriales.Rows)
                {
                    string codigo = row.Cells["CODIGO"].Value.ToString().ToLower();
                    string marca = row.Cells["MARCA"].Value.ToString().ToLower();
                    string producto = row.Cells["Producto"].Value.ToString().ToLower();
                    string unidad = row.Cells["Unidad"].Value.ToString().ToLower();
                    string precio = row.Cells["PRECIO"].Value.ToString().ToLower();

                    if (codigo.Contains(searchText) || marca.Contains(searchText) || producto.Contains(searchText) || unidad.Contains(searchText) || precio.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvMateriales.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            txtBuscar_TextChanged_1(sender, e);
        }
    }
}
