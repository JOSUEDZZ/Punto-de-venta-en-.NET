using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar()
        {
            SqlCommand comando1 = new SqlCommand();
            comando1.Connection = conexion.AbrirConexion();
            comando1.CommandText = "MostrarVentas";
            comando1.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer1 = comando1.ExecuteReader();
            DataTable tabla1 = new DataTable();
            tabla1.Load(leer1);
            conexion.CerrarConexion();
            return tabla1;
        }
        public DataTable MostrarCOT()
        {
            SqlCommand comandoMB = new SqlCommand();
            comandoMB.Connection = conexion.AbrirConexion();
            comandoMB.CommandText = "MostrarCotizacion";
            comandoMB.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMB = comandoMB.ExecuteReader();
            DataTable tablaMB = new DataTable();
            tablaMB.Load(leerMB);
            conexion.CerrarConexion();
            return tablaMB;
        }
        public DataTable MostCotizacion(decimal COTCOD)
        {
            SqlCommand comandoMBC = new SqlCommand();
            comandoMBC.Connection = conexion.AbrirConexion();
            comandoMBC.CommandText = "MandarCotizacion";
            comandoMBC.CommandType = CommandType.StoredProcedure;
            comandoMBC.Parameters.AddWithValue("@COTCOD", COTCOD);
            SqlDataReader leerMBC = comandoMBC.ExecuteReader();
            DataTable tablaMBC = new DataTable();
            tablaMBC.Load(leerMBC);
            conexion.CerrarConexion();
            return tablaMBC;
        }
        public void InsertarRegistro(decimal NOVENTA, DateTime FECHA, decimal TOTAL, string FKURFC, string FKCLIRFC)
        {
            SqlCommand comandoIRV = new SqlCommand();
            comandoIRV.Connection = conexion.AbrirConexion();
            comandoIRV.CommandText = "InsertarVentas";
            comandoIRV.CommandType = CommandType.StoredProcedure;
            comandoIRV.Parameters.AddWithValue("@NOVENTA", NOVENTA);
            comandoIRV.Parameters.AddWithValue("@FECHA", FECHA);
            comandoIRV.Parameters.AddWithValue("@TOTAL", TOTAL);
            comandoIRV.Parameters.AddWithValue("@FKURFC", FKURFC);
            comandoIRV.Parameters.AddWithValue("@FKCLIRFC", FKCLIRFC);
            comandoIRV.ExecuteNonQuery();
        }
        //METODO PARA EDITAR REGISTROS
        public void InsertarPago(decimal NOVENTA, decimal PAGO, decimal CAMBIO)
        {
            SqlCommand comandoEdV = new SqlCommand();
            comandoEdV.Connection = conexion.AbrirConexion();
            comandoEdV.CommandText = "InsertarPagos";
            comandoEdV.CommandType = CommandType.StoredProcedure;
            comandoEdV.Parameters.AddWithValue("@NOVENTA", NOVENTA);
            comandoEdV.Parameters.AddWithValue("@PAGO", PAGO);
            comandoEdV.Parameters.AddWithValue("@CAMBIO", CAMBIO);
            comandoEdV.ExecuteNonQuery();
        }
    }
}
