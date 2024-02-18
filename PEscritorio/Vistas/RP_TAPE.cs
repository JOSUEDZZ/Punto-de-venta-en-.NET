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
    public partial class RP_TAPE : Form
    {
        public RP_TAPE()
        {
            InitializeComponent();
        }

        private void RP_TAPE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MATERIALTAPE' Puede moverla o quitarla según sea necesario.
            this.mATERIALTAPETableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALTAPE,DTPINCIO.Value,DTPFINAL.Value);

            this.reportViewer1.RefreshReport();
        }

        private void BTNGENERAR_Click(object sender, EventArgs e)
        {
            this.mATERIALTAPETableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALTAPE, DTPINCIO.Value, DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
