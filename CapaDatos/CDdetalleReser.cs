using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDdetalleReser
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarDetalle()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("mostrarDetalle", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;
            }
        }
        public void insertar(int idReserva, int cantidad,string tipoHabitacion, string servicioExtra, decimal costoExtra)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("insertarDetalle", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@cantidaPers",cantidad);
                cmd.Parameters.AddWithValue("@tipoHabitacion", tipoHabitacion);
                cmd.Parameters.AddWithValue("@servicioExtra", servicioExtra);
                cmd.Parameters.AddWithValue("@costoExtra", costoExtra);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void editar(int idReserva, int cantidad, string tipoHabitacion, string servicioExtra, decimal costoExtra, int idDetalle)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("editarDetalle", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@cantidaPers", cantidad);
                cmd.Parameters.AddWithValue("@tipoHabitacion", tipoHabitacion);
                cmd.Parameters.AddWithValue("@servicioExtra", servicioExtra);
                cmd.Parameters.AddWithValue("@costoExtra", costoExtra);
                cmd.Parameters.AddWithValue("@idDetalle", idDetalle);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void eliminar(int idDetalle)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("eliminarDetalle", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", idDetalle);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
