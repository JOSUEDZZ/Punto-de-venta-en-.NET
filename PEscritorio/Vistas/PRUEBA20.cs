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
    public partial class PRUEBA20 : Form
    {
        public PRUEBA20()
        {
            InitializeComponent();
        }

        private void PRUEBA20_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.R_VENTAS_DIA2' Puede moverla o quitarla según sea necesario.
            // this.r_VENTAS_DIA2TableAdapter.Fill(this.bDPinturaJuarezDataSet1.R_VENTAS_DIA2);
            //string feini = "2023-04-15";

            //DateTime fef = DateTime.Now;

            //DateTime fei = Convert.ToDateTime(feini);
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.R_VENTAS_DIA' Puede moverla o quitarla según sea necesario.
            //this.r_VENTAS_DIATableAdapter.Fill(this.bDPinturaJuarezDataSet1.R_VENTAS_DIA,fei,fef);
            //this.reportViewer1.RefreshReport();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.r_VENTAS_DIA2TableAdapter.Fill(this.bDPinturaJuarezDataSet1.R_VENTAS_DIA2,DTPINCIO.Value,DTPFINAL.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
