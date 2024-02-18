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
    public class CN_Usuario
    {
        private CD_Usuario objetoCD = new CD_Usuario();

        public DataTable MostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public DataTable MostrarUsuario2()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarUserVistaEmpleado();
            return tabla;
        }
        //public DataTable BuscarRFC()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = objetoCD.BuscarRFC();
        //    return tabla;
        //}
        public void InsertarRegistro(string URFC, string NOMBRE, string DIRECCION, string CURP, string CODIGOPOSTAL, string CIUDAD, DateTime FECHANACI, decimal TELEFONO, string TIPO, string PASWORD, string PREGUNTA, string RESPUESTA)
        {
            objetoCD.InsertarUsuario(URFC, NOMBRE, DIRECCION, CURP, CODIGOPOSTAL, CIUDAD, Convert.ToDateTime(FECHANACI), Convert.ToDecimal(TELEFONO), TIPO, PASWORD, PREGUNTA, RESPUESTA);
           
        }
        public void EditarUsuario(string URFC, string NOMBRE, string DIRECCION, string CURP, string CODIGOPOSTAL, string CIUDAD, DateTime FECHANACI, decimal TELEFONO, string TIPO, string PASWORD, string PREGUNTA, string RESPUESTA)
        {
            objetoCD.EditarUsuario(URFC, NOMBRE, DIRECCION, CURP, CODIGOPOSTAL, CIUDAD, Convert.ToDateTime(FECHANACI), Convert.ToDecimal(TELEFONO), TIPO, PASWORD, PREGUNTA, RESPUESTA);

        }

        public void EliminarUsuario(string URFC)
        {
            objetoCD.EliminarUsuario(URFC);
        }










    }
}
