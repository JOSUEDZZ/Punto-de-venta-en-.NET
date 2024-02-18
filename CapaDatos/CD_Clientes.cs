using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        //METODO PARA MOSTRAR CLIENTES
        public DataTable Mostrar()
        {
            SqlCommand comandoMCL = new SqlCommand();
            comandoMCL.Connection = conexion.AbrirConexion();
            comandoMCL.CommandText = "MostrarClientes";
            comandoMCL.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMCL = comandoMCL.ExecuteReader();
            DataTable tablaMCL = new DataTable();
            tablaMCL.Load(leerMCL);
            conexion.CerrarConexion();
            return tablaMCL;
        }
        public DataTable BuscarRFC()
        {
            SqlCommand comando7 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando7.Connection = conexion.AbrirConexion();
            comando7.CommandText = "BuscarRFCCliente";
            comando7.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer3 = comando7.ExecuteReader();
            DataTable tabla3 = new DataTable(); //Para almacenar las filas de la consulta
            tabla3.Clear();
            tabla3.Load(leer3);
            conexion.CerrarConexion();
            return tabla3;
        }
        public DataTable BuscarNombre()
        {
            SqlCommand comando8 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando8.Connection = conexion.AbrirConexion();
            comando8.CommandText = "BuscarRFCCliente";
            comando8.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer4 = comando8.ExecuteReader();
            DataTable tabla4 = new DataTable(); //Para almacenar las filas de la consulta
            tabla4.Clear();
            tabla4.Load(leer4);
            conexion.CerrarConexion();
            return tabla4;
        }
        //METODO PARA INSERTAR CLIENTES
        public void InsertarRegistro(string CLIRFC, string NOMBRE, string DIRECCION, string CORREOELECTRONICO, decimal CODIGOPOSTAL, decimal TELEFONO)
        {
            SqlCommand comandoINCL = new SqlCommand();
            comandoINCL.Connection = conexion.AbrirConexion();
            comandoINCL.CommandText = "InsertarClientes";
            comandoINCL.CommandType = CommandType.StoredProcedure;
            comandoINCL.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comandoINCL.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            comandoINCL.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            comandoINCL.Parameters.AddWithValue("@CORREOELECTRONICO", CORREOELECTRONICO);
            comandoINCL.Parameters.AddWithValue("@CODIGOPOSTAL", CODIGOPOSTAL);
            comandoINCL.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comandoINCL.ExecuteNonQuery();
        }


        //METODO PARA ELIMINAR REGISTRO
        public void EliminarRegistro(string CLIRFC)
        {
            SqlCommand comandoELCL = new SqlCommand();
            comandoELCL.Connection = conexion.AbrirConexion();
            comandoELCL.CommandText = "EliminarCliente";
            comandoELCL.CommandType = CommandType.StoredProcedure;
            comandoELCL.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comandoELCL.ExecuteNonQuery();
            comandoELCL.Parameters.Clear();
        }
        //METODO PARA ACTUALIZAR REGISTRO
        public void ActualizarCliente(string CLIRFC, string NOMBRE, string DIRECCION, string CORREOELECTRONICO, decimal CODIGOPOSTAL, decimal TELEFONO)
        {
            SqlCommand comandoACL = new SqlCommand();
            comandoACL.Connection = conexion.AbrirConexion();
            comandoACL.CommandText = "ActualizarCliente";
            comandoACL.CommandType = CommandType.StoredProcedure;
            comandoACL.Parameters.AddWithValue("@CLIRFC", CLIRFC);
            comandoACL.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            comandoACL.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            comandoACL.Parameters.AddWithValue("@CORREOELECTRONICO", CORREOELECTRONICO);
            comandoACL.Parameters.AddWithValue("@CODIGOPOSTAL", CODIGOPOSTAL);
            comandoACL.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comandoACL.ExecuteNonQuery();
        }
    }
}
