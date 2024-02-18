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
using System.Windows.Forms.DataVisualization.Charting;

namespace PEscritorio
{
    public partial class ReprtesVentas : Form
    {
        byte ve = 0, ma = 0, pi = 0, cl = 0;
        public ReprtesVentas()
        {
            InitializeComponent();
            PVen.Visible = false;
            PMat.Visible = false;
            PPint.Visible = false;
            PCli.Visible = false;
            pnlPROVE.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ReporteSemanal()
        {
           
        }
        //REPORTE SEMANAL
        public void ReportePorAño()
        {
            
        }

        //REPORTE DE VENTAS-MATERIALES
        public void ReporteVentasMateriales()
        {
            //DATOS A MOSTRAR
           
        }

        //REPORTE DE VENTAS POR PINTURAS
        public void ReporteVentasPinturas()
        {
            //DATOS A MOSTRAR
            
        }
        //REPORTE DE VENTAS POR PINTURAS
        public void ReporteVentasPinturasMarca()
        {
            
        }

        //REPORTE DE VENTAS POR CLIENTE EL MEJOR
        public void ReporteVentasPinturasClienteElMejor()
        {
           
        }

        //REPORTE DE VENTAS TIPO DE PINTURA
        public void ReporteVentasTipoPintura()
        {
            
        }
        public void Desaparacer()
        {
            PVen.Visible = false;
            PMat.Visible = false;
            PPint.Visible = false;
            PCli.Visible = false;
            pnlPROVE.Visible = false;
            ve = 0;ma = 0;pi = 0;cl = 0;
            
        }

        private void BtnVDi_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_VENTASDIARIAS());
        }

        private void BtnVSe_Click_1(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new PRUEBA20());
        }

        private void BtnVAn_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_VENANUAL());
        }

        private void BtnMMas_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new FR_MATMASV());
        }

        private void BtnMThi_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_THINER());
        }
        public void ReporteThiner()
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_TAPE());
        }
        public void ReporteTape()
        {
            //DATOS A MOSTRAR
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_LIJAMASVEN());
        }
        public void ReporteLija()
        {
           
        }

        private void BtnPMas_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_PINTURAMASV());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (ve == 0)
            {
                Desaparacer();
                PVen.Visible = true;
                ve = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            if (ma == 0)
            {
                Desaparacer();
                PMat.Visible = true;
                ma = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            if (pi == 0)
            {
                Desaparacer();
                PPint.Visible = true;
                pi = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            if (cl == 0)
            {
                Desaparacer();
                PCli.Visible = true;
                cl = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void BtnVMe_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_MENSUALV());
        }

        private void ReprtesVentas_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
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
            panel5.Controls.Add(child);
            panel5.Tag = child;
            child.BringToFront();
            child.Show();

        }

        private void btnPROV_Click(object sender, EventArgs e)
        {
            if (pi == 0)
            {
                Desaparacer();
                pnlPROVE.Visible = true;
                pi = 1;
            }
            else
            {
                Desaparacer();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_MERCPROVM());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_PROVMASCOMPRADO());
        }

        private void BtnPMar_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_PINMARCA());
        }

        private void BtnPTipo_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_TIPOPMV());
        }

        private void BtnCMej_Click(object sender, EventArgs e)
        {
            Desaparacer();
            opening(new RP_MCLIENTE());
        }
    }
}
