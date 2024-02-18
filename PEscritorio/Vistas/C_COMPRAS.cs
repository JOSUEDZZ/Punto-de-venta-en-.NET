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
    public partial class C_COMPRAS : Form
    {
        string rfc;
        int noc;
        public C_COMPRAS(string RFCPROV, int NOcompra)
        {
            InitializeComponent();
            Rfc= RFCPROV;
            Noc= NOcompra;
        }

        public string Rfc { get => rfc; set => rfc = value; }
        public int Noc { get => noc; set => noc = value; }

        private void C_COMPRAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.COMCOMPRA' Puede moverla o quitarla según sea necesario.
            this.cOMCOMPRATableAdapter.Fill(this.bDPinturaJuarezDataSet1.COMCOMPRA,noc);
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.DATOSPROV' Puede moverla o quitarla según sea necesario.
            this.dATOSPROVTableAdapter.Fill(this.bDPinturaJuarezDataSet1.DATOSPROV,rfc);

            this.reportViewer1.RefreshReport();
        }
    }
}
