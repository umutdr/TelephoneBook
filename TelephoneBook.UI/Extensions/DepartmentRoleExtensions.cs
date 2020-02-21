using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelephoneBook.Entities;
using TelephoneBook.UI.Models;

namespace TelephoneBook.UI.Extensions
{
    public static class DepartmentRoleExtensions
    {
        public static List<DepartmentRoleViewModel> GetDepartmentRoleViewModelsByDepartmentRoleModels(this List<DepartmentRole> departmentRoleModels)
        {
            List<DepartmentRoleViewModel> departmentRoleViewModels = new List<DepartmentRoleViewModel>();

            foreach (var departmentRole in departmentRoleModels)
            {
                DepartmentRoleViewModel departmentRoleViewModel = new DepartmentRoleViewModel
                {
                    Id = departmentRole.Id,
                    DepartmentRoleName = departmentRole.DepartmentRoleName
                };

                departmentRoleViewModels.Add(departmentRoleViewModel);
            }

            return departmentRoleViewModels;
        }

        public static List<DepartmentRole> GetDepartmentRoleModelsByDepartmentRoleViewModels(this List<DepartmentRoleViewModel> departmentRoleViewModels)
        {
            List<DepartmentRole> departmentRoleModels = new List<DepartmentRole>();

            foreach (var departmentRoleViewModel in departmentRoleViewModels)
            {
                DepartmentRole departmentRoleModel = new DepartmentRole
                {
                    Id = departmentRoleViewModel.Id,
                    DepartmentRoleName = departmentRoleViewModel.DepartmentRoleName
                };

                departmentRoleModels.Add(departmentRoleModel);
            }

            return departmentRoleModels;
        }

    }
}