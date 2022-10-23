using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntitiesCodeFIrst
{
    public class DefaultContext : DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }

        public DbSet<Classe> classes { get; set; }
        public DefaultContext(DbContextOptions options) : base(options)
        {

        }

        protected DefaultContext()
        {
        }


    }
}
