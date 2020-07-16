using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocios
{
    public class LNServicio
    {
        public void IngresarServicio(Servicios dataServicios)
        {
            ADServicio.Ingresar(dataServicios);
        }

        public void ModificarServicio(Servicios dataServicios)
        {
            ADServicio.Modificar(dataServicios);
        }

        public void EliminarServicio(Servicios dataServicios)
        {
            ADServicio.Eliminar(dataServicios);
        }

        public Servicios ConsultarServicio(Servicios dataServicio)
        {
            return ADServicio.ConsultarServicio(dataServicio);
        }
    }
}
