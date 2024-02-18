using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objProvee = new CD_Proveedor();
        public DataTable MostrarProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = objProvee.MostrarP();
            return tabla;
        }
        public void InsertarRegistro(string PRORFC, string NOMBRE, string DIRECCION, string CORREOELECTRONICO, string CONTACTO, decimal TELEFONO)
        {
            objProvee.InsertarRegistroP(PRORFC, NOMBRE, DIRECCION, CORREOELECTRONICO, CONTACTO, Convert.ToDecimal(TELEFONO));
        }
        public void EliminarProveedor(string PRORFC)
        {
            objProvee.EliminarRegistroP(PRORFC);
        }
        public void EditarProveedores(string PRORFC, string NOMBRE, string DIRECCION, string CORREOELECTRONICO, string CONTACTO, decimal TELEFONO)
        {
            objProvee.EditarProveedores(PRORFC, NOMBRE, DIRECCION, CORREOELECTRONICO, CONTACTO, Convert.ToDecimal(TELEFONO));
        }
    }
}
