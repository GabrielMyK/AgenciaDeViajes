using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNpago
    {
        CDpago objetoCD = new CDpago();

        public DataTable mostrarPago()
        {
            DataTable tabla = new DataTable();
            tabla= objetoCD.mostrarPago();
            return tabla;
        }
        public void insertarPago(string idReserva, string idViaje, string fechaPago, string monto, string metodoPago)
        {
            objetoCD.insertar(Convert.ToInt32(idReserva), Convert.ToInt32(idViaje), Convert.ToDateTime(fechaPago), Convert.ToDecimal(monto), metodoPago);
        }
        public void editarPago(string idReserva, string idViaje, string fechaPago, string monto, string metodoPago,string idPago)
        {
            objetoCD.editar(Convert.ToInt32(idReserva), Convert.ToInt32(idViaje), Convert.ToDateTime(fechaPago), Convert.ToDecimal(monto), metodoPago,Convert.ToInt32(idPago));
        }
        public void eliminarPago(string idPago)
        {
            objetoCD.eliminar(Convert.ToInt32(idPago));
        }
    }
}
