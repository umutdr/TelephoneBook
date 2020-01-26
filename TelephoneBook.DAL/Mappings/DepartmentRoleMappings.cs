using System.Data.Entity.ModelConfiguration;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Mappings
{
    class DepartmentRoleMappings : EntityTypeConfiguration<DepartmentRole>
    {
        public DepartmentRoleMappings()
        {
            ToTable("DepartmentRoles");
        }
    }
}
