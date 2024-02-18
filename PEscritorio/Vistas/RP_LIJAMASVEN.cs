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
    public partial class RP_LIJAMASVEN : Form
    {
        public RP_LIJAMASVEN()
        {
            InitializeComponent();
        }

        private void RP_LIJAMASVEN_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MATERIALIJA' Puede moverla o quitarla según sea necesario.
            //this.mATERIALIJATableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALIJA);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.mATERIALIJATableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALIJA,DTPINCIO.Value,DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
