using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class LNServicioVehiculo
    {
        public static List<Servicios> FillDDLServicio()
        {
            return ADServicioVehiculo.FillDDLServicio();
        }

        public static List<Vehiculo> GetServicios(string servicioID)
        {
            return ADServicioVehiculo.GetServicios(servicioID);
        }

        public void IngresarVehiculoServicio(Vehiculo_Servicio dataVehiculo_Servicio)
        {
            ADServicioVehiculo.IngresarVehiculoServicio(dataVehiculo_Servicio);
        }

        public static List<Vehiculo_Servicio> GetVehiculosServicios(string servicioID)
        {
            return ADServicioVehiculo.GetVehiculosServicios(servicioID);
        }
    }
}
