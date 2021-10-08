using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApiXamarin.Models
{
    public partial class DBPasajeContext : DbContext
    {
        public DBPasajeContext()
            : base("name=DBPasajeContext")
        {
        }

        public virtual DbSet<Marca> Marca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.descripcion)
                .IsUnicode(false);
        }
    }
}
