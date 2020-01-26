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
            List<Personnel> personnels = _personnelManagement.GetPersonnels();
            return personnels;
        }

        public List<Personnel> GetPersonnelsBySearchValue(string searchValue)
        {
            List<Personnel> personnels = _personnelManagement.GetPersonnelsBySearchValue(searchValue);

            return personnels;
        }

        public Personnel GetPersonnelById(int personnelId)
        {
            Personnel personennel = _personnelManagement.GetPersonnelById(personnelId);
            return personennel;
        }
    }
}
