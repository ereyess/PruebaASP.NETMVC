namespace IhopNet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCategory : DbContext
    {
        public ModelCategory()
            : base("name=ModelCategory")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
