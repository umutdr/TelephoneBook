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

        public DepartmentRole DepartmentRole { get; set; }

        public Department Department { get; set; }

        public string Phone { get; set; }

    }
}
