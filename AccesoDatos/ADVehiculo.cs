using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class ADVehiculo
    {
        public static void Ingresar(Vehiculo dataVehiculo)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Vehiculo vehiculo = db.Vehiculo.Add(dataVehiculo);
                    db.SaveChanges();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public static void Eliminar(Vehiculo dataVehiculo)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Vehiculo vehiculo = db.Vehiculo.First(c => c.Placa == dataVehiculo.Placa);
                    if (vehiculo != null)
                    {
                        db.Vehiculo.Remove(vehiculo);
                        db.SaveChanges();
                    }

                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public static Vehiculo ConsultarVehiculo(Vehiculo dataVehiculo)
        {
            ModeloEntidad db = new ModeloEntidad();
            Vehiculo vehiculo = null;
            try
            {
                vehiculo = db.Vehiculo.First(c => c.Placa == dataVehiculo.Placa);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return vehiculo;
        }

        public static List<Vehiculo> FillDDLVehiculo()
        {
            ModeloEntidad db = new ModeloEntidad();
            List<Vehiculo> vehiculos = null;
            try
            {
                vehiculos = db.Vehiculo.OrderBy(c => c.Placa).ToList();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return vehiculos;
        }

        public static void Modificar(Vehiculo dataVehiculo)
        {
            using (ModeloEntidad db = new ModeloEntidad())
            {
                try
                {
                    Vehiculo vehiculo = db.Vehiculo.First(c => c.Placa == dataVehiculo.Placa);
                    vehiculo.Placa = dataVehiculo.Placa;
                    vehiculo.Dueño = dataVehiculo.Dueño;
                    vehiculo.Marca = dataVehiculo.Marca;
                    db.SaveChanges();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }
    }
}
