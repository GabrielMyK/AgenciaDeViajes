using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNreserva
    {
        private CDreserva objetoCD = new CDreserva();

        public DataTable mostrarReserva()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrarReserva();
            return tabla;
        }
        public void InsertarReserva(string idCliente, string idViaje, string precio, string reserva)
        {
            objetoCD.insertar(Convert.ToInt32(idCliente),Convert.ToInt32(idViaje),Convert.ToDecimal(precio),Convert.ToDateTime(reserva));
        }
        public void editarReserva(string idCliente, string idViaje, string precio, string reserva,string idReserva)
        {
            objetoCD.editar(Convert.ToInt32(idCliente), Convert.ToInt32(idViaje), Convert.ToDecimal(precio), Convert.ToDateTime(reserva),Convert.ToInt32(idReserva));
        }
        public void eliminarReserva(string idReserva)
        {
            objetoCD.eliminar(Convert.ToInt32(idReserva));
        }
    }
}
