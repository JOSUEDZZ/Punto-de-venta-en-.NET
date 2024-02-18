using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        public DataTable MostrarVentas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarCUENTAS(decimal COTCOD)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostCotizacion(COTCOD);
            return tabla;
        }
        public void InsertarRegistro(decimal NOVENTA, DateTime FECHA, decimal TOTAL, string FKURFC, string FKCLIRFC)
        {
            objetoCD.InsertarRegistro(Convert.ToDecimal(NOVENTA),Convert.ToDateTime(FECHA), Convert.ToDecimal(TOTAL), FKURFC, FKCLIRFC);
        }
        public void InsertarPago(decimal NOVENTA, decimal PAGO, decimal CAMBIO)
        {
            objetoCD.InsertarPago(Convert.ToDecimal(NOVENTA), Convert.ToDecimal(PAGO), Convert.ToDecimal(CAMBIO));
        }
        public DataTable MostrarCot()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCOT();
            return tabla;
        }
    }
}
