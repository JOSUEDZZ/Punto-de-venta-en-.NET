using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_mercanciaP
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable Mostrar()
        {
            SqlCommand comandoMMP = new SqlCommand();
            comandoMMP.Connection = conexion.AbrirConexion();
            comandoMMP.CommandText = "mostrarPintura";
            comandoMMP.CommandType = CommandType.StoredProcedure;
            SqlDataReader leerMMP = comandoMMP.ExecuteReader();
            DataTable tablaMMP = new DataTable();
            tablaMMP.Load(leerMMP);
            conexion.CerrarConexion();
            return tablaMMP;
        }
        public DataTable COMPRO(string PRORFC)
        {
            SqlCommand comandoMBC = new SqlCommand();
            comandoMBC.Connection = conexion.AbrirConexion();
            comandoMBC.CommandText = "MaterialesPROespe";
            comandoMBC.CommandType = CommandType.StoredProcedure;
            comandoMBC.Parameters.AddWithValue("@PRORFC", PRORFC);
            SqlDataReader leerMBC = comandoMBC.ExecuteReader();
            DataTable tablaMBC = new DataTable();
            tablaMBC.Load(leerMBC);
            conexion.CerrarConexion();
            return tablaMBC;
        }
        public DataTable BuscarCodigo()
        {
            SqlCommand comando5 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando5.Connection = conexion.AbrirConexion();
            comando5.CommandText = "mostrarPintura";
            comando5.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer1 = comando5.ExecuteReader();
            DataTable tabla1 = new DataTable(); //Para almacenar las filas de la consulta
            tabla1.Clear();
            tabla1.Load(leer1);
            conexion.CerrarConexion();
            return tabla1;
        }
        public DataTable mostrarMarca()
        {
            SqlCommand comando6 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
            comando6.Connection = conexion.AbrirConexion();
            comando6.CommandText = "mostrarPintura";
            comando6.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando6.ExecuteReader();
            DataTable tabla2 = new DataTable(); //Para almacenar las filas de la consulta
            tabla2.Load(leer);
            conexion.CerrarConexion();

            return tabla2;
        }
        public DataTable BuscarProveedor()
        {
            SqlCommand comando7 = new SqlCommand();//Para ejecutar instrucciones o procedimientos almacenados
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

        //METODO PARA INSERTAR PINTURAS
        public void InsertarRegistro(decimal CODIGO, string MARCA, string COLOR, int CANTIDAD, decimal PRECIO, decimal PREVEN, string TIPO, string UNIDADMEDIDA, string PROVEEDOR)
        {
            SqlCommand comandoIRMP = new SqlCommand();
            comandoIRMP.Connection = conexion.AbrirConexion();
            comandoIRMP.CommandText = "InsertarPintura";
            comandoIRMP.CommandType = CommandType.StoredProcedure;
            comandoIRMP.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoIRMP.Parameters.AddWithValue("@MARCA", MARCA);
            comandoIRMP.Parameters.AddWithValue("@COLOR", COLOR);
            comandoIRMP.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
            comandoIRMP.Parameters.AddWithValue("@PRECIO ", PRECIO);
            comandoIRMP.Parameters.AddWithValue("@PREVEN ", PREVEN);
            comandoIRMP.Parameters.AddWithValue("@TIPO", TIPO);
            comandoIRMP.Parameters.AddWithValue("@UNIDADMEDIDA", UNIDADMEDIDA);
            comandoIRMP.Parameters.AddWithValue("@PROVEEDOR", PROVEEDOR);
            comandoIRMP.ExecuteNonQuery();
        }
        //METODO PARA EDITAR REGISTROS
        public void EditarRegistro(decimal CODIGO, string MARCA, string COLOR, decimal CANTIDAD, decimal PRECIO, decimal PREVEN, string TIPO, string UNIDADMEDIDA, string PROVEEDOR)
        {
            SqlCommand comandoEDMP = new SqlCommand();
            comandoEDMP.Connection = conexion.AbrirConexion();
            comandoEDMP.CommandText = "EditarPintura";
            comandoEDMP.CommandType = CommandType.StoredProcedure;
            comandoEDMP.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoEDMP.Parameters.AddWithValue("@MARCA", MARCA);
            comandoEDMP.Parameters.AddWithValue("@COLOR", COLOR);
            comandoEDMP.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
            comandoEDMP.Parameters.AddWithValue("@PRECIO ", PRECIO);
            comandoEDMP.Parameters.AddWithValue("@PREVEN ", PREVEN);
            comandoEDMP.Parameters.AddWithValue("@TIPO", TIPO);
            comandoEDMP.Parameters.AddWithValue("@UNIDADMEDIDA", UNIDADMEDIDA);
            comandoEDMP.Parameters.AddWithValue("@PROVEEDOR", PROVEEDOR);
            comandoEDMP.ExecuteNonQuery();
        }
        //METODO PARA ELIMINAR REGISTRO
        public void EliminarRegistro(int CODIGO)
        {
            SqlCommand comandoELMP = new SqlCommand();
            comandoELMP.Connection = conexion.AbrirConexion();
            comandoELMP.CommandText = "EliminarPintura";
            comandoELMP.CommandType = CommandType.StoredProcedure;
            comandoELMP.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoELMP.ExecuteNonQuery();
            comandoELMP.Parameters.Clear();
        }
        //METODO PARA ACTUALIZAR REGISTRO
        public void ActualizarPintura(decimal CODIGO, string MARCA, string COLOR, int CANTIDAD, decimal PRECIO, string TIPO, string UNIDADMEDIDA, string PROVEEDOR)
        {
            SqlCommand comandoAMP = new SqlCommand();
            comandoAMP.Connection = conexion.AbrirConexion();
            comandoAMP.CommandText = "ActualizarPintura";
            comandoAMP.CommandType = CommandType.StoredProcedure;
            comandoAMP.Parameters.AddWithValue("@CODIGO", CODIGO);
            comandoAMP.Parameters.AddWithValue("@MARCA", MARCA);
            comandoAMP.Parameters.AddWithValue("@COLOR", COLOR);
            comandoAMP.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
            comandoAMP.Parameters.AddWithValue("@PRECIO ", PRECIO);
            comandoAMP.Parameters.AddWithValue("@TIPO", TIPO);
            comandoAMP.Parameters.AddWithValue("@UNIDADMEDIDA", UNIDADMEDIDA);
            comandoAMP.Parameters.AddWithValue("@PROVEEDOR", PROVEEDOR);
            comandoAMP.ExecuteNonQuery();
        }


    }
}
