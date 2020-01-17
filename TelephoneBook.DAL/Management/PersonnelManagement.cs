using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Database;
using TelephoneBook.Entities;

namespace TelephoneBook.DAL.Management
{
    public class PersonnelManagement
    {
        private DataContext dataContext;

        public PersonnelManagement()
        {
            dataContext = new DataContext();
        }

        public List<Personnel> GetPersonnels()
        {
            List<Personnel> personnels = dataContext.personnels.ToList();

            return personnels;
        }

        public Personnel GetPersonnelById(int personnelId)
        {
            Personnel personnel = dataContext.personnels.FirstOrDefault(x => x.Id == personnelId);

            return personnel;
        }

        public List<Personnel> GetSearchValue(string searchValue)
        {
            //var personnels1 = dataContext.personnels.Where(x => x.Name.Contains(searchValue)).ToList();
            var personnels1 =
                dataContext.personnels.Where(x =>
                                                x.Name.Contains(searchValue) ||
                                                x.Surname.Contains(searchValue) ||
                                                x.Role.Contains(searchValue) ||
                                                x.Department.Contains(searchValue) ||
                                                x.Phone.Contains(searchValue)
                ).ToList();


            List<Personnel> personnels2 = personnels1.Select(x => new Personnel
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Department = x.Department,
                Role = x.Role,
                Phone = x.Phone,

            }).ToList();

            //List<Personnel> personnels = (from p in dataContext.personnels
            //                              where p.Name.Contains(searchValue)
            //                              select new Personnel { Name = p.Name }).ToList();

            return personnels2;
        }
    }
}
