using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Windows.Input;


namespace CapaDatos
{
    public class CD_FACTURA
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar(int NoVenta)
        {
            SqlCommand comandoMF = new SqlCommand();
            DataTable tablaMF = new DataTable();
            tablaMF.Clear();
            comandoMF.Connection = conexion.AbrirConexion();
            comandoMF.CommandText = "DetFACTURA";
            comandoMF.CommandType = CommandType.StoredProcedure;
            comandoMF.Parameters.Clear();
            comandoMF.Parameters.AddWithValue("@NOventa", NoVenta);
            comandoMF.ExecuteNonQuery();
            SqlDataReader leerMF = comandoMF.ExecuteReader();
            tablaMF.Load(leerMF);
            conexion.CerrarConexion();
            return tablaMF;
        }
        public void ventasretiran(decimal NoVenta, decimal codigo, decimal PresU, int Cantidad, decimal Importe)
        {
            SqlCommand comandoVR = new SqlCommand();
            comandoVR.Connection = conexion.AbrirConexion();
            comandoVR.CommandText = "VentaMercacia";
            comandoVR.CommandType = CommandType.StoredProcedure;
            comandoVR.Parameters.Clear();
            comandoVR.Parameters.AddWithValue("FKNOVENTA", NoVenta);
            comandoVR.Parameters.AddWithValue("FKCODIGO", codigo);
            comandoVR.Parameters.AddWithValue("PRESUNIT", PresU);
            comandoVR.Parameters.AddWithValue("CANTIDAD", Cantidad);
            comandoVR.Parameters.AddWithValue("IMPORTE", Importe);
            comandoVR.ExecuteNonQuery();
        }
        public void FacturaVenta(decimal NOFAC, decimal NoVenta)
        {
            SqlCommand comandoFV = new SqlCommand();
            comandoFV.Connection = conexion.AbrirConexion();
            comandoFV.CommandText = "FACTURAVENTA";
            comandoFV.CommandType = CommandType.StoredProcedure;
            comandoFV.Parameters.Clear();
            comandoFV.Parameters.AddWithValue("NOFACTURA", NOFAC);
            comandoFV.Parameters.AddWithValue("NOVENTA", NoVenta);
            comandoFV.ExecuteNonQuery();
        }
        public void NoumerodeV()
        {
            SqlCommand comandoNV = new SqlCommand();
            comandoNV.Connection = conexion.AbrirConexion();
            comandoNV.CommandText = "NoventaV";
            comandoNV.CommandType = CommandType.StoredProcedure;
            comandoNV.ExecuteNonQuery();
        }

    }
}
