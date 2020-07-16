using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class ADServicio
    {
        public static void Ingresar(Servicios dataServicios)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Servicios servicios = db.Servicios.Add(dataServicios);
                    db.SaveChanges();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public static void Modificar(Servicios dataServicios)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Servicios servicios = db.Servicios.First(c => c.Descripción == dataServicios.Descripción);
                    servicios.Descripción = dataServicios.Descripción;
                    servicios.Monto = dataServicios.Monto;
                    db.SaveChanges();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public static Servicios ConsultarServicio(Servicios dataServicio)
        {
            ModeloEntidad db = new ModeloEntidad();
            Servicios servicio = null;
            try
            {
                servicio = db.Servicios.First(c => c.Descripción == dataServicio.Descripción);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return servicio;
        }

        public static void Eliminar(Servicios dataServicios)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Servicios servicios = db.Servicios.First(c => c.Descripción == dataServicios.Descripción);
                    if (servicios != null)
                    {
                        db.Servicios.Remove(servicios);
                        db.SaveChanges();
                    }

                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }
    }
}
