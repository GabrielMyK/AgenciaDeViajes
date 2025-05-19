using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNusuario
    {
        private CDusuario objetoCD = new CDusuario(); 
        public DataTable mostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarUsu();
            return tabla;
        }
        public void InsertarUsu(string nombre, string cargo, string telefono, string correo, string contraseña)
        {
            objetoCD.insertar(nombre, cargo, Convert.ToInt32(telefono), correo, contraseña);

        }

        public void eliminarUsu(string id)
        {
            objetoCD.eliminar(Convert.ToInt32(id));
        }

        public void modificarUsu(string nombre, string cargo, string telefono, string correo, string contraseña,string id)
        {
            objetoCD.modificar(nombre, cargo, Convert.ToInt32(telefono), correo, contraseña, Convert.ToInt32(id));
        }
    }
}
