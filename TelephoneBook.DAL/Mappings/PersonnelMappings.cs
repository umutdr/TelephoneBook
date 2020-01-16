using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
