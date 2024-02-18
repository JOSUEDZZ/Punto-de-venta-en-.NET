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

namespace PEscritorio.Vistas
{
    public partial class Balance : Form
    {
        private CN_Balance objBalance = new CN_Balance();
        private CD_Conexion conexion1 = new CD_Conexion();
        float no = 0;
        string fe = "";
        decimal act = 0, pas = 0;
        public Balance()
        {
            InitializeComponent();
            //para la ultima compra realizada
            SqlCommand comandoCom = new SqlCommand();
            conexion1.AbrirConexion();
            comandoCom.Connection = conexion1.AbrirConexion();
            comandoCom.CommandText = "select max(NOBALANCE) as NUMP, MAX(FECHA) as FECHA from BALANCE";
            SqlDataReader leerCom = comandoCom.ExecuteReader();
            if (leerCom.Read())
            {
                no = float.Parse(leerCom["NUMP"].ToString());
                fe = (leerCom["FECHA"].ToString());
            }
            lbNoBal.Text = (no + 1).ToString();
            MostrarCuentas();
            int tam= DGVBal.RowCount;
            for(int i = 0; i < tam-1; i++)
            {
                string acc = DGVBal.Rows[i].Cells[1].Value.ToString();
                if (acc== "VENTA")
                {
                    pas += decimal.Parse(DGVBal.Rows[i].Cells[3].Value.ToString());
                }
                else
                {
                    act += decimal.Parse(DGVBal.Rows[i].Cells[3].Value.ToString());
                }
            }
            txtActi.Text = act.ToString();
            txtPas.Text = pas.ToString();
        }
        public void MostrarCuentas()
        {
            DGVBal.DataSource = objBalance.MostrarCUENTAS(DateTime.Parse(fe));
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            objBalance.InsertarBalance(Decimal.Parse(lbNoBal.Text),DTPBal.Value, act, pas);
            int tam = DGVBal.RowCount;
            for (int i = 0; i < tam - 1; i++)
            {
                string acc = DGVBal.Rows[i].Cells[1].Value.ToString();
                if (acc == "VENTA")
                {
                    decimal ven = decimal.Parse(DGVBal.Rows[i].Cells[2].Value.ToString());
                    objBalance.InsertarBAV(Decimal.Parse(lbNoBal.Text), ven, DTPBal.Value);
                }
                else
                {
                    decimal com = decimal.Parse(DGVBal.Rows[i].Cells[2].Value.ToString());
                    objBalance.InsertarBAC(Decimal.Parse(lbNoBal.Text), com, DTPBal.Value);
                }
            }
        }
    }
}
