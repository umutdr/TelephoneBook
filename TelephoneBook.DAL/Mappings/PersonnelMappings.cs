using System.Data.Entity.ModelConfiguration;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Mappings
{
    class PersonnelMappings: EntityTypeConfiguration<Personnel>
    {
        public PersonnelMappings()
        {
            ToTable("Personnels"); // schema dbo
        }
    }
}
