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
    public partial class FR_MATMASV : Form
    {
        public FR_MATMASV()
        {
            InitializeComponent();
        }

        private void FR_MATMASV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MATERIALESMASVENDIDOS' Puede moverla o quitarla según sea necesario.
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.mATERIALESMASVENDIDOSTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALESMASVENDIDOS, DTPINCIO.Value, DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
