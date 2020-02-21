using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Management;
using TelephoneBook.Entities;

namespace TelephoneBook.Services
{
    public class DepartmentService
    {
        private DepartmentManagement departmentManagement;

        public DepartmentService()
        {
            departmentManagement = new DepartmentManagement();
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = departmentManagement.GetDepartments();

            return departments;
        }

        public Department GetDepartmentById(int Id)
        {
            var department = departmentManagement.GetDepartmentById(Id);

            return department;
        }
    }
}
