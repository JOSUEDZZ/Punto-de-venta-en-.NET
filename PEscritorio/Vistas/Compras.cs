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
using System.Windows.Forms.PropertyGridInternal;

namespace PEscritorio
{
    public partial class Compras : Form
    {
        CN_mercanciaP objetoCNPinturas = new CN_mercanciaP();
        CN_Compras objCompras =new CN_Compras();
        CN_mercanciaM objMateriales = new CN_mercanciaM();
        CN_Proveedor objProveedor = new CN_Proveedor();
        private CD_Conexion conexion1 = new CD_Conexion();
        bool ban = true; float Monto=0, camb=0,no=0;
        string Usuario = "";
        public Compras(string usuario)
        {
           InitializeComponent();
            CBBusMer.SelectedIndex = 0;
            txtCantidad.Text = "1";
            txtPrecio.Text = "1";
            txtPreVen.Text = "2";
            lbNoPro.Text = "ABC123456A01";
            PanelCosas.Visible = true;
            Usuario= usuario;
            txtBusMer.Text = " ";
            txtBusMer.Clear();
        }
        private void Compras_Load(object sender, EventArgs e)
        {
            PROCOM();
            MostrarPintura(lbNoPro.Text);
            MostrarMateriales(lbNoPro.Text);
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal Numerodecompra = Convert.ToDecimal(lbNoCompra.Text);
            int numc = Convert.ToInt32(lbNoCompra.Text);
            try
            {
                objCompras.InsertarRegistro(Numerodecompra, DTPCompra.Value, Decimal.Parse(LabTot.Text), lbNoPro.Text, "MALG918920NQ1");
                MessageBox.Show("Se inserto correctamente");
                lbNoCompra.Text = Numerodecompra.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un error, verifique información" + Ex);
            }
            camb = (float.Parse(txtCambio.Text) - float.Parse(LabTot.Text));
            Labcambio.Text = camb.ToString("F2");
            int ciclo = DGVCom.RowCount;
            for (int i = 0; i < ciclo-1; i++)
            {
                decimal codi = decimal.Parse(DGVCom.Rows[i].Cells[0].Value.ToString());
                decimal total = decimal.Parse(DGVCom.Rows[i].Cells[5].Value.ToString());
                decimal cantidad = decimal.Parse(DGVCom.Rows[i].Cells[4].Value.ToString());
                decimal Precio=decimal.Parse(DGVCom.Rows[i].Cells[2].Value.ToString());
                decimal PreVen=decimal.Parse(DGVCom.Rows[i].Cells[3].Value.ToString());
                objCompras.InsertarCIM(Numerodecompra, codi, total/cantidad,Precio,PreVen,cantidad);
            }
            C_COMPRAS PAGO = new C_COMPRAS(lbNoPro.Text, numc);
            Numerodecompra++;
            lbNoCompra.Text = Numerodecompra.ToString();
            Monto = 0;
            txtCambio.Text = "0";
            Limpiar();
            PanelCosas.Visible = true;
            PAGO.Show();
           
        }
        public void Limpiar()
        {
            txtCambio.Clear();
            txtPrecio.Text = "1";
            txtPreVen.Text = "2";
            DGVCom.Rows.Clear();
        }
        private void btnbusmer_Click(object sender, EventArgs e)
        {
            MostrarPintura(lbNoPro.Text);
            MostrarMateriales(lbNoPro.Text);
            PbusMer.Visible = true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PbusMer.Visible = false;
        }
        private void MostrarPintura(string pro)
        {
            DGVBusPin.DataSource = objetoCNPinturas.COMPRO(pro);
        }
        private void MostrarMateriales(string pro)
        {
            DGVBusMer.DataSource = objMateriales.MERPRO(pro);
        }
        private void PROCOM()
        {
            dgvProveedores.DataSource = objProveedor.MostrarProveedor();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCom.SelectedRows.Count > 0)
                {
                    int rowIndex = DGVCom.SelectedRows[0].Index;
                    float cp = float.Parse(DGVCom.Rows[rowIndex].Cells[4].Value.ToString());
                    Monto -= cp;
                    LabTot.Text = Monto.ToString("F2");
                    LabIVA.Text = (Monto - (Monto / 1.16)).ToString("F2");
                    LabSubT.Text = (Monto / 1.16).ToString("F2");
                    DGVCom.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Selecciona una fila para eliminar.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
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

        private void btnbusPro_Click(object sender, EventArgs e)
        {
            panelProveedor.Visible = true;
        }

        private void BtnCanCli_Click(object sender, EventArgs e)
        {
            panelProveedor.Visible=false;
        }

        private void BtnAcepCli_Click(object sender, EventArgs e)
        {
            try
            {
                int ro = Convert.ToInt32(dgvProveedores.SelectedRows[0].Index);
                lbprovee.Text = dgvProveedores.Rows[ro].Cells[1].Value.ToString();
                txtProv.Text= dgvProveedores.Rows[ro].Cells[1].Value.ToString();
                lbNoPro.Text = dgvProveedores.Rows[ro].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No selecciono un articulo");
            }
            panelProveedor.Visible = false;
        }

        private void txtbuscarCli_TextChanged(object sender, EventArgs e)
        {
            dgvProveedores.CurrentCell = null;
            string busquedaProveedores = txtbuscarPro.Text.ToLower();
            if (!string.IsNullOrEmpty(busquedaProveedores.ToLower()))
            {
                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {
                    string RFC = row.Cells["PRORFC"].Value.ToString().ToLower();
                    string NOMBRE = row.Cells["NOMBRE"].Value.ToString().ToLower();
                    string DIRECCION = row.Cells["DIRECCION"].Value.ToString().ToLower();
                    string CORREO = row.Cells["CORREOELECTRONICO"].Value.ToString().ToLower();
                    string CONTACTO = row.Cells["CONTACTO"].Value.ToString().ToLower();
                    string TELEFONO = row.Cells["TELEFONO"].Value.ToString().ToLower();
                    if (RFC.Contains(busquedaProveedores) || NOMBRE.Contains(busquedaProveedores) || DIRECCION.Contains(busquedaProveedores) || CORREO.Contains(busquedaProveedores) || CONTACTO.Contains(busquedaProveedores) || TELEFONO.Contains(busquedaProveedores))
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
                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void txtBusMer_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
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
                string Codigo = txtCod.Text;
                string Marca = txtMarca.Text;
                string Produccto = txtProd.Text;
                string Unidad = txtUnida.Text;
                float precio = float.Parse(txtPrecio.Text);
                float Tot = precio * Can;
                string preven = txtPreVen.Text;
                DGVCom.Rows.Add(Codigo, Marca + "," + Produccto,  precio, preven, Can, Tot);
                Monto += Tot;
            }
            catch
            {
                MessageBox.Show("No hay codigo a agregar");
            }
            LabTot.Text = Monto.ToString();
            LabIVA.Text = (Monto - (Monto / 1.16)).ToString("F2");
            LabSubT.Text = (Monto / 1.16).ToString("F2");
            textBox1.Clear();
            txtCantidad.Text = "1";
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            lbNoCompra.Text = txtNoFctura.Text;
            PanelCosas.Visible = false;
        }

        private void CBBusMer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusMer.Text = " ";
            txtBusMer.Clear();
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPreVen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoFctura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
    }
}
