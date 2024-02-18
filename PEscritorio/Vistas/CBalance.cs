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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class CBalance : Form
    {
        CN_Balance objBalance = new CN_Balance();
        CD_Conexion conexion1 = new CD_Conexion();
        public CBalance()
        {
            InitializeComponent();
            MostrarBalan();
        }
        public void MostrarBalan()
        {
            dgvBalance.DataSource = objBalance.MostrarBalance();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvBalance.CurrentCell = null;
            string searchText = txtBuscar.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in dgvBalance.Rows)
                {
                    string NOBALANCE = row.Cells["NOBALANCE"].Value.ToString().ToLower();
                    string FECHA = row.Cells["FECHA"].Value.ToString().ToLower();
                    string TOTALACTIVO = row.Cells["TOTALACTIVO"].Value.ToString().ToLower();
                    string TOTALPASICVO = row.Cells["TOTALPASICVO"].Value.ToString().ToLower();
                    if (NOBALANCE.Contains(searchText) || FECHA.Contains(searchText) || TOTALACTIVO.Contains(searchText) || TOTALPASICVO.Contains(searchText))
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
                foreach (DataGridViewRow row in dgvBalance.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
