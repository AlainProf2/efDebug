using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efDebug
{
    class BourseContexte : DbContext
    {
        public DbSet<Proprietaire> Groupe { get; set; }
        public BourseContexte() : base("name=MiniConnexion")
        {
            Database.SetInitializer<BourseContexte>(new DropCreateDatabaseAlways<BourseContexte>());
            //Database.SetInitializer<bourseContexte>(new CreateDatabaseIfNotExists<bourseContexte>());
            //Database.SetInitializer<bourseContexte>(new DropCreateDatabaseIfModelChanges<bourseContexte>());
        }
    }
}
