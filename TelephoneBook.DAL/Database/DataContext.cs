using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Mappings;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Database
{
    class DataContext : DbContext
    {
        public DataContext() : base("mssql-link")
        {
            var ensureDLLIsCopied =
          System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PersonnelMappings());
        }

        public DbSet<Personnel> personnels { get; set; }
    }
}
