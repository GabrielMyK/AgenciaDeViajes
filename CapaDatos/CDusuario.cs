using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDusuario
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarUsu()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("MostrarUsu", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;
            }
        }
        public void insertar(string nombre, string cargo, int telefono, string correo, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("InsertarUsu",conexion);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.ExecuteNonQuery();
                conexion.Close ();
            }
        }
        public void eliminar(int id)
        {
            using(SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open ();
                SqlCommand cmd = new SqlCommand("eliminarUsu",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", id);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void modificar(string nombre, string cargo, int telefono, string correo, string contraseña, int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("modificarUsu", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conexion.Close();
                
            }
        }
    }
}
