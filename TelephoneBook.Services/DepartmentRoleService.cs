using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Management;
using TelephoneBook.Entities;

namespace TelephoneBook.Services
{
    public class DepartmentRoleService
    {
        DepartmentRoleManagement departmentRoleManagement;

        public DepartmentRoleService()
        {
            departmentRoleManagement = new DepartmentRoleManagement();
        }

        public List<DepartmentRole> GetDepartmentRoles()
        {
            List<DepartmentRole> departmentRoles = departmentRoleManagement.GetDepartmentRoles();

            return departmentRoles;
        }

        public DepartmentRole GetDepartmentRoleById(int Id)
        {
            var departmentRole = departmentRoleManagement.GetDepartmentRoleById(Id);

            return departmentRole;
        }

        public bool Create(DepartmentRole departmentRole)
        {
            var result = departmentRoleManagement.Create(departmentRole);

            return result;
        }

    }
}
