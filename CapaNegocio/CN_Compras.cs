using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compras
    {
        private CD_Ventas objetoCD = new CD_Ventas();
        CD_Compras objetoCom = new CD_Compras();

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarRegistro(decimal CFACTURA, DateTime FECHA, decimal TOTAL, string FKPRORFC, string FKURFC)
        {
            objetoCom.InsertarCompra(Convert.ToDecimal(CFACTURA), Convert.ToDateTime(FECHA), Convert.ToDecimal(TOTAL), FKPRORFC, FKURFC);
        }
        public void InsertarCIM(decimal CFACTURA, decimal FKCODIGO, decimal PRESUNIT, decimal PREVEN, decimal PRECIO, decimal CANTIDAD)
        {
            objetoCom.InsertarCIM(Convert.ToDecimal(CFACTURA), Convert.ToDecimal(FKCODIGO), Convert.ToDecimal(PRESUNIT), Convert.ToDecimal(PREVEN), Convert.ToDecimal(PRECIO), Convert.ToDecimal(CANTIDAD));
        }
    }
}
