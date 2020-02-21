using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelephoneBook.Entities;
using TelephoneBook.UI.Models;

namespace TelephoneBook.UI.Extensions
{
    public static class DepartmentExtensions
    {
        public static List<DepartmentViewModel> GetDepartmentViewModelsByDepartmentModels(this List<Department> departmentModels)
        {
            List<DepartmentViewModel> departmentViewModels = new List<DepartmentViewModel>();

            foreach (var department in departmentModels)
            {
                DepartmentViewModel departmentViewModel = new DepartmentViewModel
                {
                    Id = department.Id,
                    DepartmentName = department.DepartmentName
                };

                departmentViewModels.Add(departmentViewModel);
            }

            return departmentViewModels;
        }

        public static List<Department> GetDepartmentModelsByDepartmentViewModels(this List<DepartmentViewModel> departmentViewModels)
        {
            List<Department> departmentModels = new List<Department>();

            foreach (var departmentViewModel in departmentViewModels)
            {
                Department departmentModel = new Department
                {
                    Id = departmentViewModel.Id,
                    DepartmentName = departmentViewModel.DepartmentName
                };

                departmentModels.Add(departmentModel);
            }

            return departmentModels;
        }


    }
}
