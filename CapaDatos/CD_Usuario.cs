using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class CD_Usuario
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar()
        {
            SqlCommand comando1 = new SqlCommand();
            comando1.Connection = conexion.AbrirConexion();
            comando1.CommandText = "MostrarUsuario";
            comando1.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer1 = comando1.ExecuteReader();
            DataTable tabla1 = new DataTable(); //Para almacenar las filas de la consulta
            tabla1.Load(leer1);
            conexion.CerrarConexion();
            return tabla1;
        }
        public DataTable MostrarUserVistaEmpleado()
        {
            SqlCommand comando1 = new SqlCommand();
            comando1.Connection = conexion.AbrirConexion();
            comando1.CommandText = "MostrarUsuario2";
            comando1.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer1 = comando1.ExecuteReader();
            DataTable tabla1 = new DataTable(); //Para almacenar las filas de la consulta
            tabla1.Load(leer1);
            conexion.CerrarConexion();

            return tabla1;
        }
        public void InsertarUsuario(string URFC, string NOMBRE, string DIRECCION, string CURP, string CODIGOPOSTAL, string CIUDAD, DateTime FECHANACI, decimal TELEFONO, string TIPO, string PASWORD, string PREGUNTA, string RESPUESTA)
        {
            SqlCommand comando1 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando1.Connection = conexion.AbrirConexion();
            comando1.CommandText = "InsertarUsuario";
            comando1.CommandType = CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@URFC", URFC);
            comando1.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            comando1.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            comando1.Parameters.AddWithValue("@CURP", CURP);
            comando1.Parameters.AddWithValue("@CODIGOPOSTAL", CODIGOPOSTAL);
            comando1.Parameters.AddWithValue("@CIUDAD", CIUDAD);
            comando1.Parameters.AddWithValue("@FECHANACI", FECHANACI);
            comando1.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comando1.Parameters.AddWithValue("@TIPO", TIPO);
            comando1.Parameters.AddWithValue("@PASWORD", PASWORD);
            comando1.Parameters.AddWithValue("@PREGUNTA", PREGUNTA);
            comando1.Parameters.AddWithValue("@RESPUESTA", RESPUESTA);
            comando1.ExecuteNonQuery();
        }
        //METODO PARA EDITAR REGISTROS
        public void EditarUsuario(string URFC, string NOMBRE, string DIRECCION, string CURP, string CODIGOPOSTAL, string CIUDAD, DateTime FECHANACI, decimal TELEFONO, string TIPO, string PASWORD, string PREGUNTA, string RESPUESTA)
        {
            SqlCommand comando3 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando3.Connection = conexion.AbrirConexion();
            comando3.CommandText = "EditarUsuario";
            comando3.CommandType = CommandType.StoredProcedure;
            comando3.Parameters.AddWithValue("@URFC", URFC);
            comando3.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            comando3.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            comando3.Parameters.AddWithValue("@CURP", CURP);
            comando3.Parameters.AddWithValue("@CODIGOPOSTAL", CODIGOPOSTAL);
            comando3.Parameters.AddWithValue("@CIUDAD", CIUDAD);
            comando3.Parameters.AddWithValue("@FECHANACI", FECHANACI);
            comando3.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comando3.Parameters.AddWithValue("@TIPO", TIPO);
            comando3.Parameters.AddWithValue("@PASWORD", PASWORD);
            comando3.Parameters.AddWithValue("@PREGUNTA", PREGUNTA);
            comando3.Parameters.AddWithValue("@RESPUESTA", RESPUESTA);
            comando3.ExecuteNonQuery();
        }
        //METODO PARA ELIMINAR USUARIO
        public void EliminarUsuario(string URFC)
        {
            SqlCommand comando2 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando2.Connection = conexion.AbrirConexion();
            comando2.CommandText = "EliminarUsuario";
            comando2.CommandType = CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@URFC", URFC);
            comando2.ExecuteNonQuery();
            comando2.Parameters.Clear();
        }
    }
}
