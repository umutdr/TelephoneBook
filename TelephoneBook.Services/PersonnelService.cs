using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DAL.Management;
using TelephoneBook.Entities;

namespace TelephoneBook.Services
{
    public class PersonnelService
    {
        private PersonnelManagement _personnelManagement;

        public PersonnelService()
        {
            _personnelManagement = new PersonnelManagement();
        }

        public List<Personnel> GetPersonnels()
        {
            var personnels = _personnelManagement.GetPersonnels();
            return personnels;
        }

        public List<Personnel> GetSearchValue(string searchValue)
        {
            var personnels = _personnelManagement.GetSearchValue(searchValue);
            return personnels;
        }

        public Personnel GetPersonnelById(int personnelId)
        {
            var personennel = _personnelManagement.GetPersonnelById(personnelId);
            return personennel;
        }
    }
}
