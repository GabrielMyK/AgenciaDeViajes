using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNdetalle
    {
        private CDdetalleReser objetoCD = new CDdetalleReser();

        public DataTable mostrarDetalle()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarDetalle();
            return tabla;
        }
        public void InsertarDetalle(string idReserva, string cantidad, string tipoHabitacion, string servicioExtra, string costoExtra)
        {
            objetoCD.insertar(Convert.ToInt32(idReserva), Convert.ToInt32(cantidad), tipoHabitacion, servicioExtra, Convert.ToDecimal(costoExtra));
        }
        public void editarDetalle(string idReserva, string cantidad, string tipoHabitacion, string servicioExtra, string costoExtra,string idDetalle)
        {
            objetoCD.editar(Convert.ToInt32(idReserva), Convert.ToInt32(cantidad), tipoHabitacion, servicioExtra, Convert.ToDecimal(costoExtra), Convert.ToInt32(idDetalle));
        }
        public void eliminarDetalle(string idDetalle)
        {
            objetoCD.eliminar(Convert.ToInt32(idDetalle));
        }
    }
}
