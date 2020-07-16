namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculo")]
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            Vehiculo_Servicio = new HashSet<Vehiculo_Servicio>();
        }

        [Key]
        public int ID_Vehiculo { get; set; }

        [Required]
        [StringLength(30)]
        public string Placa { get; set; }

        [Required]
        public string Dueño { get; set; }

        [Required]
        [StringLength(50)]
        public string Marca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo_Servicio> Vehiculo_Servicio { get; set; }
    }
}
