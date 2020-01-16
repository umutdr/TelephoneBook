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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PersonnelMappings());
        }

        public DataContext() : base("mssql-link") { }
        public DbSet<Personnel> personnels { get; set; }
    }
}
