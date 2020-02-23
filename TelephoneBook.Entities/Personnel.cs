using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneBook.Entities
{
    public class Personnel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [ForeignKey(nameof(DepartmentRole))]
        public int DepartmentRoleId { get; set; }

        public DepartmentRole DepartmentRole { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        [Required]
        public string Phone { get; set; }

    }
}
