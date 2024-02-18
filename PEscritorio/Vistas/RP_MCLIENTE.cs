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
    public partial class RP_MCLIENTE : Form
    {
        public RP_MCLIENTE()
        {
            InitializeComponent();
        }

        private void RP_MCLIENTE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MEJORCLIEN' Puede moverla o quitarla según sea necesario.
            this.mEJORCLIENTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MEJORCLIEN,DTPINCIO.Value,DTPFINAL.Value);

            this.reportViewer1.RefreshReport();
        }

        private void BTNGENERAR_Click(object sender, EventArgs e)
        {
            this.mEJORCLIENTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MEJORCLIEN, DTPINCIO.Value, DTPFINAL.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
