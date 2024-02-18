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
    public partial class RP_PROVMASCOMPRADO : Form
    {
        public RP_PROVMASCOMPRADO()
        {
            InitializeComponent();
        }

        private void RP_PROVMASCOMPRADO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.PROVEDORMASCOMPRADO' Puede moverla o quitarla según sea necesario.
            //this.pROVEDORMASCOMPRADOTableAdapter.Fill(this.bDPinturaJuarezDataSet1.PROVEDORMASCOMPRADO);

            //this.reportViewer1.RefreshReport();
        }

        private void BTNGENERAR_Click(object sender, EventArgs e)
        {
            this.pROVEDORMASCOMPRADOTableAdapter.Fill(this.bDPinturaJuarezDataSet1.PROVEDORMASCOMPRADO,DTPINCIO.Value,DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
