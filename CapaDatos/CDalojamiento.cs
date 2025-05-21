using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDalojamiento
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarAloja()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("mostrarAloja",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;
            }
        }

        public void insertar(string nombre, string direccion, decimal precio, int Telf, string tipo, int idViaje)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("insertarAloja", conexion);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@telefono", Telf);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@idViaje", idViaje);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void editar(string nombre, string direccion, decimal precio, int Telf, string tipo, int idViaje, int idAloja)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("editarAloja", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@telefono", Telf);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@idViaje", idViaje);
                cmd.Parameters.AddWithValue("@idAloja", idAloja);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void eliminar(int idAloja)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("eliminarAloja", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAloja", idAloja);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
