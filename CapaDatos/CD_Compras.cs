using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compras
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar()
        {
            SqlCommand comandoMCO = new SqlCommand();
            comandoMCO.Connection = conexion.AbrirConexion();
            comandoMCO.CommandText = "MostrarCompras";
            comandoMCO.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMCO = comandoMCO.ExecuteReader();
            DataTable tablaMCO = new DataTable();
            tablaMCO.Load(leerMCO);
            conexion.CerrarConexion();
            return tablaMCO;
        }
        public void InsertarCompra(decimal CFACTURA, DateTime FECHA, decimal TOTAL, string FKPRORFC, string FKURFC)
        {
            SqlCommand comandoIRV = new SqlCommand();
            comandoIRV.Connection = conexion.AbrirConexion();
            comandoIRV.CommandText = "InsertarCompra";
            comandoIRV.CommandType = CommandType.StoredProcedure;
            comandoIRV.Parameters.AddWithValue("@CFACTURA", CFACTURA);
            comandoIRV.Parameters.AddWithValue("@FECHA", FECHA);
            comandoIRV.Parameters.AddWithValue("@TOTAL", TOTAL);
            comandoIRV.Parameters.AddWithValue("@FKPRORFC", FKPRORFC);
            comandoIRV.Parameters.AddWithValue("@FKURFC", FKURFC);
            comandoIRV.ExecuteNonQuery();
        }
        public void InsertarCIM(decimal CFACTURA, decimal FKCODIGO, decimal PRESUNIT, decimal PREVEN, decimal PRECIO, decimal CANTIDAD)
        {
            SqlCommand comandoIRV = new SqlCommand();
            comandoIRV.Connection = conexion.AbrirConexion();
            comandoIRV.CommandText = "InsertarCIM";
            comandoIRV.CommandType = CommandType.StoredProcedure;
            comandoIRV.Parameters.AddWithValue("@FKCFACTURA", CFACTURA);
            comandoIRV.Parameters.AddWithValue("@FKCODIGO", FKCODIGO);
            comandoIRV.Parameters.AddWithValue("@PRESUNIT", PRESUNIT);
            comandoIRV.Parameters.AddWithValue("@PREVEN", PREVEN);
            comandoIRV.Parameters.AddWithValue("@PRECIO", PRECIO);
            comandoIRV.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
            comandoIRV.ExecuteNonQuery();
        }
    }
}
