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
    public partial class RP_PINTURAMASV : Form
    {
        public RP_PINTURAMASV()
        {
            InitializeComponent();
        }

        private void RP_PINTURAMASV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.PINTURAMASV' Puede moverla o quitarla según sea necesario.
            this.pINTURAMASVTableAdapter.Fill(this.bDPinturaJuarezDataSet1.PINTURAMASV,DTPINCIO.Value,DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }

        private void BTNGENERAR_Click(object sender, EventArgs e)
        {
            this.pINTURAMASVTableAdapter.Fill(this.bDPinturaJuarezDataSet1.PINTURAMASV, DTPINCIO.Value, DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
