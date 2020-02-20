namespace TelephoneBook.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using TelephoneBook.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Database.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Database.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            try
            {
                if (!context.Departments.Any())
                {
                    Console.WriteLine("Adding Departments Entities");
                    context.Departments.AddOrUpdate(department => department.Id,
                        new Department() { Id = 1, DepartmentName = "IT" },
                        new Department() { Id = 2, DepartmentName = "Marketing" },
                        new Department() { Id = 3, DepartmentName = "Finance" }
                        );
                }

                if (!context.DepartmentRoles.Any())
                {
                    Console.WriteLine("Adding DepartmentRoles Entities");
                    context.DepartmentRoles.AddOrUpdate(departmentRole => departmentRole.Id,
                        new DepartmentRole() { Id = 1, DepartmentRoleName = "Software Developer" },
                        new DepartmentRole() { Id = 2, DepartmentRoleName = "Database Admin" },
                        new DepartmentRole() { Id = 3, DepartmentRoleName = "Social Media Moderetor" },
                        new DepartmentRole() { Id = 4, DepartmentRoleName = "Manager" },
                        new DepartmentRole() { Id = 5, DepartmentRoleName = "Moneyman" },
                        new DepartmentRole() { Id = 6, DepartmentRoleName = "Taxman" }
                        );
                }

                if (!context.Personnels.Any())
                {
                    Console.WriteLine("Adding Personnels Entities");
                    context.Personnels.AddOrUpdate(personnel => personnel.Id,
                        new Personnel() { Id = 1, Name = "Cenk", Surname = "Turuncu", DepartmentRoleId = 1, DepartmentId = 1, Phone = "+90-5342342354" },
                        new Personnel() { Id = 2, Name = "Hakkı", Surname = "Kırmızı", DepartmentRoleId = 2, DepartmentId = 1, Phone = "+90-5423452354" },
                        new Personnel() { Id = 3, Name = "Mert", Surname = "Mor", DepartmentRoleId = 3, DepartmentId = 2, Phone = "+90-5346434323" },
                        new Personnel() { Id = 4, Name = "Buse", Surname = "Yeşil", DepartmentRoleId = 4, DepartmentId = 2, Phone = "+90-5435442354" },
                        new Personnel() { Id = 5, Name = "Leyla", Surname = "Pembe", DepartmentRoleId = 5, DepartmentId = 3, Phone = "+90-5443452343" },
                        new Personnel() { Id = 6, Name = "Fevzi", Surname = "Sarı", DepartmentRoleId = 6, DepartmentId = 3, Phone = "+90-5415435423" }
                        );
                }

                //context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine("\n\n\n@@@");
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                Console.WriteLine("@@@\n\n\n");
                throw;
            }


        }
    }
}
