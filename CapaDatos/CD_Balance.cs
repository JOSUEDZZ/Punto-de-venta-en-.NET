using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Balance
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar()
        {
            SqlCommand comandoMB = new SqlCommand();
            comandoMB.Connection = conexion.AbrirConexion();
            comandoMB.CommandText = "MostrarBalance";
            comandoMB.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMB = comandoMB.ExecuteReader();
            DataTable tablaMB = new DataTable();
            tablaMB.Load(leerMB);
            conexion.CerrarConexion();
            return tablaMB;
        }
        public DataTable MostCuenta(DateTime @FECHA)
        {
            SqlCommand comandoMBC = new SqlCommand();
            comandoMBC.Connection = conexion.AbrirConexion();
            comandoMBC.CommandText = "MostCuentas";
            comandoMBC.CommandType = CommandType.StoredProcedure;
            comandoMBC.Parameters.AddWithValue("@FECHA", FECHA);
            SqlDataReader leerMBC = comandoMBC.ExecuteReader();
            DataTable tablaMBC = new DataTable();
            tablaMBC.Load(leerMBC);
            conexion.CerrarConexion();
            return tablaMBC;
        }
        public void InsertarBalance(decimal NOBALANCE, DateTime FECHA,decimal TOTALACTIVO, decimal TOTALPASICVO)
        {
            SqlCommand comandoIB = new SqlCommand();
            comandoIB.Connection = conexion.AbrirConexion();
            comandoIB.CommandText = "inserBalance";
            comandoIB.CommandType = CommandType.StoredProcedure;
            comandoIB.Parameters.AddWithValue("@NOBALANCE", NOBALANCE);
            comandoIB.Parameters.AddWithValue("@FECHA", FECHA);
            comandoIB.Parameters.AddWithValue("@TOTALACTIVO", TOTALACTIVO);
            comandoIB.Parameters.AddWithValue("@TOTALPASICVO", TOTALPASICVO);
            comandoIB.ExecuteNonQuery();
        }
        public void InsertarBAV(decimal NOBALANCE, decimal FKNOVENTA, DateTime FECHA)
        {
            SqlCommand comandoINP = new SqlCommand();
            comandoINP.Connection = conexion.AbrirConexion();
            comandoINP.CommandText = "InserBAV";
            comandoINP.CommandType = CommandType.StoredProcedure;
            comandoINP.Parameters.AddWithValue("@NOBALANCE", NOBALANCE);
            comandoINP.Parameters.AddWithValue("@FKNOVENTA", FKNOVENTA);
            comandoINP.Parameters.AddWithValue("@FECHA", FECHA);
            comandoINP.ExecuteNonQuery();
        }
        public void InsertarBAC(decimal NOBALANCE, decimal FKCFACTURA, DateTime FECHA)
        {
            SqlCommand comandoINP = new SqlCommand();
            comandoINP.Connection = conexion.AbrirConexion();
            comandoINP.CommandText = "InserBAC";
            comandoINP.CommandType = CommandType.StoredProcedure;
            comandoINP.Parameters.AddWithValue("@NOBALANCE", NOBALANCE);
            comandoINP.Parameters.AddWithValue("@FKCFACTURA", FKCFACTURA);
            comandoINP.Parameters.AddWithValue("@FECHA", FECHA);
            comandoINP.ExecuteNonQuery();
        }
    }
}
