﻿using System;
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
    public partial class RP_PINMARCA : Form
    {
        public RP_PINMARCA()
        {
            InitializeComponent();
        }

        private void RP_PINMARCA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPinturaJuarezDataSet1.MARCAPMASV' Puede moverla o quitarla según sea necesario.
            this.mARCAPMASVTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MARCAPMASV,DTPINCIO.Value,DTPFINAL.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.mARCAPMASVTableAdapter.Fill(this.bDPinturaJuarezDataSet1.MARCAPMASV, DTPINCIO.Value, DTPFINAL.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
