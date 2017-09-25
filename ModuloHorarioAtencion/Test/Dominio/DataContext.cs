using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DataContext : DbContext
    {
        public System.Data.Entity.DbSet<Dominio.Negocio> Negocios { get; set; }
    }
}
