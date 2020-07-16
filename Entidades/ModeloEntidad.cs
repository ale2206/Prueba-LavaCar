namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloEntidad : DbContext
    {
        public ModeloEntidad()
            : base("name=ModeloEntidad")
        {
        }

        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Vehiculo_Servicio> Vehiculo_Servicio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicios>()
                .Property(e => e.Descripción)
                .IsUnicode(false);

            modelBuilder.Entity<Servicios>()
                .HasMany(e => e.Vehiculo_Servicio)
                .WithRequired(e => e.Servicios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Placa)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Dueño)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .HasMany(e => e.Vehiculo_Servicio)
                .WithRequired(e => e.Vehiculo)
                .WillCascadeOnDelete(false);
        }
    }
}
