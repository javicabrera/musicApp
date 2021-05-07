using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicAPP.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=local") { }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<PlayList> Listas { get; set; }
    }
}
