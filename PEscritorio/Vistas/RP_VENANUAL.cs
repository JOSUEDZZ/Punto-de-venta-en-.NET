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
    public partial class RP_VENANUAL : Form
    {
        public RP_VENANUAL()
        {
            InitializeComponent();
        }

        private void RP_VENANUAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.VENTAANUAL' Puede moverla o quitarla según sea necesario.
            //this.vENTAANUALTableAdapter.Fill(this.bDPinturaJuarezDataSet1.VENTAANUAL);

        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.VENTAANUAL' Puede moverla o quitarla según sea necesario.
            this.vENTAANUALTableAdapter.Fill(this.bDPinturaJuarezDataSet1.VENTAANUAL,DTPINCIO.Value,DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
