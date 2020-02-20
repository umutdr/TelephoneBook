using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TelephoneBook.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public virtual List<Personnel> Personnels { get; set; }
    }
}
