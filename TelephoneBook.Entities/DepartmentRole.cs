using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneBook.Entities
{
    public class DepartmentRole
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DepartmentRoleName { get; set; }

        public virtual List<Personnel> Personnels { get; set; }
    }
}
