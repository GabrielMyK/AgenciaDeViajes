using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDpago
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarPago()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("mostrarPago",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;
            }
        }
        public void insertar(int idReserva, int idViaje, DateTime fechaPago, decimal monto,string metodoPago)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("InsertarPago", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@idViaje", idViaje);
                cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@metodoPago", metodoPago);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void editar(int idReserva, int idViaje, DateTime fechaPago, decimal monto, string metodoPago, int idPago)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("editarPago", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@idViaje", idViaje);
                cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@metodoPago", metodoPago);
                cmd.Parameters.AddWithValue("@idPago", idPago);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void eliminar(int idPago)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("eliminarPago", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPago", idPago);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
