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
    public partial class Ventas : Form
    {
        CN_mercanciaP objetoCNPinturas = new CN_mercanciaP();
        CD_FACTURA newFactura = new CD_FACTURA();
        CD_Cotizacion newCOT = new CD_Cotizacion();
        private CN_Ventas objetoVentas = new CN_Ventas();
        CN_mercanciaM objMateriales = new CN_mercanciaM();
        CN_Clientes objetoClientes = new CN_Clientes();
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer; //LEER FILAS DE LA TABLA
        DataTable tabla = new DataTable(); //Para almacenar las filas de la consulta
        SqlCommand comando = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
        float Monto = 0;bool ban = true; float camb = 0;
        string Usu; // esto jala el nombre del Usuario
        public Ventas(string usuario)
        {
            Usu= usuario;
            InitializeComponent();
            DTPVentas.Value=DateTime.Now;
            CBBusMer.SelectedIndex = 0;
            txtCantidad.Text = "1";
            lbNoventa.Text = "0";
            //para la ultima venta realizada
            conexion1.AbrirConexion();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "select max(NOVENTA) as NUMP from VENTAS ";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                LBnoVnta.Text = leer["NUMP"].ToString();
            }
            conexion1.CerrarConexion();
            //para la ultima factura
            conexion1.AbrirConexion();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "select max(NOFACTURA) as NUMF from FACTURA";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                lbFactura.Text = leer["NUMF"].ToString();
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

        private void BtnAgegarCliente_Click(object sender, EventArgs e)
        {
            opening(new RClientes());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            opening (new Factura ());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal Numerodeventa = Convert.ToDecimal(LBnoVnta.Text);
            decimal NumeroFAC = Convert.ToDecimal(lbFactura.Text);
            Numerodeventa++;
            NumeroFAC++; 
            try
            {
                decimal va = decimal.Parse(txtCambio.Text);
                decimal lida=decimal.Parse(LabTot.Text);
                if (lida < va)
                {
                    if (txtCambio.Text != "" && LabTot.Text != "$0.00")
                    {
                        objetoVentas.InsertarRegistro(Numerodeventa, DTPVentas.Value, Decimal.Parse(LabTot.Text), lbRFCU.Text, lbNoventa.Text);
                        //MessageBox.Show("Se inserto correctamente");
                        //metodo que recorre los datos 
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            for (int c = 0; c < dataGridView1.ColumnCount; c++)
                            {

                                string DATOCODIGO = dataGridView1[c, i].Value.ToString();
                                if (c == 0)
                                {
                                    txtCod.Text = DATOCODIGO;
                                }
                                if (c == 2)
                                {
                                    lbPRESUNI.Text = DATOCODIGO;
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
                            decimal pre = Convert.ToDecimal(lbPRESUNI.Text);
                            decimal Tot = pre * Can;
                            decimal Codigo = Convert.ToDecimal(txtCod.Text);
                            string Marca = txtMarca.Text;
                            string Produccto = txtProd.Text;
                            string Unidad = txtUnida.Text;
                            newFactura.ventasretiran(Numerodeventa, Codigo, pre, Can, Tot);
                        }
                        camb = (float.Parse(txtCambio.Text) - float.Parse(LabTot.Text));
                        Labcambio.Text = camb.ToString("F2");
                        objetoVentas.InsertarPago(Numerodeventa, decimal.Parse(txtCambio.Text), decimal.Parse(Labcambio.Text));
                        newFactura.FacturaVenta(NumeroFAC, Numerodeventa);
                        LBnoVnta.Text = Numerodeventa.ToString();
                        //esto es lo que iba hasta abajo
                        ticketbueno reporteTicket = new ticketbueno(Numerodeventa);
                        Numerodeventa++;
                        NumeroFAC++;
                        reporteTicket.ShowDialog();
                        dataGridView1.Rows.Clear();
                        Monto = 0;
                        txtCambio.Text = "";
                        lbFactura.Text = NumeroFAC.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona minimo un articulo");
                    }
                }
                else
                {
                    MessageBox.Show("Faltan : $" + (lida-va) + " Pesos");
                    txtCambio.Focus();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error, verifique información");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelClientes.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PbusMer.Visible = true;
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
        private void MostrarCot()
        {
            DGVBusCot.DataSource = objetoVentas.MostrarCot();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PbusMer.Visible = false;
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            BuscarCajaRFC(Usu);
            MostrarClientes();
            MostrarPintura();
            MostrarMateriales();
            MostrarCot();
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
                dataGridView1.Rows.Add(Codigo, Marca + "," + Produccto, pre, Can , Tot);
                Monto += Tot;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, verifique información"+ex);
            }
            LabTot.Text = Monto.ToString();
            LabIVA.Text = (Monto - (Monto / 1.16)).ToString("F2");
            LabSubT.Text = (Monto / 1.16).ToString("F2");
            textBox1.Clear();
            txtCantidad.Text = "1"; 
        }

        private void PbusMer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                float cp= float.Parse(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
                Monto -= cp;
                LabTot.Text = Monto.ToString("F2");
                LabIVA.Text = (Monto - (Monto / 1.16)).ToString("F2");
                LabSubT.Text = (Monto / 1.16).ToString("F2");
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
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

        private void txtBusMer_KeyUp(object sender, KeyEventArgs e)
        {
                     
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

        private void BtnCanCli_Click(object sender, EventArgs e)
        {
            panelClientes.Visible = false;
        }

        private void BtnAcepCli_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvClientes.SelectedRows[0].Index);
                LabCliente.Text = dgvClientes.Rows[ro].Cells[1].Value.ToString();
                lbNoventa.Text= dgvClientes.Rows[ro].Cells[0].Value.ToString();
                lBCLIENTE.Text = dgvClientes.Rows[ro].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            panelClientes.Visible=false;
        }

        private void txtbuscarCli_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.CurrentCell = null;
            string busquedaClientes = txtbuscarCli.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaClientes.ToLower()))
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    string RFC = row.Cells["CLIRFC"].Value.ToString().ToLower();
                    string NOMBRE = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string DIRECCION = row.Cells["DIRECCION"].Value.ToString().ToLower();
                    string CORREO = row.Cells["CORREOELECTRONICO"].Value.ToString().ToLower();
                    string CODIGOPOSTAL = row.Cells["CODIGOPOSTAL"].Value.ToString().ToLower();
                    string TELEFONO = row.Cells["TELEFONO"].Value.ToString().ToLower();
                    if (RFC.Contains(busquedaClientes) || NOMBRE.Contains(busquedaClientes) || DIRECCION.Contains(busquedaClientes) || CORREO.Contains(busquedaClientes) || CODIGOPOSTAL.Contains(busquedaClientes) || TELEFONO.Contains(busquedaClientes))
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
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    row.Visible = true;
                }
            }
        }
        //BUSCA EL RFC DEL USUARIO
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
                MessageBox.Show("Hubo un error por: ");
            }
        }
        //BUSCAR RFC DEL CLIENTE
        public void BuscarRFCLien(string nombre)
        {
            try
            {
                conexion1.AbrirConexion();
                SqlCommand comando9 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
                comando9.Connection = conexion1.AbrirConexion();
                comando9.CommandText = "RFCLIENTE";
                comando9.CommandType = CommandType.StoredProcedure;
                comando9.Parameters.AddWithValue("@NOMBRE", nombre);
                SqlDataReader leer9; //LEER FILAS DE LA TABLA
                leer9 = comando9.ExecuteReader();


                if (leer9.Read())
                {
                   lBCLIENTE.Text = leer9["CLIRFC"].ToString();

                }
                conexion1.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error por: ");
            }
        }

        private void CBBusMer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusMer.Text = " ";
            txtBusMer.Clear();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            PanCot.Visible= true;  
        }

        private void btnBuscarRFC_Click(object sender, EventArgs e)
        {
            PanelBusCom.Visible= true;
            PanCot.Visible = false;
        }

        private void txtBusCOt_TextChanged(object sender, EventArgs e)
        {
            DGVBusCot.CurrentCell = null;
            string busquedaClientes = txtBusCOt.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaClientes.ToLower()))
            {
                foreach (DataGridViewRow row in DGVBusCot.Rows)
                {
                    string RFC = row.Cells["COTCOD"].Value.ToString().ToLower();
                    string NOMBRE = row.Cells["FECHA"].Value.ToString().ToLower();
                    string DIRECCION = row.Cells["TOTAL"].Value.ToString().ToLower();
                    string CORREO = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    if (RFC.Contains(busquedaClientes) || NOMBRE.Contains(busquedaClientes) || DIRECCION.Contains(busquedaClientes) || CORREO.Contains(busquedaClientes))
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
                foreach (DataGridViewRow row in DGVBusCot.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PanelBusCom.Visible = false;
            PanCot.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(DGVBusCot.SelectedRows[0].Index);
                txtNoCOT.Text = DGVBusCot.Rows[ro].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono una cotizacion");
            }
            PanelBusCom.Visible = false;
            PanCot.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cuen = decimal.Parse(txtNoCOT.Text);
            dataGridView2.DataSource= objetoVentas.MostrarCUENTAS(cuen);
            dataGridView2.Visible = true;
            int op = dataGridView2.Rows.Count;
            decimal tatal = 0;
            for(int i = 0; i < op-1; i++)
            {
                tatal+= decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }
            LabIVA.Text = (tatal- (tatal / Convert.ToDecimal(1.16))).ToString("F2");
            LabSubT.Text = (tatal/Convert.ToDecimal(1.16)).ToString("F2");
            LabTot.Text = tatal.ToString("F2");
            PanCot.Visible = false;
            btnCoCotizar.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanCot.Visible=false;
        }

        private void btnCoCotizar_Click(object sender, EventArgs e)
        {
            decimal Numerodeventa = Convert.ToDecimal(LBnoVnta.Text);
            decimal NumeroFAC = Convert.ToDecimal(lbFactura.Text);
            Numerodeventa++;
            NumeroFAC++;
            try
            {
                decimal va = decimal.Parse(txtCambio.Text);
                decimal lida = decimal.Parse(LabTot.Text);
                if (lida < va)
                {
                    if (txtCambio.Text != "" && LabTot.Text != "$0.00")
                    {
                        objetoVentas.InsertarRegistro(Numerodeventa, DTPVentas.Value, Decimal.Parse(LabTot.Text), lbRFCU.Text, lbNoventa.Text);

                        //metodo que recorre los datos 
                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        {

                            for (int c = 0; c < dataGridView2.ColumnCount; c++)
                            {

                                string DATOCODIGO = dataGridView2[c, i].Value.ToString();
                                //MessageBox.Show(DATOCODIGO.ToString());
                                if (c == 0)
                                {
                                    txtCod.Text = DATOCODIGO;
                                }
                                if (c == 2)
                                {
                                    lbPRESUNI.Text = DATOCODIGO;
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
                            decimal pre = Convert.ToDecimal(lbPRESUNI.Text);
                            decimal Tot = pre * Can;
                            decimal Codigo = Convert.ToDecimal(txtCod.Text);
                            string Marca = txtMarca.Text;
                            string Produccto = txtProd.Text;
                            string Unidad = txtUnida.Text;
                            //MessageBox.Show("los datos a añadir son" + Codigo + pre + Can + Tot);
                            newFactura.ventasretiran(Numerodeventa, Codigo, pre, Can, Tot);

                        }
                        camb = (float.Parse(txtCambio.Text) - float.Parse(LabTot.Text));
                        Labcambio.Text = camb.ToString("F2");
                        newFactura.FacturaVenta(NumeroFAC, Numerodeventa);
                        objetoVentas.InsertarPago(Numerodeventa, decimal.Parse(txtCambio.Text), decimal.Parse(Labcambio.Text));
                        //MessageBox.Show("Ya se relaciono con una factura");
                        LBnoVnta.Text = Numerodeventa.ToString();
                        //esto es lo que iba hasta abajo

                        ticketbueno reporteTicket = new ticketbueno(Numerodeventa);
                        Numerodeventa++;
                        NumeroFAC++;
                        reporteTicket.ShowDialog();
                        Monto = 0;
                        txtCambio.Text = "";
                        lbFactura.Text = NumeroFAC.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Selecciona minimo un articulo");
                    }
                    btnCoCotizar.Visible = false;
                    dataGridView2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Faltan : $" + (lida-va) + " Pesos");
                    txtCambio.Focus();
                }
                    
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error, verifique información");
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

        private void txtCambio_KeyPress(object sender, KeyPressEventArgs e)
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
