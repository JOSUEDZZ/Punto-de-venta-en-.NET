using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Corte
    {
        private CD_Corte objetoCD = new CD_Corte();

        public DataTable MostrarCorte()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }


        public void MostrarTotalCaja(DateTime FECHA)
        {
            objetoCD.MostrarTOTALCaja(Convert.ToDateTime(FECHA));
        }




        public void InsertarRegistro(string NOCORTE, DateTime FECHA, string TOTAL, string TOTALCAJA, string FONDOINICIAL, string FKURFC, string VENTA, string CFACTURA)
        {
            objetoCD.InsertarRegistro(Convert.ToInt32(NOCORTE), Convert.ToDateTime(FECHA), Convert.ToDouble(TOTAL), Convert.ToDouble(TOTALCAJA), Convert.ToDouble(FONDOINICIAL), FKURFC, Convert.ToInt32(VENTA), Convert.ToInt32(CFACTURA));
        }

    }
}
