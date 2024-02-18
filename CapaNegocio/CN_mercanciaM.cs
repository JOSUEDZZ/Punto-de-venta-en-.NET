using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_mercanciaM
    {
        private CD_MercanciaM objetoCD = new CD_MercanciaM();

        public DataTable MostrarMercanciaM()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public DataTable MostrarMarcaMateriales()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMarcaMateriales();
            return tabla;
        }
        public DataTable MostrarProveedoresMercancia()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProveedorMateriales();
            return tabla;
        }
        public DataTable MERPRO(string PRORFC)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MERPRO(PRORFC);
            return tabla;
        }

        public void InsertarRegistro(string CODIGO, string MARCA, string PRODUCTO, string UNIDAD, string PRECIO, string PREVEN, string CANTIDAD, string PROVEEDOR)
        {
            objetoCD.InsertarRegistro(Convert.ToDecimal(CODIGO), MARCA, PRODUCTO, UNIDAD, Convert.ToDecimal(PRECIO), Convert.ToDecimal(PREVEN), Convert.ToDecimal(CANTIDAD), PROVEEDOR);
        }
        public void EditarMateriales(string CODIGO, string MARCA, string PRODUCTO, string UNIDAD, string PRECIO, string PREVEN, string CANTIDAD, string PROVEEDOR)
        {
            objetoCD.EditarRegistro(Convert.ToDecimal(CODIGO), MARCA, PRODUCTO, UNIDAD, Convert.ToDecimal(PRECIO), Convert.ToDecimal(PREVEN), Convert.ToDecimal(CANTIDAD), PROVEEDOR);
        }

        public void EliminarMaterial(string CODIGO)
        {
            objetoCD.EliminarRegistro(Convert.ToDecimal(CODIGO));
        }
    }
}
