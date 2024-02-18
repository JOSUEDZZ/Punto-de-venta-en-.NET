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
    public partial class COTIZACION : Form
    {
        public COTIZACION(int NoCOT)
        {
            InitializeComponent();
            this.NoCOT = NoCOT;
        }
        int noCOT;         
        public int NoCOT { get => noCOT; set => noCOT = value; }

        private void COTIZACION_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.CREARCOT' Puede moverla o quitarla según sea necesario.
            this.cREARCOTTableAdapter.Fill(this.bDPinturaJuarezDataSet1.CREARCOT,NoCOT);
            this.reportViewer1.RefreshReport();
        }
    }
}
