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
    public partial class RP_THINER : Form
    {
        public RP_THINER()
        {
            InitializeComponent();
        }

        private void RP_THINER_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MATERIALTHINER' Puede moverla o quitarla según sea necesario.
            //this.mATERIALTHINERTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALTHINER);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.mATERIALTHINERTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MATERIALTHINER,DTPINCIO.Value,DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
