using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNguia
    {
        CDguia objetoCD = new CDguia();

        public DataTable mostrarGuia()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarGuia();
            return tabla;
        }
        public void InsertarGuia(string nombre, string telefono, string idioma)
        {
            objetoCD.insertar(nombre, Convert.ToInt32(telefono),idioma);
        }
        public void editarGuia(string nombre, string telefono, string idioma,string id)
        {
            objetoCD.editar(nombre, Convert.ToInt32(telefono), idioma, Convert.ToInt32(id));
        }
        public void eliminarGuia(string id)
        {
            objetoCD.eliminar(Convert.ToInt32(id));
        }
    }
}
