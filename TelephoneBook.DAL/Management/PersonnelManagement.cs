using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Database;
using System.Data.Entity; // .Include(x => x.xxx) (İlişkilerin datasını görebilmek için, lazy loading)
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
            List<Personnel> personnels = dataContext.Personnels.ToList();

            return personnels;
        }

        public bool Create(Personnel personnel)
        {
            dataContext.Personnels.Add(personnel);
            var result = dataContext.SaveChanges();
            return result > 0;
        }

        public Personnel GetPersonnelById(int personnelId)
        {
            //Personnel personnel = dataContext.Personnels.Include(x => x.DepartmentRole).Include(y => y.Department).FirstOrDefault(x => x.Id == personnelId);
            Personnel personnel = dataContext.Personnels.FirstOrDefault(x => x.Id == personnelId);

            return personnel;
        }

        public List<Personnel> GetPersonnelsBySearchValue(string searchValue)
        {
            //List<Personnel> personnels = dataContext.Personnels.Include(x => x.DepartmentRole).Include(y => y.Department).Where(x =>
            List < Personnel> personnels = dataContext.Personnels.Where(x =>
                                        x.Name.Contains(searchValue) ||
                                        x.Surname.Contains(searchValue) ||
                                        x.DepartmentRole.DepartmentRoleName.Contains(searchValue) ||
                                        x.Department.DepartmentName.Contains(searchValue) ||
                                        x.Phone.Contains(searchValue)).ToList();

            return personnels;
        }
    }
}
