using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDguia
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarGuia()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("mostrarGuia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;
            }
        }
        public void insertar(string nombre, int telefono,string idioma)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("InsertarGuia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idioma", idioma);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void editar(string nombre, int telefono, string idioma, int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("modificarGuia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idioma", idioma);
                cmd.Parameters.AddWithValue("@idGuia", id);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("eliminarGuia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGuia", id);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
