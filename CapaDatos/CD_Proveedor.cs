using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable MostrarP()
        {
            SqlCommand comandoMP = new SqlCommand();
            comandoMP.Connection = conexion.AbrirConexion();
            comandoMP.CommandText = "MostrarProveedores";
            comandoMP.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMP = comandoMP.ExecuteReader();
            DataTable tablaMP = new DataTable();
            tablaMP.Load(leerMP);
            conexion.CerrarConexion();
            return tablaMP;
        }
        public void InsertarRegistroP(string PRORFC, string NOMBRE, string DIRECCION, string CORREOELECTRONICO, string CONTACTO, decimal TELEFONO)
        {
            SqlCommand comandoINP = new SqlCommand();
            comandoINP.Connection = conexion.AbrirConexion();
            comandoINP.CommandText = "InsertarProveedores";
            comandoINP.CommandType = CommandType.StoredProcedure;
            comandoINP.Parameters.AddWithValue("@PRORFC", PRORFC);
            comandoINP.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            comandoINP.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            comandoINP.Parameters.AddWithValue("@CORREOELECTRONICO", CORREOELECTRONICO);
            comandoINP.Parameters.AddWithValue("@CONTACTO", CONTACTO);
            comandoINP.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comandoINP.ExecuteNonQuery();
        }
        public void EliminarRegistroP(string PRORFC)
        {
            SqlCommand comandoELP = new SqlCommand();
            comandoELP.Connection = conexion.AbrirConexion();
            comandoELP.CommandText = "EliminarProveedores";
            comandoELP.CommandType = CommandType.StoredProcedure;
            comandoELP.Parameters.AddWithValue("@PRORFC", PRORFC);
            comandoELP.ExecuteNonQuery();
            comandoELP.Parameters.Clear();
        }
        public void EditarProveedores(string PRORFC, string NOMBRE, string DIRECCION, string CORREOELECTRONICO, string CONTACTO, decimal TELEFONO)
        {
            SqlCommand comandoEDP = new SqlCommand();
            comandoEDP.Connection = conexion.AbrirConexion();
            comandoEDP.CommandText = "EditarProveedor";
            comandoEDP.CommandType = CommandType.StoredProcedure;
            comandoEDP.Parameters.AddWithValue("@PRORFC", PRORFC);
            comandoEDP.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            comandoEDP.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            comandoEDP.Parameters.AddWithValue("@CORREOELECTRONICO", CORREOELECTRONICO);
            comandoEDP.Parameters.AddWithValue("@CONTACTO", CONTACTO);
            comandoEDP.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comandoEDP.ExecuteNonQuery();
        }
    }
}
