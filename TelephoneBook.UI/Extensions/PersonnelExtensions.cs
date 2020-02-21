using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelephoneBook.Entities;
using TelephoneBook.UI.Models;

namespace TelephoneBook.UI.Extensions
{
    public static class PersonnelExtensions
    {
        public static List<PersonnelViewModel> GetPersonnelViewModelsByPersonnelModels(this List<Personnel> personnelModels)
        {
            List<PersonnelViewModel> personnelsViewModels = new List<PersonnelViewModel>();

            foreach (var personnel in personnelModels)
            {
                PersonnelViewModel personnelsViewModel = new PersonnelViewModel
                {
                    Name = personnel.Name,
                    Surname = personnel.Surname,
                    DepartmentId = personnel.Department.Id,
                    DepartmentRoleId = personnel.DepartmentRole.Id,
                    Phone = personnel.Phone
                };

                personnelsViewModels.Add(personnelsViewModel);
            }

            return personnelsViewModels;
        }

        public static List<Personnel> GetPersonnelModelsByPersonnelViewModels(this List<PersonnelViewModel> personnelsViewModels)
        {
            List<Personnel> personnelsModels = new List<Personnel>();

            foreach (var personnel in personnelsViewModels)
            {
                Personnel personnelsModel = new Personnel
                {
                    Name = personnel.Name,
                    Surname = personnel.Surname,
                    DepartmentId = personnel.DepartmentId,
                    DepartmentRoleId = personnel.DepartmentRoleId,
                    Phone = personnel.Phone
                };

                personnelsModels.Add(personnelsModel);
            }

            return personnelsModels;
        }

        public static Personnel GetPersonnelModelByPersonnelViewModel(this PersonnelViewModel personnelsViewModel)
        {
            Personnel personnelsModel = new Personnel
            {
                Name = personnelsViewModel.Name,
                Surname = personnelsViewModel.Surname,
                DepartmentId = personnelsViewModel.DepartmentId,
                DepartmentRoleId = personnelsViewModel.DepartmentRoleId,
                Phone = personnelsViewModel.Phone,
            };

            return personnelsModel;
        }

    }
}