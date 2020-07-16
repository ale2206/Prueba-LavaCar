using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class ADServicioVehiculo
    {
        public static List<Servicios> FillDDLServicio()
        {
            ModeloEntidad db = new ModeloEntidad();
            List<Servicios> servicios = null;
            try
            {
                servicios = db.Servicios.OrderBy(c => c.Descripción).ToList();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return servicios;
        }

        public static void IngresarVehiculoServicio(Vehiculo_Servicio dataVehiculo_Servicio)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Vehiculo_Servicio vehiculoServicio = db.Vehiculo_Servicio.Add(dataVehiculo_Servicio);
                    db.SaveChanges();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public static List<Vehiculo> GetServicios(string servicioID)
        {
            ModeloEntidad db = new ModeloEntidad();
            List<Vehiculo> vehiculos = null;
            try
            {
                Vehiculo_Servicio vehiculo_Servicios = null;
                vehiculo_Servicios = db.Vehiculo_Servicio.Where(c => c.ID_Servicio.ToString() == servicioID).FirstOrDefault();

                vehiculos = db.Vehiculo.Where(c => c.ID_Vehiculo == vehiculo_Servicios.ID_Vehiculo).ToList();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return vehiculos;
        }
    }
}
