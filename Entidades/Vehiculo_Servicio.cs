namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculo-Servicio")]
    public partial class Vehiculo_Servicio
    {
        [Key]
        [Column("ID_Vehiculo-Servicio")]
        public int ID_Vehiculo_Servicio { get; set; }

        public int ID_Servicio { get; set; }

        public int ID_Vehiculo { get; set; }

        public virtual Servicios Servicios { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }
    }
}
