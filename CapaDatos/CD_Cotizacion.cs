using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cotizacion
    {
        private CD_Conexion conexion = new CD_Conexion();

        public void InsertarCOT(decimal Nocot,DateTime Fecha, decimal total,int Cantidad ,string RFCUSU, decimal CODIGO, string RFCCLIEN)
        {
            SqlCommand comandoVR = new SqlCommand();
            comandoVR.Connection = conexion.AbrirConexion();
            comandoVR.CommandText = "COTIRELA";
            comandoVR.CommandType = CommandType.StoredProcedure;
            comandoVR.Parameters.Clear();
            comandoVR.Parameters.AddWithValue("CODCOT", Nocot);
            comandoVR.Parameters.AddWithValue("FECHA", Fecha);
            comandoVR.Parameters.AddWithValue("TOTAL", total);
            comandoVR.Parameters.AddWithValue("CATIDAD", Cantidad);
            comandoVR.Parameters.AddWithValue("FKUSURFC", RFCUSU);
            comandoVR.Parameters.AddWithValue("FKCODIGO", CODIGO);
            comandoVR.Parameters.AddWithValue("FKCLIRFC", RFCCLIEN);
            comandoVR.ExecuteNonQuery();
        }

        public void crearcot(decimal NUMCOT)
        {
            SqlCommand comandoFV = new SqlCommand();
            comandoFV.Connection = conexion.AbrirConexion();
            comandoFV.CommandText = "CREARCOT";
            comandoFV.CommandType = CommandType.StoredProcedure;
            comandoFV.Parameters.Clear();
            comandoFV.Parameters.AddWithValue("NUMCOT", NUMCOT);
            comandoFV.ExecuteNonQuery();
        }
    }
}
