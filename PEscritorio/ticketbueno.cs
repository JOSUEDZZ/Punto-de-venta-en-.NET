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
    public partial class ticketbueno : Form
    {
        public ticketbueno(decimal Noventa)
        {
            InitializeComponent();
            this.Noventa = Noventa;
        }
        decimal Noventa {get;set;}
        private void ticketbueno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.CAMBIO' Puede moverla o quitarla según sea necesario.
            this.cAMBIOTableAdapter.Fill(this.bDPinturaJuarezDataSet1.CAMBIO,Noventa);
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet.TICKET' Puede moverla o quitarla según sea necesario.
            this.tICKETTableAdapter.Fill(this.bDPinturaJuarezDataSet.TICKET,Noventa);
            this.reportViewer1.RefreshReport();
        }

        private void tICKETBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
