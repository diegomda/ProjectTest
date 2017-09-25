using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TesteoHorario.Models
{
    public class DataContext : DbContext
    {
        public System.Data.Entity.DbSet<Dominio.Negocio> Negocios { get; set; }
    }
}