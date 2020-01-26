using System.Data.Entity.ModelConfiguration;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Mappings
{
    class DepartmentMappings : EntityTypeConfiguration<Department>
    {
        public DepartmentMappings()
        {
            ToTable("Departments");
        }
    }
}
