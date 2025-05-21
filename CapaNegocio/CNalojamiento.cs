using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNalojamiento
    {
        private CDalojamiento objetoCD = new CDalojamiento();
        public DataTable mostrarAlojamiento()
        {
            DataTable tabla = new DataTable();
            tabla= objetoCD.mostrarAloja();
            return tabla;
        }

        public void insertarAloja(string nombre, string direccion, string precio, string telf, string tipo, string idViaje)
        {
            objetoCD.insertar(nombre, direccion, Convert.ToDecimal(precio), Convert.ToInt32(telf), tipo, Convert.ToInt32(idViaje)); 
        }
        public void editarAloja(string nombre, string direccion, string precio, string telf, string tipo, string idViaje, string idAloja)
        {
            objetoCD.editar(nombre, direccion, Convert.ToDecimal(precio), Convert.ToInt32(telf), tipo, Convert.ToInt32(idViaje),Convert.ToInt32(idAloja));
        }
        public void eliminarAloja(string idAloja)
        {
            objetoCD.eliminar(Convert.ToInt32(idAloja));
        }
    }
}
