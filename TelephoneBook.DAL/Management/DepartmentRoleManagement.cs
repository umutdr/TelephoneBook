using System.Collections.Generic;
using System.Linq;
using TelephoneBook.DAL.Database;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Management
{
    public class DepartmentRoleManagement
    {
        private DataContext dataContext;

        public DepartmentRoleManagement()
        {
            dataContext = new DataContext();
        }

        public List<DepartmentRole> GetDepartmentRoles()
        {
            List<DepartmentRole> departmentRoles = dataContext.DepartmentRoles.ToList();

            return departmentRoles;
        }

        public DepartmentRole GetDepartmentRoleById(int Id)
        {
            var departmentRole = dataContext.DepartmentRoles.SingleOrDefault(x => x.Id == Id);

            return departmentRole;
        }

    }
}
