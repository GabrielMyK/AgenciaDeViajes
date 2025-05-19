using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDloginUsuario
    {

        public int LoginUsuario(string nombreUsuario, string contraseña)
        {
            int idUsuario = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("LoginUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    SqlParameter idUsuarioParam = new SqlParameter("@idUsuario", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idUsuarioParam);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idUsuario = Convert.ToInt32(idUsuarioParam.Value);
                }
                catch (Exception ex)
                {
                    idUsuario = 0;
                }
            }

            return idUsuario;
        }
    }
}
