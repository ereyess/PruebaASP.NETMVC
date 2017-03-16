namespace IhopNet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelProductos : DbContext
    {
        public ModelProductos()
            : base("name=ModelProductos")
        {
        }

        public virtual DbSet<products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.Unity)
                .IsUnicode(false);
        }
    }
}
