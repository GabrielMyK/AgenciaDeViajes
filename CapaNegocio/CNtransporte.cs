using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNtransporte
    {
        CDtransporte objetoCD= new CDtransporte();
        public DataTable mostrarTransporte()
        {
            DataTable tabla = new DataTable(); 
            tabla = objetoCD.mostrarTransporte();
            return tabla;
        }
        public void InsertarTransporte(string tipo, string IdVije)
        {
            objetoCD.insertar(tipo, Convert.ToInt32(IdVije));
        }
        public void editarTrans(string tipo, string IdViaje, string IdTrans)
        {
            objetoCD.editar(tipo,Convert.ToInt32(IdTrans), Convert.ToInt32(IdViaje));
        }
        public void eliminarTrans(string IdTrans)
        {
            objetoCD.eliminar(Convert.ToInt32(IdTrans));
        }
    }
}
