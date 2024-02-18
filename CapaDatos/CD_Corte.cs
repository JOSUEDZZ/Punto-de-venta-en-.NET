using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Corte
    {
        private CD_Conexion conexion = new CD_Conexion();
        //METODO PARA MOSTRAR CLIENTES
        public DataTable Mostrar()
        {
            SqlCommand comandoMCL = new SqlCommand();
            comandoMCL.Connection = conexion.AbrirConexion();
            comandoMCL.CommandText = "MostrarCorte";
            comandoMCL.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMCL = comandoMCL.ExecuteReader();
            DataTable tablaMCL = new DataTable();
            tablaMCL.Load(leerMCL);
            conexion.CerrarConexion();
            return tablaMCL;
        }
        public void MostrarTOTALCaja(DateTime FECHA)
        {
            SqlCommand comandoMTC = new SqlCommand();
            comandoMTC.Connection = conexion.AbrirConexion();
            comandoMTC.CommandText = "MostrarTOTALCaja";
            comandoMTC.CommandType = CommandType.StoredProcedure;
            comandoMTC.Parameters.AddWithValue("@FECHA", FECHA);
            comandoMTC.ExecuteNonQuery();
        }

        //METODO PARA INSERTAR CORTE
        public void InsertarRegistro(int NOCORTE, DateTime FECHA, double TOTAL, double TOTALCAJA, double FONDOINICIAL, string FKURFC, int VENTA, int CFACTURA)
        {
            SqlCommand comandoINCOR = new SqlCommand();
            comandoINCOR.Connection = conexion.AbrirConexion();
            comandoINCOR.CommandText = "CrearNuevoCorte";
            comandoINCOR.CommandType = CommandType.StoredProcedure;
            comandoINCOR.Parameters.AddWithValue("@NOCORTE", NOCORTE);
            comandoINCOR.Parameters.AddWithValue("@FECHA", FECHA);
            comandoINCOR.Parameters.AddWithValue("@TOTAL", TOTAL);
            comandoINCOR.Parameters.AddWithValue("@TOTALCAJA", TOTALCAJA);
            comandoINCOR.Parameters.AddWithValue("@FONDOINICIAL ", FONDOINICIAL);
            comandoINCOR.Parameters.AddWithValue("@FKURFC", FKURFC);
            comandoINCOR.Parameters.AddWithValue("@VENTA", VENTA);
            comandoINCOR.Parameters.AddWithValue("@CFACTURA", CFACTURA);

            comandoINCOR.ExecuteNonQuery();
        }       
    }
}
