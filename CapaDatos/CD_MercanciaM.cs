using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_MercanciaM
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar()
        {
            SqlCommand comandoMMM = new SqlCommand();
            comandoMMM.Connection = conexion.AbrirConexion();
            comandoMMM.CommandText = "MostrarMateriales";
            comandoMMM.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMMM = comandoMMM.ExecuteReader();
            DataTable tablaMMM = new DataTable();
            tablaMMM.Load(leerMMM);
            conexion.CerrarConexion();
            return tablaMMM;
        }
        public DataTable MERPRO(string PRORFC)
        {
            SqlCommand comandoMBC = new SqlCommand();
            comandoMBC.Connection = conexion.AbrirConexion();
            comandoMBC.CommandText = "MaterialesPROMateria";
            comandoMBC.CommandType = CommandType.StoredProcedure;
            comandoMBC.Parameters.AddWithValue("@PRORFC", PRORFC);
            SqlDataReader leerMBC = comandoMBC.ExecuteReader();
            DataTable tablaMBC = new DataTable();
            tablaMBC.Load(leerMBC);
            conexion.CerrarConexion();
            return tablaMBC;
        }
        public DataTable MostrarMarcaMateriales()
        {
            SqlCommand comandoMOM = new SqlCommand();
            comandoMOM.Connection = conexion.AbrirConexion();
            comandoMOM.CommandText = "MostrarMateriales";
            comandoMOM.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMOM = comandoMOM.ExecuteReader();
            DataTable tablaMOM = new DataTable();
            tablaMOM.Load(leerMOM);
            conexion.CerrarConexion();
            return tablaMOM;
        }
        public DataTable BuscarProveedorMateriales()
        {
            SqlCommand comando7 = new SqlCommand();
            comando7.Connection = conexion.AbrirConexion();
            comando7.CommandText = "MostrarProveedores";
            comando7.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer3 = comando7.ExecuteReader();
            DataTable tabla3 = new DataTable(); //Para almacenar las filas de la consulta
            tabla3.Clear();
            tabla3.Load(leer3);
            conexion.CerrarConexion();
            return tabla3;
        }
        //METODO PARA INSERTAR MATERIALES
        public void InsertarRegistro(decimal CODIGO, string MARCA, string PRODUCTO, string UNIDAD, decimal PRECIO, decimal PREVEN, decimal CANTIDAD, string PROVEEDOR)
        {
            SqlCommand comandoINMM = new SqlCommand();
            comandoINMM.Connection = conexion.AbrirConexion();
            comandoINMM.CommandText = "InsertarMateriales";
            comandoINMM.CommandType = CommandType.StoredProcedure;
            comandoINMM.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoINMM.Parameters.AddWithValue("@MARCA", MARCA);
            comandoINMM.Parameters.AddWithValue("@PRODUCTO", PRODUCTO);
            comandoINMM.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
            comandoINMM.Parameters.AddWithValue("@UNIDAD ", UNIDAD);
            comandoINMM.Parameters.AddWithValue("@PRECIO", PRECIO);
            comandoINMM.Parameters.AddWithValue("@PREVEN", PREVEN);
            comandoINMM.Parameters.AddWithValue("@PROVEEDOR", PROVEEDOR);
            comandoINMM.ExecuteNonQuery();
        }
        //METODO PARA EDITAR REGISTROS
        public void EditarRegistro(decimal CODIGO, string MARCA, string PRODUCTO, string UNIDAD, decimal PRECIO, decimal PREVEN, decimal CANTIDAD, string PROVEEDOR)
        {
            SqlCommand comandoEDMM = new SqlCommand();
            comandoEDMM.Connection = conexion.AbrirConexion();
            comandoEDMM.CommandText = "EditarMateriales";
            comandoEDMM.CommandType = CommandType.StoredProcedure;
            comandoEDMM.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoEDMM.Parameters.AddWithValue("@MARCA", MARCA);
            comandoEDMM.Parameters.AddWithValue("@PRODUCTO", PRODUCTO);
            comandoEDMM.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
            comandoEDMM.Parameters.AddWithValue("@UNIDAD ", UNIDAD);
            comandoEDMM.Parameters.AddWithValue("@PRECIO", PRECIO);
            comandoEDMM.Parameters.AddWithValue("@PREVEN", PREVEN);
            comandoEDMM.Parameters.AddWithValue("@PROVEEDOR", PROVEEDOR);
            comandoEDMM.ExecuteNonQuery();
        }
        //METODO PARA ELIMINAR REGISTRO
        public void EliminarRegistro(decimal CODIGO)
        {
            SqlCommand comandoELMM = new SqlCommand();
            comandoELMM.Connection = conexion.AbrirConexion();
            comandoELMM.CommandText = "EliminarMaterial";
            comandoELMM.CommandType = CommandType.StoredProcedure;
            comandoELMM.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoELMM.ExecuteNonQuery();
            comandoELMM.Parameters.Clear();
        }
    }
}
