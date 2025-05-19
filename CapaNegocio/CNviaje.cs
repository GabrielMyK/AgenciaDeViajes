using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNviaje
    {
        private CDviaje objetoCD = new CDviaje();

        public DataTable mostrarViaje()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarViaje();
            return tabla;
        }

        public void InsertarViaje(string destino, string salida, string regreso, string descipcion, string idGuia)
        {
            objetoCD.insertar(destino, Convert.ToDateTime(salida),Convert.ToDateTime(regreso),descipcion,Convert.ToInt32(idGuia));
        }
        public void editarViaje(string destino, string salida, string regreso, string descipcion, string idGuia, string idViaje)
        {
            objetoCD.editar(destino, Convert.ToDateTime(salida), Convert.ToDateTime(regreso), descipcion, Convert.ToInt32(idGuia), Convert.ToInt32(idViaje));
        }
        public void eliminarViaje(string id)
        {
            objetoCD.eliminar(Convert.ToInt32(id));
        }
    }
}
