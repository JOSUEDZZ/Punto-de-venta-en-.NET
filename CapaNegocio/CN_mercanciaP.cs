using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_mercanciaP
    {
        private CD_mercanciaP objetoCD = new CD_mercanciaP();

        public DataTable MostrarPintura()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarCodigo()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarCodigo();
            return tabla;

        }
        public DataTable COMPRO(string PRORFC)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.COMPRO(PRORFC);
            return tabla;
        }
        public DataTable MostrarProveedores()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProveedor();
            return tabla;

        }
        public DataTable MostrarMarca()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarMarca();
            return tabla;

        }
        public void InsertarRegistro(string CODIGO, string MARCA, string COLOR, string CANTIDAD, string PRECIO, string PREVEN, string TIPO, string UNIDADMEDIDA, string PROVEEDOR)
        {
            objetoCD.InsertarRegistro(Convert.ToDecimal(CODIGO), MARCA, COLOR, Convert.ToInt32(CANTIDAD), Convert.ToDecimal(PRECIO), Convert.ToDecimal(PREVEN), TIPO, UNIDADMEDIDA, PROVEEDOR);
        }

        public void EditarPintura(string CODIGO, string MARCA, string COLOR, string CANTIDAD, string PRECIO, string PREVEN, string TIPO, string UNIDADMEDIDA, string PROVEEDOR)
        {
            objetoCD.EditarRegistro(Convert.ToDecimal(CODIGO), MARCA, COLOR,Convert.ToDecimal(CANTIDAD),Convert.ToDecimal(PRECIO), Convert.ToDecimal(PREVEN), TIPO, UNIDADMEDIDA, PROVEEDOR);
        }

        public void EliminarMaterial(string CODIGO)
        {
            objetoCD.EliminarRegistro(Convert.ToInt32(CODIGO));
        }
    }
}
