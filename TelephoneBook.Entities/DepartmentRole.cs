using System.Collections.Generic;

namespace TelephoneBook.Entities
{
    public class DepartmentRole
    {
        public DepartmentRole()
        {
            Department = new Department();
        }

        public int Id { get; set; }

        public string DepartmentRoleName { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
