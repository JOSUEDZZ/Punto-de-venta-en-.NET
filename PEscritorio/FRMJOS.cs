using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class FRMJOS : Form
    {
        public FRMJOS(int NoVENTA)
        {
            InitializeComponent();
            this.NoVENTA = NoVENTA;
 
        }
         int NoVENTA { get; set; }
        private void FRMJOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet.BUSCARNOMCLIENTE' Puede moverla o quitarla según sea necesario.
            this.bUSCARNOMCLIENTETableAdapter.Fill(this.bDPinturaJuarezDataSet.BUSCARNOMCLIENTE,NoVENTA);
            this.reportViewer1.RefreshReport();
        }
    }
}
