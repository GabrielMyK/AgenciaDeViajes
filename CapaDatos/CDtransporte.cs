using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDtransporte
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarTransporte()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("mostrarTransporte",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;
            }
        }
        public void insertar(string tipo, int IdViaje)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("insertarTrans", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@IdViaje", IdViaje);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void editar(string tipo, int IdViaje, int IdTrans)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("editarTrans", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@IdViaje", IdViaje);
                cmd.Parameters.AddWithValue("@IdTrans", IdTrans);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public void eliminar(int idTrans)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("eliminarTrans", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTrans", idTrans);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
