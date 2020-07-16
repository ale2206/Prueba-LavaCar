using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocios
{
    public class LNVehiculo
    {
        public void IngresarVehiculo(Vehiculo dataVehiculo)
        {
            ADVehiculo.Ingresar(dataVehiculo);
        }

        public void ModificarVehiculo(Vehiculo dataVehiculo)
        {
            ADVehiculo.Modificar(dataVehiculo);
        }

        public void EliminarVehiculo(Vehiculo dataVehiculo)
        {
            ADVehiculo.Eliminar(dataVehiculo);
        }

        public static List<Vehiculo> FillDDLVehiculo()
        {
            return ADVehiculo.FillDDLVehiculo();
        }

        public Vehiculo ConsultarVehiculo(Vehiculo dataVehiculo)
        {
            return ADVehiculo.ConsultarVehiculo(dataVehiculo);
        }
    }
}
