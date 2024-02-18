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
    public partial class F_CORTE : Form
    {
        int NoCorte;
        DateTime Fe;
        public F_CORTE(int noCorte, DateTime fe)
        {
            InitializeComponent();
            NoCorte1 = noCorte;
            Fe1 = fe;
        }

        public int NoCorte1 { get => NoCorte; set => NoCorte = value; }
        public DateTime Fe1 { get => Fe; set => Fe = value; }

        private void F_CORTE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.CREARCOT' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.CREARCOT' Puede moverla o quitarla según sea necesario.
            this.mostrarCorteNOTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MostrarCorteNO, NoCorte);
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet11.MostrarCorte' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MostCuentas' Puede moverla o quitarla según sea necesario.
            this.mostCuentasTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MostCuentas, Fe);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
