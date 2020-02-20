using System.Data.Entity;
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
        }

        public DbSet<Personnel> Personnels { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentRole> DepartmentRoles { get; set; }

    }
}
