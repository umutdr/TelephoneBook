namespace TelephoneBook.Entities
{
    public class Personnel
    {
        //public Personnel()
        //{
        //    Department = new Department();
        //    DepartmentRole = new DepartmentRole();
        //}

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual DepartmentRole DepartmentRole { get; set; } // Virtual lazy loading için kullanılır

        public virtual Department Department { get; set; }

        public string Phone { get; set; }

    }
}
