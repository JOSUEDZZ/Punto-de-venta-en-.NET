using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Balance
    {
        private CD_Balance ObjBalance = new CD_Balance();
        public DataTable MostrarBalance()
        {
            DataTable tabla = new DataTable();
            tabla = ObjBalance.Mostrar();
            return tabla;
        }
        public DataTable MostrarCUENTAS(DateTime @FECHA)
        {
            DataTable tabla = new DataTable();
            tabla = ObjBalance.MostCuenta(@FECHA);
            return tabla;
        }
        public void InsertarBalance(decimal NOBALANCE, DateTime FECHA, decimal TOTALACTIVO, decimal TOTALPASICVO)
        {
            ObjBalance.InsertarBalance(Convert.ToDecimal(NOBALANCE), Convert.ToDateTime(FECHA),Convert.ToDecimal(TOTALACTIVO), Convert.ToDecimal(TOTALPASICVO));
        }
        public void InsertarBAV(decimal NOBALANCE, decimal FKNOVENTA, DateTime FECHA)
        {
            ObjBalance.InsertarBAV(Convert.ToDecimal(NOBALANCE), Convert.ToDecimal(FKNOVENTA),Convert.ToDateTime(FECHA));
        }
        public void InsertarBAC(decimal NOBALANCE, decimal FKNOVENTA, DateTime FECHA)
        {
            ObjBalance.InsertarBAC(Convert.ToDecimal(NOBALANCE), Convert.ToDecimal(FKNOVENTA), Convert.ToDateTime(FECHA));
        }
    }
}
