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
    public partial class RP_VENTASDIARIAS : Form
    {
        public RP_VENTASDIARIAS()
        {
            InitializeComponent();
        }

        private void RP_VENTASDIARIAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.VENTASDIA' Puede moverla o quitarla según sea necesario.
            this.vENTASDIATableAdapter.Fill(this.bDPinturaJuarezDataSet1.VENTASDIA,DTPINCIO.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.vENTASDIATableAdapter.Fill(this.bDPinturaJuarezDataSet1.VENTASDIA, DTPINCIO.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
