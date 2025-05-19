using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNcliente
    {
        private CDcliente objetoCD = new CDcliente();

        public DataTable mostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarClien();
            return tabla;
        }
        public void InsertarCliente(string nombre, string apellido, string direccion, string Pasaporte, string telefono, string correo)
        {
            objetoCD.insertar(nombre, apellido, direccion, Pasaporte, Convert.ToInt32(telefono), correo);
        }
        public void modificarCliente(string nombre, string apellido, string direccion, string Pasaporte, string telefono, string correo, string id)
        {
            objetoCD.modificar(nombre, apellido, direccion, Pasaporte, Convert.ToInt32(telefono), correo, Convert.ToInt32(id));
        }
        public void eliminarClien(string id)
        {
            objetoCD.eliminar(Convert.ToInt32(id));
        }
    }
}
