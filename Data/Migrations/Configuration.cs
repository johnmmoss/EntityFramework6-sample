namespace Data.Migrations
{
    using Data.Enums;
    using EFSampleConsole.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Data.Extensions;

    internal sealed class Configuration : DbMigrationsConfiguration<EFSampleConsole.TimesheetsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFSampleConsole.TimesheetsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Departments.AddOrUpdate(
                new Department() { Id = 1, Code = "SA43", Name = "HR" },
                new Department() { Id = 2, Code = "SA42", Name = "Finance" },
                new Department() { Id = 3, Code = "SA001", Name = "Training" },
                new Department() { Id = 4, Code = "SA22", Name = "IT" },
                new Department() { Id = 5, Code = "SA3", Name = "Development" }
                );


            context.EmployeeTitles.SeedEnumValues<EmployeeTitle, TitlesEnum>(e => e);

            //context.Employees.AddOrUpdate(
            //    new Employee() { Id = 1, DepartmentId = 1, Email = "bill@email.com", Forename = "Bill", Surname = "Mathers", Title = TitlesEnum.Dr },
            //    new Employee() { Id = 2, DepartmentId = 2, Email = "sarah@email.com", Forename = "Sarah", Surname = "Smith", Title = TitlesEnum.Lady, IsAdmin = true },
            //    new Employee() { Id = 3, DepartmentId = 2, Email = "sam@email.com", Forename = "Sam", Surname = "Wilcox", Title = TitlesEnum.Prof }
            //    );

        }

    }
}
