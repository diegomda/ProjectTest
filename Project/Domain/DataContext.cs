using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public System.Data.Entity.DbSet<Domain.Categorias> Categorias { get; set; }

        public System.Data.Entity.DbSet<Domain.Negocios> Negocios { get; set; }
    }
}
