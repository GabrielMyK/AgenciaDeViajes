using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDviaje
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarViaje()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("mostrarViaje",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
        }
        public void insertar(string destino, DateTime salida, DateTime regreso, string descripcion, int idGuia)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("InsertarViaje", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@destino", destino);
                cmd.Parameters.AddWithValue("@salida", salida);
                cmd.Parameters.AddWithValue("@regreso", regreso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@idGuia", idGuia);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void editar(string destino, DateTime salida, DateTime regreso, string descripcion, int idGuia,int idViaje)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("modificarViaje", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@destino", destino);
                cmd.Parameters.AddWithValue("@salida", salida);
                cmd.Parameters.AddWithValue("@regreso", regreso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@idGuia", idGuia);
                cmd.Parameters.AddWithValue("@idViaje", idViaje);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("eliminarViaje", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idViaje", id);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
