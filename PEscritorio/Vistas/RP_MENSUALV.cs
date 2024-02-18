using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio.Vistas
{
    public partial class RP_MENSUALV : Form
    {
        public RP_MENSUALV()
        {
            InitializeComponent();
        }

        private void RP_MENSUALV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.R_VENTAS_MES' Puede moverla o quitarla según sea necesario.
            //this.r_VENTAS_MESTableAdapter.Fill(this.bDPinturaJuarezDataSet1.R_VENTAS_MES);
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.R_VENTAS_DIA1' Puede moverla o quitarla según sea necesario.
            //this.r_VENTAS_DIA1TableAdapter.Fill(this.bDPinturaJuarezDataSet1.R_VENTAS_DIA1);

            //this.reportViewer1.RefreshReport();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.r_VENTAS_MESTableAdapter.Fill(this.bDPinturaJuarezDataSet1.R_VENTAS_MES,DTPINCIO.Value,DTPFINAL.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
