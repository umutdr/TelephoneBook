using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Database;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Management
{
    public class DepartmentManagement
    {
        private DataContext dataContext;

        public DepartmentManagement()
        {
            dataContext = new DataContext();
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = dataContext.Departments.ToList();

            return departments;
        }

        public Department GetDepartmentById(int Id)
        {
            Department department = dataContext.Departments.SingleOrDefault(x => x.Id == Id);

            return department;
        }

    }
}
