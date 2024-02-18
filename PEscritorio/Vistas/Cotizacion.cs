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
    public partial class Cotizacion : Form
    {
        CN_mercanciaP objetoCNPinturas = new CN_mercanciaP();
        CD_Cotizacion newCOT = new CD_Cotizacion();
        private CN_Ventas objetoVentas = new CN_Ventas();
        CN_mercanciaM objMateriales = new CN_mercanciaM();
        CN_Clientes objetoClientes = new CN_Clientes();
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
        float Monto = 0; bool ban = true; float camb = 0;
        string Usu; // esto jala el nombre del Usuario
        public Cotizacion(string usuario)
        {
            Usu = usuario;
            InitializeComponent();
            CBBusMer.SelectedIndex = 0;
            txtCantidad.Text = "1";
            lbNoventa.Text = "0";
            lBCLIENTE.Text = "0";
            //para la ultima venta realizada
            conexion1.AbrirConexion();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "select max(COTIZACION.COTCOD)+1 as NUMP from COTIZACION ";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                LBnoVnta.Text = leer["NUMP"].ToString();
            }
            conexion1.CerrarConexion();
            //ultima cotizacion
            conexion1.AbrirConexion();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "select max(COTIZACION.COTCOD) as NUMF from COTIZACION";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                lbcot.Text = leer["NUMF"].ToString();
            }
            conexion1.CerrarConexion();
            //Prueba
            txtBusMer.Text = " ";
            txtBusMer.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion1.AbrirConexion();
                comando.Connection = conexion1.AbrirConexion();
                if (ban == true)
                {
                    SqlCommand comandoMateriales = new SqlCommand();
                    comandoMateriales.Connection = conexion1.AbrirConexion();
                    comandoMateriales.CommandText = " SELECT  MT.CODIGO, M.MARCA, MT.Producto, MT.Unidad, M.PRECIO, M.CANTIDAD, M.FKPRORFC FROM MERCANCIA M INNER JOIN MATERIALES MT ON  M.CODIGO = MT.CODIGO  WHERE MT.CODIGO = " + textBox1.Text + "";
                    SqlDataReader leerMateriales = comandoMateriales.ExecuteReader();
                    if (leerMateriales.Read())
                    {
                        txtCod.Text = leerMateriales["CODIGO"].ToString();
                        txtMarca.Text = leerMateriales["MARCA"].ToString();
                        txtProd.Text = leerMateriales["Producto"].ToString();
                        txtUnida.Text = leerMateriales["Unidad"].ToString();
                        txtPrec.Text = leerMateriales["PRECIO"].ToString();
                    }
                    conexion1.CerrarConexion();
                }
                else if (ban == false)
                {

                    SqlCommand Gertrudiz = new SqlCommand();
                    Gertrudiz.Connection = conexion1.AbrirConexion();
                    Gertrudiz.CommandText = "SELECT M.CODIGO, M.MARCA, M.PRECIO, M.CANTIDAD, M.FKPRORFC,P.CODIGO, P.COLOR, P.TIPO, P.UNIDADDEMEDIDA FROM MERCANCIA As M INNER JOIN PINTURA As P ON M.CODIGO = P.CODIGO WHERE M.CODIGO = " + textBox1.Text + "";
                    SqlDataReader leerPintura = Gertrudiz.ExecuteReader();

                    if (leerPintura.Read())
                    {
                        txtCod.Text = leerPintura["CODIGO"].ToString();
                        txtMarca.Text = leerPintura["MARCA"].ToString();
                        txtProd.Text = leerPintura["COLOR"].ToString();
                        txtPrec.Text = leerPintura["PRECIO"].ToString();
                        txtUnida.Text = leerPintura["UNIDADDEMEDIDA"].ToString();
                    }
                    conexion1.CerrarConexion();
                }
                int Can = int.Parse(txtCantidad.Text);
                float pre = float.Parse(txtPrec.Text);
                float Tot = pre * Can;
                string Codigo = txtCod.Text;
                string Marca = txtMarca.Text;
                string Produccto = txtProd.Text;
                string Unidad = txtUnida.Text;
                DGVCotizacion.Rows.Add(Codigo, Marca + "," + Produccto, pre, Can, Tot);
                Monto += Tot;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, verifique información" + ex);
            }
            LabTot.Text = Monto.ToString();
            LabIVA.Text = (Monto - (Monto / 1.16)).ToString("F2");
            LabSubT.Text = (Monto / 1.16).ToString("F2");
            textBox1.Clear();
            txtCantidad.Text = "1";
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            decimal NumCOt = Convert.ToDecimal(lbcot.Text.ToString());
            int NUMECOT = int.Parse(lbcot.Text.ToString());
            NumCOt++;
            NUMECOT++;
            if (lBCLIENTE.Text != "")
            {
                try
                {
                    if (DGVCotizacion.Rows.Count != 0 && LabTot.Text != "$0.00")
                    {
                        //metodo que recorre los datos 
                        for (int i = 0; i < DGVCotizacion.Rows.Count - 1; i++)
                        {

                            for (int c = 0; c < DGVCotizacion.ColumnCount; c++)
                            {

                                string DATOCODIGO = DGVCotizacion[c, i].Value.ToString();
                                //MessageBox.Show(DATOCODIGO.ToString());
                                if (c == 0)
                                {
                                    txtCod.Text = DATOCODIGO;
                                }
                                if (c == 2)
                                {
                                    txtPrec.Text = DATOCODIGO;
                                }
                                if (c == 3)
                                {
                                    txtCantidad.Text = DATOCODIGO;
                                }
                                if (c == 4)
                                {
                                    txtPrec.Text = DATOCODIGO;
                                }


                            }
                            int Can = int.Parse(txtCantidad.Text);
                            decimal pre = Convert.ToDecimal(txtPrec.Text);
                            decimal Tot = pre * Can;
                            decimal Codigo = Convert.ToDecimal(txtCod.Text);
                            string Marca = txtMarca.Text;
                            string Produccto = txtProd.Text;
                            string Unidad = txtUnida.Text;
                            string RFCU = lbRFCU.Text;
                            newCOT.InsertarCOT(NumCOt, DTPVentas.Value, Tot, Can, RFCU, Codigo, lBCLIENTE.Text);
                        }
                        COTIZACION repcot = new COTIZACION(NUMECOT);
                        lbcot.Text = NumCOt.ToString();
                        lbNoventa.Text= NumCOt.ToString();
                        repcot.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona minimo un articulo");
                    }

                }
                catch
                {
                    MessageBox.Show("Hubo un error, verifique información");
                }
            }
            else
            {
                MessageBox.Show("SELECCIONA UN CLIENTE O CAMBIA DE CLIENTE");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PbusMer.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelClientes.Visible = true;
        }

        private void BtnAgegarCliente_Click(object sender, EventArgs e)
        {
            opening(new RClientes());
        }
        private Form active = null;
        private void opening(Form child)
        {
            if (active != null)
                active.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel11.Controls.Add(child);
            panel11.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (CBBusMer.SelectedIndex == 0)
            {
                try
                {
                    int ro = Convert.ToInt32(DGVBusMer.SelectedRows[0].Index);
                    textBox1.Text = DGVBusMer.Rows[ro].Cells[0].Value.ToString();
                    ban = true;
                }
                catch
                {
                    MessageBox.Show("No selecciono un articulo");
                }
            }
            else
            {
                try
                {
                    int ru = Convert.ToInt32(DGVBusPin.SelectedRows[0].Index);
                    textBox1.Text = DGVBusPin.Rows[ru].Cells[0].Value.ToString();
                    ban = false;
                }
                catch
                {
                    MessageBox.Show("No selecciono un articulo");
                }
            }
            PbusMer.Visible = false;
        }

        private void CBBusMer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusMer.Text = " ";
            txtBusMer.Clear();
        }

        private void txtBusMer_TextChanged(object sender, EventArgs e)
        {
            if (CBBusMer.SelectedIndex == 0)
            {
                DGVBusMer.Visible = true;
                DGVBusPin.Visible = false;
                busquedaMater_TextChanged(sender, e);
            }
            else
            {
                DGVBusMer.Visible = false;
                DGVBusPin.Visible = true;
                busquedaPintu_TextChanged(sender, e);
            }
        }
        private void busquedaMater_TextChanged(object sender, EventArgs e)
        {
            DGVBusMer.CurrentCell = null;
            string searchText = txtBusMer.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in DGVBusMer.Rows)
                {
                    string Codig = row.Cells["CODIGO"].Value.ToString().ToLower();
                    string mark = row.Cells["MARCA"].Value.ToString().ToLower();
                    string product = row.Cells["Producto"].Value.ToString().ToLower();
                    string unity = row.Cells["Unidad"].Value.ToString().ToLower();
                    string price = row.Cells["PRECIO"].Value.ToString().ToLower();
                    if (Codig.Contains(searchText) || mark.Contains(searchText) || product.Contains(searchText) || unity.Contains(searchText) || price.Contains(searchText))
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
                foreach (DataGridViewRow row in DGVBusMer.Rows)
                {
                    row.Visible = true;
                }
            }
        }
        private void busquedaPintu_TextChanged(object sender, EventArgs e)
        {
            DGVBusPin.CurrentCell = null;
            string searchText = txtBusMer.Text;
            if (!string.IsNullOrEmpty(searchText.ToLower()))
            {
                foreach (DataGridViewRow row in DGVBusPin.Rows)
                {
                    string Codig = row.Cells["CODIGO"].Value.ToString().ToLower();
                    string mark = row.Cells["MARCA"].Value.ToString().ToLower();
                    string price = row.Cells["PRECIO"].Value.ToString().ToLower();
                    string tipe = row.Cells["TIPO"].Value.ToString();
                    string color = row.Cells["COLOR"].Value.ToString();
                    string unidmed = row.Cells["UNIDADDEMEDIDA"].Value.ToString();
                    if (Codig.Contains(searchText) || mark.Contains(searchText) || price.Contains(searchText) || tipe.Contains(searchText) || color.Contains(searchText))
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
                foreach (DataGridViewRow row in DGVBusPin.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PbusMer.Visible = false;
        }

        private void BtnAcepCli_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvClientes.SelectedRows[0].Index);
                LabCliente.Text = dgvClientes.Rows[ro].Cells[1].Value.ToString();
                lbNoventa.Text = dgvClientes.Rows[ro].Cells[0].Value.ToString();
                lBCLIENTE.Text = dgvClientes.Rows[ro].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            panelClientes.Visible = false;
        }

        private void BtnCanCli_Click(object sender, EventArgs e)
        {
            panelClientes.Visible = false;
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            BuscarCajaRFC(Usu);
            MostrarClientes();
            MostrarPintura();
            MostrarMateriales();
        }
        public void BuscarCajaRFC(string NOMBRE)
        {
            try
            {
                conexion1.AbrirConexion();
                SqlCommand comando9 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
                comando9.Connection = conexion1.AbrirConexion();
                comando9.CommandText = "MostrarUsuarioCaja";
                comando9.CommandType = CommandType.StoredProcedure;
                comando9.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                SqlDataReader leer9; //LEER FILAS DE LA TABLA
                leer9 = comando9.ExecuteReader();


                if (leer9.Read())
                {
                    lbRFCU.Text = leer9["URFC"].ToString();

                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: " + ex);
            }
        }

        private void MostrarPintura()
        {
            DGVBusPin.DataSource = objetoCNPinturas.MostrarPintura();
        }
        private void MostrarMateriales()
        {
            DGVBusMer.DataSource = objMateriales.MostrarMercanciaM();
        }
        private void MostrarClientes()
        {
            dgvClientes.DataSource = objetoClientes.MostrarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVCotizacion.SelectedRows.Count > 0)
            {
                int rowIndex = DGVCotizacion.SelectedRows[0].Index;
                float cp = float.Parse(DGVCotizacion.Rows[rowIndex].Cells[4].Value.ToString());
                Monto -= cp;
                LabTot.Text = Monto.ToString("F2");
                LabIVA.Text = (Monto - (Monto / 1.16)).ToString("F2");
                LabSubT.Text = (Monto / 1.16).ToString("F2");
                DGVCotizacion.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
